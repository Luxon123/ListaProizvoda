using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Items.Models
{
    public class ItemsContext : DbContext
    {
        public DbSet<Proizvod> Items { get; set; }
    }
}