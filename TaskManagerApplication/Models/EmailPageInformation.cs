using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerApplication.Models.Abstract;

namespace TaskManagerApplication.Models
{
    class EmailPageInformation : PageInformation
    {
        public string Recipient { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
    }
}
