using _05_Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _05_Models.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext() : base("Server=DESKTOP-2E64I20;Database=TestDB;Integrated Security=true")
        {

        }

        public DbSet<Kullanici> Kullanicis { get; set; }
    }
}