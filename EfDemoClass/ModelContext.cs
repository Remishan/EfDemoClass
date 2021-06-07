using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfDemoClass
{
  public  class ModelContext : DbContext

    {
        public ModelContext() : base("name=Con") { }
        public DbSet<Car> CarList { get; set; }
    }
}
