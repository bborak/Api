using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheaterAppi.Model
{
    public static class GetWheather
    {
        public static TodayItems BielskoToday;
        public static TodayItems WarszawaToday;
        public static string _BielskoTodayTommorow = "https://pogoda.interia.pl/prognoza-dlugoterminowa-bielsko-biala,cId,1359"; // today
        public static string _WarszawaTodayTommorow = "https://pogoda.interia.pl/prognoza-szczegolowa-warszawa,cId,36917";//today


        //private static string _polsatFilmToday = "http://teletydzien.interia.pl/program-tv/stacja-polsat-film,page,pl-type,cid,20908510";
        //private static string _polsatFilmTomorrow = "http://teletydzien.interia.pl/program-tv/stacja-polsat-film,cid,20908510,o,1";
        //private static string _polsatFilmNext2Days = "http://teletydzien.interia.pl/program-tv/stacja-polsat-film,cid,20908510,o,2";

        public static int IDWheather = 1;
        public static void LoadWhether()
        {
            BielskoToday = new ItemScraper(_BielskoTodayTommorow).Execute();
            WarszawaToday = new ItemScraper(_WarszawaTodayTommorow).Execute();
        }   
    }
   
}
