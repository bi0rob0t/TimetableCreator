using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeTable.Models.DBModels
{
    class Hour
    {
        public int HourId { get; set; }
        public Group Group{ get; set; }
        public Discipline Discipline { get; set; }
        public int Hours { get; set; }
    }
}
