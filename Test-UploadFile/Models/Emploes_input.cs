using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_UploadFile.Models
{
    public class Emploes_input
    {
        public int Emp_id { get; set; }
        public int Project_id { get; set; }
        public DateTime Date_from { get; set; }
        public DateTime Date_to { get; set; }
        public int Count_days_worked { get; set; }
    }
}
