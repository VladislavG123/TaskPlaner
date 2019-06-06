using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerApplication.Models.Abstract;

namespace TaskManagerApplication.Models
{
    public class MoveDirectoryPageInformation : PageInformation
    {
        public string From { get; set; }
        public string To { get; set; }
    }
}
