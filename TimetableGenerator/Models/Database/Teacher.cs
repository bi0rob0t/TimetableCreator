using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeTable.Models.DBModels
{
    class Teacher
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public int Load { get; set; }
    }
}
