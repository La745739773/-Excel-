namespace Microsoft
{
    internal class Office
    {
        internal class Interop
        {
            internal class Excel
            {
                public static object XlWBATemplate { get; internal set; }

                internal class Application
                {
                   // public object Application { get; internal set; }
                    public object Visible { get; internal set; }
                    public object Workbooks { get; internal set; }
                }

                internal class Workbook
                {
                }
            }
        }
    }
}