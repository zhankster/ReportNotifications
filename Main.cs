using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;
using System.Data.SqlClient;


namespace ReportNotifications
{

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        string CONN_CIPS = Properties.Settings.Default.CONN_CIPS;
        List<Facility> facilities = new List<Facility>();

        #region Data Functions
        protected string GetFacility(string fac_code)
        {
            string fac_name = "None";
            string sql = "SELECT * FROM FAC WHERE DCODE ='" + fac_code + "'";
            using (SqlConnection conn = new SqlConnection(CONN_CIPS))
            {

            }

            return fac_name;
        }

        #endregion

        #region Utility Functions
        public void WriteActivity(string msg)
        {
            var dt = DateTime.Now.ToString("yy-MM-dd HH:mm:ss");
            string[] arr = new string[3];
            ListViewItem itm;
            //add items to ListView
            arr[0] = dt;
            arr[1] = msg;
            itm = new ListViewItem(arr);

            lvProcessing.Items.Add(itm);
        }

        public void readExcelFile(string pth)
        {
            //Create COM Objects. Create a COM object for everything that is referenced
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@pth);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;


            int rowCount = xlRange.Rows.Count;
            int colCount = 2; //xlRange.Columns.Count;

            //iterate over the rows and columns and print to the console as it appears in the file
            //excel is not zero based!!
            var strVal = "";
            for (int i = 1; i <= rowCount; i++)
            {
                //for (int j = 1; j <= colCount; j++)
                if (colCount == 2 && i > 1)
                {
                    //new line
                    //if (j == 1)
                    //{
                    //    //Console.Write("\r\n");
                    //    //WriteActivity("");
                    //}

                    //write the value to the console
                    if (xlRange.Cells[i, colCount] != null && xlRange.Cells[i, colCount].Value2 != null)
                    {
                        //Console.Write(xlRange.Cells[i, j].Value2.ToString() + "\t");
                        strVal = xlRange.Cells[i, colCount].Value2.ToString();
                        if (strVal.Trim() != "" )
                        {
                            var s = strVal.Split('-')[0];
                            if (strVal.Length < 4 )
                            WriteActivity(s.Trim());
                        }
                    }

                    //add useful things here!   
                }
            }
        }
        #endregion

        #region Click Events
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();

            if (fd.ShowDialog() == DialogResult.OK)
            {
                readExcelFile(fd.FileName);
            }
        }
        #endregion

    }
}
