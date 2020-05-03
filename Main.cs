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
using System.Security.Cryptography;
using System.IO;

namespace ReportNotifications
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            CONN_CIPS = prop.CIPS;
            GetSettings();
        }

        #region Global Vars
        ReportNotifications.Properties.Settings prop = ReportNotifications.Properties.Settings.Default;
        static string CONN_CIPS = "";
        static string CONN_RX = "";
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

        public void ExportReport(string report, string export_path, string export_type, string[] parms, string dsn)
        {

            Utility.WriteActivity(gvNotiifications.Rows.Count.ToString());
            var current_date = DateTime.Now.ToString("MM-dd-yyyy");
            var report_date = dptFacExport.Value.ToString("MM-dd-yyyy");
            if (current_date == report_date)
            {
                DialogResult result = MessageBox.Show("The select date is the same as the current date\nDo you want to use it?",
                    "Use Current Date", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            string code = "", typ="", valid="";
            for (int i = 0; i+1 < gvNotiifications.Rows.Count; i++)
            {
                code = gvNotiifications.Rows[i].Cells[0].Value.ToString();
                typ = gvNotiifications.Rows[i].Cells[2].Value.ToString();
                valid = gvNotiifications.Rows[i].Cells[3].Value.ToString();

                string[] rpt = { "-S", dsn,
                "-F", report,
                "-O", export_path + current_date + "_" + code + ".pdf",
                "-E", export_type};
                string[] p = { "-A", "Facility:" + code, "-A", "DateAfter:" + report_date };

                var rpt_data = rpt.Concat(p).ToArray();

                if (valid == "True")
                {
                    Utility.WriteActivity(code + "- Notify Type: " + typ);
                    RunReport(rpt_data);
                }

            }

            //RunReport(rpt_data);
        }
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
        public static void WriteConfig(string key, string val)
        {
            Properties.Settings.Default[key] = val;
            Properties.Settings.Default.Save();
        }

        public static string ReadConfig(string key)
        {
            return Properties.Settings.Default[key].ToString();
        }

        public void GetSettings()
        {
            txtNotifyReport.Text = ReadConfig("NotifyReport");
            txtNotifyExports.Text = ReadConfig("NotifyExports");
            txtCIPS.Text = ReadConfig("CIPS");
            txtRxBackend.Text = ReadConfig("RxBackend");
            CONN_CIPS = ReadConfig("CIPS");
            CONN_RX = ReadConfig("RxBackend");
            txtAddress.Text = ReadConfig("EmailAddress");
            txtPassword.Text  = Decrypt(ReadConfig("EmailPassword"));
            txtMailbox.Text = ReadConfig("Mailbox");
            txtEmailServer.Text = ReadConfig("EmailServer");
        }

        public void UpdateSettings(string configName, string newText, string activityText, bool includeValues)
        {
            string prevText = ReadConfig(configName);
            string values = includeValues ? " [" + prevText + "] to [" + newText + "]" : "";
            WriteConfig(configName, newText);
            WriteActivity(activityText + values);
        }

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

        public static string Encrypt(string textToEncrypt)
        {
            try
            {
                string ToReturn = "";
                string _key = "ay$a5%&jwrtmnh;lasjdf98787";
                string _iv = "abc@98797hjkas$&asd(*$%";
                byte[] _ivByte = { };
                _ivByte = System.Text.Encoding.UTF8.GetBytes(_iv.Substring(0, 8));
                byte[] _keybyte = { };
                _keybyte = System.Text.Encoding.UTF8.GetBytes(_key.Substring(0, 8));
                MemoryStream ms = null; CryptoStream cs = null;
                byte[] inputbyteArray = System.Text.Encoding.UTF8.GetBytes(textToEncrypt);
                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {
                    ms = new MemoryStream();
                    cs = new CryptoStream(ms, des.CreateEncryptor(_keybyte, _ivByte), CryptoStreamMode.Write);
                    cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cs.FlushFinalBlock();
                    ToReturn = Convert.ToBase64String(ms.ToArray());
                }
                return ToReturn;
            }
            catch (Exception ae)
            {
                throw new Exception(ae.Message, ae.InnerException);
            }
        }

        public static string Decrypt(string textToDecrypt)
        {
            try
            {
                string ToReturn = "";
                string _key = "ay$a5%&jwrtmnh;lasjdf98787";
                string _iv = "abc@98797hjkas$&asd(*$%";
                byte[] _ivByte = { };
                _ivByte = System.Text.Encoding.UTF8.GetBytes(_iv.Substring(0, 8));
                byte[] _keybyte = { };
                _keybyte = System.Text.Encoding.UTF8.GetBytes(_key.Substring(0, 8));
                MemoryStream ms = null; CryptoStream cs = null;
                byte[] inputbyteArray = new byte[textToDecrypt.Replace(" ", "+").Length];
                inputbyteArray = Convert.FromBase64String(textToDecrypt.Replace(" ", "+"));
                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {
                    ms = new MemoryStream();
                    cs = new CryptoStream(ms, des.CreateDecryptor(_keybyte, _ivByte), CryptoStreamMode.Write);
                    cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cs.FlushFinalBlock();
                    Encoding encoding = Encoding.UTF8;
                    ToReturn = encoding.GetString(ms.ToArray());
                }
                return ToReturn;
            }
            catch (Exception ae)
            {
                throw new Exception(ae.Message, ae.InnerException);
            }
           
        }

        #endregion

        #region Click Events
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Excel Files | *.xlsx; *.xls";
            //WriteActivity("Open File Dialog");

            if (fd.ShowDialog() == DialogResult.OK)
            {
                readExcelFile(fd.FileName);
            }
        }

        private void btnFileExport_Click(object sender, EventArgs e)
        {
            string[] parms = { "-A", "Facility:DJ", "-A", "DateAfter:05-01-2020" };
            ExportReport(txtNotifyReport.Text,  txtNotifyExports.Text, "pdf", parms, "CIPS");
        }

        private void btnNotifyReport_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to update the selected value?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            var folder = "";
            OpenFileDialog fbd = new OpenFileDialog();
            fbd.Filter = "Report Files | *.rpt";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(fbd.FileName.ToString()))
                {
                    return;
                }

                folder = fbd.FileName;
                txtNotifyReport.Text = folder;
                WriteConfig("NotifyReport", folder);
                Utility.WriteActivity("Notify Report updated");
            }
            else
            {
                return;
            }
        }

        private void btnNotifyExports_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to update the selected value?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            var folder = "";
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(fbd.SelectedPath.ToString()))
                {
                    return;
                }

                folder = fbd.SelectedPath + @"\";
                txtNotifyExports.Text = folder;
                WriteConfig("NotifyExports", folder);
                Utility.WriteActivity("Notify Exports updated");
            }
            else
            {
                return;
            }
        }

        private void btnTextBox_Click(object sender, EventArgs e)
        {
            try
            {
                var btnName = ((sender as Button).Name);
                (sender as Button).BackColor = Color.Yellow;

                if (MessageBox.Show("Do you want to update the selected value?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                switch (btnName)
                {
                    case "btnCIPS":
                        UpdateSettings("CIPS", txtCIPS.Text, "CIPS connection changed from ", true);
                        CONN_CIPS = txtCIPS.Text;
                        break;
                    case "btnRxBackend":
                        UpdateSettings("RxBackend", txtRxBackend.Text, "RxBackend connection changed from ", true);
                        CONN_RX = txtRxBackend.Text;
                        break;
                    case "btnAddress":
                        UpdateSettings("EmailAddress", txtAddress.Text, "Email Address changed from ", true);
                        CONN_RX = txtRxBackend.Text;
                        break;
                    case "btnPassword":
                        UpdateSettings("EmailPassword", Encrypt(txtPassword.Text), "Email Password changed", false);
                        break;
                    case "btnMailbox":
                        UpdateSettings("Mailbox", txtMailbox.Text, "Mailbox changed from ", true);
                        break;
                    case "btnEmailServer":
                        UpdateSettings("EmailServer", txtEmailServer.Text, "Email server changed from ", true);
                        break;
                }


            }
            catch (Exception ex)
            {
                //LogError(ex.Message);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                (sender as Button).BackColor = Color.Transparent;
            }

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //Utility ut = new Utility();
            //Utility.WriteActivity("test");
            ////WriteActivity("main");
            //string[] parms = { "-A", "Fac:DJ" };
            //ExportReport(@"C:\Files\OP.rpt", @"C:\Files\", "pdf", parms, "Rx");
            txtInfo.Text = Encrypt(txtPassword.Text);
            txtInfo.Text += txtPassword.Text;

        }


        #endregion

        
    }
}
