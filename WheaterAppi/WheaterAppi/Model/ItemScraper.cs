using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WheaterAppi.Model
{
    public class ItemScraper : WebScraperBase<TodayItems>
    {
        public ItemScraper(string pageUrl) : base(pageUrl)
        {

        }
        public string encode(string myString)
        {
            byte[] bytes = Encoding.Default.GetBytes(myString);
            myString = Encoding.UTF8.GetString(bytes);
            return myString;
        }

        public override TodayItems Execute()
        {
            //to tu jest stare enkodowanie, i to moze nie dzialac


            //HtmlNode[] nodeTime = Document.DocumentNode.SelectNodes("//span[@class ='weather-currently-info-item-time']").ToArray();
            //var NodeTime = encode(nodeTime[0].InnerText).Trim();

            //   HtmlNode[] nodesDescription = Document.DocumentNode.SelectNodes("//div[@class='emission-time']").ToArray();
            //HtmlNode[] nodesSunRise = Document.DocumentNode.SelectNodes("//span[@class='cat-container']").ToArray();

            
            HtmlNode[] nodesTemperature = Document.DocumentNode.SelectNodes("//div[@class='weather-currently-temp-strict']").ToArray();
            HtmlNode[] nodesDescription = Document.DocumentNode.SelectNodes("//div[@class='weather-currently-icon-description']").ToArray();
            HtmlNode[] nodesSunRise = Document.DocumentNode.SelectNodes("//span[@class='weather-currently-info-sunrise']").ToArray();
            HtmlNode[] nodesSunSet = Document.DocumentNode.SelectNodes("//span[@class='weather-currently-info-sunset']").ToArray();
            HtmlNode[] nodesMoonRise = Document.DocumentNode.SelectNodes("//span[@class='weather-currently-info-moonrise']").ToArray();
            HtmlNode[] nodesMoonSet = Document.DocumentNode.SelectNodes("//span[@class='weather-currently-info-moonset']").ToArray();           
            HtmlNode[] nodesWind = Document.DocumentNode.SelectNodes("//span[@class='weather-currently-details-value']").ToArray();
            HtmlNode[] nodesTempActual = Document.DocumentNode.SelectNodes("//span[@class='weather-currently-temp-actual-value']").ToArray();
            HtmlNode[] nodeMInitemp = Document.DocumentNode.SelectNodes("//span[@class='weather-currently-middle-forecast-temperature-max']").ToArray();
            HtmlNode[] nodescityName= Document.DocumentNode.SelectNodes("//h3[@class='weather-currently-city']").ToArray();
           // HtmlNode[] nowysiwtlsiewkoncu = Document.DocumentNode.SelectNodes("//span[@class='weather-forecast-longterm-list-entry-pressure-value']").ToArray();

            var temerature = encode((nodesTemperature[0].InnerText).Trim());
            var description= encode((nodesDescription[0].InnerText).Trim());
            var sunRise= encode((nodesSunRise[0].InnerText).Trim());
            var sunSet = encode((nodesSunSet[0].InnerText).Trim());
            var moonRise= encode((nodesMoonRise[0].InnerText).Trim());
            var moonSet= encode((nodesMoonSet[0].InnerText).Trim());
            var cityname = encode((nodescityName[0].InnerText).Trim());
            var wind =encode((nodesWind[0].InnerText).Trim());
            var actual = encode((nodesTempActual[0].InnerText).Trim());


            //    TodayItems item = new TodayItems();
            //    item.ID = GetWheather.IDWheather;
            //    item.Temperature = dzisiajTemp;
            //  //  item.Description = dzisiajDesc;
            // tak jak tu miales , dobra działam dalej jak coś to bede Cie jeszcze meczył :D
            //czekaj            //}

            TodayItems item = new TodayItems();
            item.Temperature = temerature;
            item.Description = description;
            item.SunRise = sunRise;
            item.SunSet = sunSet;
            item.MoonRise = moonRise;
            item.MoonSet = moonSet;
            item.CityName = cityname;
            //item.Datee = date;
            item.TempActual = actual;
            item.Wind = wind;
            //  item.Description = descrip;
            //    item.Presure = pressure;
            return item;


            //        }

        }
    }
}
