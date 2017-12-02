using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WheaterAppi.Model;

namespace WheaterAppi
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dzisiaj());

            //string BielskoToday= "https://pogoda.interia.pl/prognoza-dlugoterminowa-bielsko-biala,cId,1359";
            //string WarszawaToday = "";
            //using (var scraper = new ItemScraper(BielskoToday))
            //{
            //    var items = scraper.Execute();

            //   // jak hakowanie prawei

            ////czegop szukasz ?
            //// mysle gdzie to dac


           
            //}
        }
    }
}
