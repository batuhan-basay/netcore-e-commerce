using MvcWebUl.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;


namespace MvcWebUl.Entity
{
    public class DataContext : DbContext
    {

        public DataContext():base("dataConnection")
        {
        }

        public DbSet<Product> Products{ get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}