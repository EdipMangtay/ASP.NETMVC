using _04_View_Controller_Data_Transfer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _04_View_Controller_Data_Transfer.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext():base("Server=DESKTOP-2E64I20;Database=TestDB;Integrated Security=true")
        {
            
        }

        public DbSet<Kullanici> Kullanicis { get; set; }
    }
}