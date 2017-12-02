using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheaterAppi.Model
{
    public class ContextWheather : DbContext
    {
        public DbSet<TodayItems> Todays { get; set; }
        public DbSet<City>Citys { get; set; }

        public DbSet<Activity> Activities { get; set; }
      //  public DbSet<DaysWheaterItem>DaysItems { get; set; }
    }
}       
