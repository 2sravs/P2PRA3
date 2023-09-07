using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Project3.Data
{
    public class Project3DbContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Project3DbContext() : base("name=Project3DbContext")
        {
        }

        public System.Data.Entity.DbSet<Project3.Models.Students> Students { get; set; }
    }
}
