using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerApplication.Models.Abstract;

namespace TaskManagerApplication.Models
{
    public class ActionInfo
    {
        public DateTime? StartDate { get; set; }
        public Pereodicity Pereodicity { get; set; }
        public Type Type { get; set; }
        public PageInformation PageInformation { get; set; }
    }
}
