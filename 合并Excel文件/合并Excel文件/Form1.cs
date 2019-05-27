using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 合并Excel文件
{
    public partial class MergeExcel : Form
    {
        public DataSet ds;
        public string[] file_Names;
        public string output_filename;

        public MergeExcel()
        {
            InitializeComponent();
            ds = new DataSet();
        }
        /// <summary>
        /// C#中获取Excel文件的第一个表名 
        /// Excel文件中第一个表名的缺省值是Sheet1$, 但有时也会被改变为其他名字. 如果需要在C#中使用OleDb读写Excel文件, 就需要知道这个名字是什么. 以下代码就是实现这个功能的:
        /// </summary>
        /// <param name="excelFileName"></param>
        /// <returns></returns>
        public static string GetExcelFirstTableName(string excelFileName)
        {
            string tableName = null;
            if (File.Exists(excelFileName))
            {
                using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;" +
                  "Extended Properties=\"Excel 12.0\";Data Source=" + excelFileName))
                {
                    conn.Open();
                    DataTable dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    tableName = dt.Rows[0][2].ToString().Trim();
                }
            }
            return tableName;
        }

        private void OpenFiles_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel files (*.xls,*.xlsx)|*.xls;*.xlsx|All files (*.*)|*.*";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file_Names = openFileDialog1.FileNames;
                for(int i = 0;i<file_Names.Length;i++)
                {
                    string filename = System.IO.Path.GetFileName(file_Names[i]);
                    Textbox_ExcelFileList.Text = Textbox_ExcelFileList.Text + filename + "\r\n";

                    string strConn = @"Provider=Microsoft.Ace.OleDb.12.0;Data Source=" + file_Names[i] + ";Extended Properties='Excel 12.0';";
                    //string strConn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + file_Names[i] + ";Extended Properties='Excel 8.0';";
                    OleDbConnection conn = new OleDbConnection(strConn);
                    conn.Open();
                    string tableName = null;
                    DataTable dt_test = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    tableName = dt_test.Rows[0][2].ToString().Trim();

                    OleDbDataAdapter myCommand = null;
                    myCommand = new OleDbDataAdapter("select * from ["+ tableName + "]", strConn);
                        //OleDbDataAdapter oada = new OleDbDataAdapter("select * from [结果数据$]", strConn);
                    DataTable dt = new DataTable();
                    myCommand.Fill(dt);
                    ds.Tables.Add(dt);
                }
                MessageBox.Show("读取成功!请选择输出文件!");
            }
        }

        private void ReadExcelFiles_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        private void OutputFile_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.csv)|*.csv";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel) 
            {
                return;
            }
            output_filename = saveFileDialog.FileName;
            Textbox_outputFile.Text = System.IO.Path.GetFileName(saveFileDialog.FileName);
        }

        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(output_filename, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            for(int i = 0;i<ds.Tables.Count;i++)
            {
                DataTable temp_dt = ds.Tables[i];
                for(int j = 0; j < temp_dt.Rows.Count;j++)
                {
                    for(int k = 0;k<temp_dt.Columns.Count;k++)
                    {
                        sw.Write(temp_dt.Rows[j][k].ToString() + ',');
                    }
                    sw.WriteLine("");
                }
            }
            sw.Close();
            fs.Close();
            MessageBox.Show("合并完成");
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 作者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("李昂——南京大学");
        }

        private void MergeExcel_Load(object sender, EventArgs e)
        {

        }
    }
}
