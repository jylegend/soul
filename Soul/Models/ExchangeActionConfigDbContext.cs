using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Soul.Models
{
    public class ExchangeActionConfigDbContext : DbContext
    {
        public DbSet<Product> Product { get; set; }

        public DbSet<ExchangeActionConfig> ExchangeActionConfig { get; set; }
    }
}