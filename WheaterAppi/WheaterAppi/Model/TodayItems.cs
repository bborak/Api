using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheaterAppi.Model
{
    public class TodayItems
    {
        public int ID { get; set; }
        public string  CityName { get; set; }
        public string  Temperature { get; set; }
        public string Description { get; set; }
        //public string Day { get; set; }
        public string  SunRise { get; set; }
        public string  SunSet { get; set; }
        public string  MoonRise { get; set; }
        public string MoonSet { get; set; }
        public string Presure { get; set; }
        public string Wind { get; set; }
        public string TempActual { get; set; }
      //  public DateTime Datee { get; set; }
    }
}
