using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportNotifications
{
    public class Facility
    {
        public string code { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string fax { get; set; }
        public string email { get; set; }
        public string notify_type { get; set; }
        public bool valid_code { get; set; }
    }
}
