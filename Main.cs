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
using System.Data.SqlClient;
using System.Diagnostics;
using CrystalReportsNinja;


namespace ReportNotifications
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            CONN_CIPS = prop.CONN_CIPS;
        }

        #region Global Vars
        ReportNotifications.Properties.Settings prop = ReportNotifications.Properties.Settings.Default;
        static string CONN_CIPS = "";
        List<Facility> facilities = new List<Facility>();
        public struct Fac 
        {
            public string name { get; set; }
            public string code { get; set; }
            public string email { get; set; }
            public string fax { get; set; }
        }
        #endregion

        #region Database Functions
        protected Fac GetFacility(string fac_code)
        {
            Fac fac = new Fac
            {
                code = fac_code,
                name = "null",
                email = "null",
                fax = "null"
            };

            string sql = "SELECT * FROM FAC WHERE DCODE = @dcode";
            using (SqlConnection conn = new SqlConnection(CONN_CIPS))
            {
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@dcode", fac_code);

                try
                {
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        fac.name = reader["DNAME"].ToString();
                        fac.email = reader["EMAIL"].ToString();
                        fac.fax = reader["FAX1"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            return fac;
        }

        #endregion

        #region Reporting Funcions
        public void RunReport(string[] args)
        {
            try
            {
                // read program arguments into Argument Container
                ArgumentContainer argContainer = new ArgumentContainer();
                argContainer.ReadArguments(args);

                if (argContainer.GetHelp)
                    Helper.ShowHelpMessage();
                else
                {
                    string _logFilename = string.Empty;

                    if (argContainer.EnableLog)
                        _logFilename = "ninja-" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".log";

                    ReportProcessor reportNinja = new ReportProcessor(_logFilename)
                    {
                        ReportArguments = argContainer,
                    };

                    reportNinja.Run();
                }
            }
            catch (Exception ex)
            {
                WriteActivity(string.Format("Exception: {0}", ex.Message));
                WriteActivity(string.Format("Inner Exception: {0}", ex.InnerException));
            }
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
            WriteActivity("Reading: " + pth);
            facilities.Clear();
            //Create COM Objects. Create a COM object for everything that is referenced
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@pth);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;


            int rowCount = xlRange.Rows.Count;
            int colCount = prop.FAC_COLUMN; //xlRange.Columns.Count;

            //iterate over the rows and columns and print to the console as it appears in the file
            //excel is not zero based!!
            var strVal = "";
            for (int i = 1; i <= rowCount; i++)
            {
                //for (int j = 1; j <= colCount; j++)
                if (colCount == prop.FAC_COLUMN && i > 1)
                {
                    //new line
                    //if (j == 1)
                    //{
                    //    //Console.Write("\r\n");
                    //    //WriteActivity("");
                    //}

                    try
                    {
                        if (xlRange.Cells[i, colCount] != null && xlRange.Cells[i, colCount].Value2 != null)
                        {
                            var fac = new Fac();
                            //Console.Write(xlRange.Cells[i, j].Value2.ToString() + "\t");
                            strVal = xlRange.Cells[i, colCount].Value2.ToString();
                            if (strVal.Trim() != "")
                            {
                                var h = strVal.Split('-')[0]; //Hyphen split
                                var s = strVal.Split(' ')[0];//Space split
                                if (h.Length < 4)
                                {
                                    WriteActivity(h.Trim());
                                    fac = GetFacility(h.Trim());
                                    WriteActivity(fac.name);
                                }
                                else if (s.Length < 4)
                                {
                                    WriteActivity(s.Trim());
                                    fac = GetFacility(s.Trim());
                                    WriteActivity(fac.name);
                                }
                                else
                                {
                                    WriteActivity(strVal);
                                    fac.code = strVal;
                                    fac.name = "null";
                                    fac.email = "null";
                                    fac.fax = "null";
                                    WriteActivity(fac.name);
                                }
                                var valid = fac.name != "null" ? true : false;
                                var notify_type = strVal.Contains("(e") && valid ? "email" : "fax";
                                Facility facility = new Facility(fac.code, fac.name, " ", fac.fax, fac.email, notify_type, valid);
                                facilities.Add(facility);
                            }
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("Code", typeof(string));
            dt.Columns.Add("Facility Name", typeof(string));
            dt.Columns.Add("Notify Type", typeof(string));
            dt.Columns.Add("Valid", typeof(string));
            foreach (var fac in facilities)
            {
                DataRow dr = dt.NewRow();
                dr["Code"] = fac.code;
                dr["Facility Name"] = fac.name;
                dr["Notify Type"] = fac.notify_type;
                dr["Valid"] = fac.valid_code.ToString();
                dt.Rows.Add(dr);
                if (!fac.valid_code)
                {
                    txtInfo.Text += fac.code + "\r\n";
                }
            }

            gvNotiifications.DataSource = dt;
            Process[] excelProcesses = Process.GetProcessesByName("excel");
            foreach (Process p in excelProcesses)
            {
                if (string.IsNullOrEmpty(p.MainWindowTitle)) // use MainWindowTitle to distinguish this excel process with other excel processes 
                {
                    p.Kill();
                }
            }
        }
        #endregion

        #region Click Events
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            //WriteActivity("Open File Dialog");

            if (fd.ShowDialog() == DialogResult.OK)
            {
                readExcelFile(fd.FileName);
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //Utility ut = new Utility();
            Utility.WriteActivity("test");
            //WriteActivity("main");

            string[] report = { "-S", "Rx",
                "-F", @"C:\Files\OP.rpt",
                "-O", @"C:\Files\OPP.pdf",
                "-E", "pdf",
                "-A",  "Fac:DJ"};

            WriteActivity(report[0] + " " + report[1]);
            WriteActivity(report[2] + " " + report[3]);
            WriteActivity(report[4] + " " + report[5]);
            WriteActivity(report[6] + " " + report[7]);
            WriteActivity(report[8] + " " + report[9]);
            RunReport(report);


            //var fac = GetFacility("IA");
            //MessageBox.Show(fac.name + "::" + fac.email + "::" + fac.fax);
        }
        #endregion


    }
}
