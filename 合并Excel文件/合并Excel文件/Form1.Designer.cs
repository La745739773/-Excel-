namespace 合并Excel文件
{
    partial class MergeExcel
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenFiles_btn = new System.Windows.Forms.Button();
            this.Textbox_ExcelFileList = new System.Windows.Forms.TextBox();
            this.OutputFile_btn = new System.Windows.Forms.Button();
            this.Textbox_outputFile = new System.Windows.Forms.TextBox();
            this.ReadExcelFiles = new System.ComponentModel.BackgroundWorker();
            this.Confirm_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.作者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFiles_btn
            // 
            this.OpenFiles_btn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OpenFiles_btn.Location = new System.Drawing.Point(12, 25);
            this.OpenFiles_btn.Name = "OpenFiles_btn";
            this.OpenFiles_btn.Size = new System.Drawing.Size(119, 32);
            this.OpenFiles_btn.TabIndex = 0;
            this.OpenFiles_btn.Text = "选择输入文件";
            this.OpenFiles_btn.UseVisualStyleBackColor = true;
            this.OpenFiles_btn.Click += new System.EventHandler(this.OpenFiles_btn_Click);
            // 
            // Textbox_ExcelFileList
            // 
            this.Textbox_ExcelFileList.Location = new System.Drawing.Point(12, 63);
            this.Textbox_ExcelFileList.Multiline = true;
            this.Textbox_ExcelFileList.Name = "Textbox_ExcelFileList";
            this.Textbox_ExcelFileList.ReadOnly = true;
            this.Textbox_ExcelFileList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Textbox_ExcelFileList.Size = new System.Drawing.Size(119, 147);
            this.Textbox_ExcelFileList.TabIndex = 1;
            // 
            // OutputFile_btn
            // 
            this.OutputFile_btn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OutputFile_btn.Location = new System.Drawing.Point(167, 25);
            this.OutputFile_btn.Name = "OutputFile_btn";
            this.OutputFile_btn.Size = new System.Drawing.Size(119, 32);
            this.OutputFile_btn.TabIndex = 0;
            this.OutputFile_btn.Text = "保存文件";
            this.OutputFile_btn.UseVisualStyleBackColor = true;
            this.OutputFile_btn.Click += new System.EventHandler(this.OutputFile_btn_Click);
            // 
            // Textbox_outputFile
            // 
            this.Textbox_outputFile.Location = new System.Drawing.Point(167, 63);
            this.Textbox_outputFile.Multiline = true;
            this.Textbox_outputFile.Name = "Textbox_outputFile";
            this.Textbox_outputFile.ReadOnly = true;
            this.Textbox_outputFile.Size = new System.Drawing.Size(119, 64);
            this.Textbox_outputFile.TabIndex = 1;
            // 
            // ReadExcelFiles
            // 
            this.ReadExcelFiles.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ReadExcelFiles_DoWork);
            // 
            // Confirm_btn
            // 
            this.Confirm_btn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Confirm_btn.Location = new System.Drawing.Point(167, 133);
            this.Confirm_btn.Name = "Confirm_btn";
            this.Confirm_btn.Size = new System.Drawing.Size(119, 32);
            this.Confirm_btn.TabIndex = 0;
            this.Confirm_btn.Text = "确定合并";
            this.Confirm_btn.UseVisualStyleBackColor = true;
            this.Confirm_btn.Click += new System.EventHandler(this.Confirm_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cancel_btn.Location = new System.Drawing.Point(167, 177);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(119, 32);
            this.Cancel_btn.TabIndex = 0;
            this.Cancel_btn.Text = "取消";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.作者ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(332, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 作者ToolStripMenuItem
            // 
            this.作者ToolStripMenuItem.Name = "作者ToolStripMenuItem";
            this.作者ToolStripMenuItem.Size = new System.Drawing.Size(82, 21);
            this.作者ToolStripMenuItem.Text = "Don\'t Click";
            this.作者ToolStripMenuItem.Click += new System.EventHandler(this.作者ToolStripMenuItem_Click);
            // 
            // MergeExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(332, 222);
            this.Controls.Add(this.Textbox_outputFile);
            this.Controls.Add(this.Textbox_ExcelFileList);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Confirm_btn);
            this.Controls.Add(this.OutputFile_btn);
            this.Controls.Add(this.OpenFiles_btn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MergeExcel";
            this.Load += new System.EventHandler(this.MergeExcel_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenFiles_btn;
        private System.Windows.Forms.TextBox Textbox_ExcelFileList;
        private System.Windows.Forms.Button OutputFile_btn;
        private System.Windows.Forms.TextBox Textbox_outputFile;
        private System.ComponentModel.BackgroundWorker ReadExcelFiles;
        private System.Windows.Forms.Button Confirm_btn;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 作者ToolStripMenuItem;
    }
}

