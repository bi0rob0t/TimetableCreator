using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace TimeTable.Models.DBModels
{
    class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("ConectionString") { }
        

        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Hour> Hours { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        // TODO more tables for teachers and discipline
    }
}
