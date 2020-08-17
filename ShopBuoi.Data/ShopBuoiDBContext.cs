using ShopBuoi.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBuoi.Data
{
    public class ShopBuoiDBContext : DbContext
    {
        public ShopBuoiDBContext() : base("ShopBuoiConnection")
            {
            this.Configuration.LazyLoadingEnabled = false;
            }
        public DbSet<Footer> Footers { set; get; }
    }
}
