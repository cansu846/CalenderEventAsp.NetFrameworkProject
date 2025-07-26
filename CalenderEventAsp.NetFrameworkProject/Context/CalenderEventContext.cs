using CalenderEventAsp.NetFrameworkProject.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace CalenderEventAsp.NetFrameworkProject.Context
{
    public class CalenderEventContext : DbContext
    {

        public CalenderEventContext():base("name=CalenderEventContext")
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Event> Events { get; set; }
    }
}