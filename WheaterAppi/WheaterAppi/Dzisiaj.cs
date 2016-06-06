using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WheaterAppi.Model;

namespace WheaterAppi
{
    public partial class Dzisiaj : Form
    {
        public Dzisiaj()
        {
            InitializeComponent();
            GetWheather.LoadWhether();

            using (var db = new ContextWheather())
            {
                //db.Citys.Add(new City { ID = 1, NameCity = "Warszawa" });
                //db.Citys.Add(new City { ID = 13, NameCity = "Poznań" });
                //db.Citys.Add(new City { ID = 14, NameCity = "Bielsko-Biała" });

                //string city1name="";

                //for (int i = 1; i <= 3; i++)
                //{
                //    //    var deleteing = db.Citys.First(c => c.ID == i);
                //    //    db.Citys.Remove(deleteing);

                    
                //    comboBox1.Text = city1name;
                //}
                //city1name = db.Citys.Where(n => n.ID == 16).First().NameCity;
              //  comboBox1.Text = city1name;
                //db.SaveChanges();

                










                button1.TabStop = false;
                button1.FlatStyle = FlatStyle.Flat;
                button1.FlatAppearance.BorderSize = 0;
                button1.BackColor = Color.FromArgb(50, 124, 203);

                
                
                
                
                //var ac = from c in db.Citys select c.NameCity;

                //var actolist = ac.ToList();
                //List<string> ListofCity = new List<string>();

                //foreach (var result in actolist)
                //{
                //    ListofCity.Add(result.ToString());

                //var q = (from n in db.Citys.Include(n => n.NameCity)
                //         select n).ToList();



                //AppDomain.CurrentDomain.SetData("DataDirectory", AppDomain.CurrentDomain.BaseDirectory);


                //db.Citys.Add(new City { IDCity = 1, NameCity = "Warszawa" });
                //db.Citys.Add(new City { IDCity = 2, NameCity = "Bielsko-Biała" });
                //db.Citys.Add(new City { IDCity = 3, NameCity = "Poznań" });
                //  Dzisiaj dzisiaj = new Dzisiaj();
                //var q = (from n in db.Citys
                //         select n).ToList();
                //button2.TabStop = false;
                //button2.FlatStyle = FlatStyle.Flat;
                //button2.FlatAppearance.BorderSize = 0;
                //button2.BackColor = Color.FromArgb(50, 124, 203);

                //button3.TabStop = false;
                //button3.FlatStyle = FlatStyle.Flat;
                //button3.FlatAppearance.BorderSize = 0;
                //button3.BackColor = Color.FromArgb(50, 124, 203);

                //  Form1.DefaultBackColor = Color.FromArgb(50, 124, 203);
                PanelLeft.BackColor = Color.FromArgb(50, 124, 203);
                PanelTommorow.BackColor = Color.FromArgb(27, 71, 120);
                MainPanel.BackColor = Color.FromArgb(3, 109, 163);
                LabelTime.Text = DateTime.Now.ToShortTimeString().ToString();
                FormBorderStyle = FormBorderStyle.None;
                pictureBox4.Visible = false;
                SugerowanaAktywnosc.BackColor = Color.FromArgb(3, 109, 163);
                SugerowanaAktywnosc.BorderStyle = BorderStyle.None;
                SugerowanaAktywnosc.ForeColor = Color.White;
                LabSugerAktyw.ForeColor = Color.White;
                LabSugerAktyw.Font = new Font(this.Font, FontStyle.Bold); 

                //comboBox1.Items.Add("Poznań");
                //comboBox1.Items.Add("Żywiec");
                //comboBox1.Items.Add("Gdańsk");
                //db.SaveChanges();

                //HtmlNode[] AnodesTemperature = Document.DocumentNode.SelectNodes("//a[@class='title']").ToArray();
                //HtmlNode[] nodesDescription = Document.DocumentNode.SelectNodes("//div[@class='emission-time']").ToArray();
                //HtmlNode[] nodesSunRise = Document.DocumentNode.SelectNodes("//span[@class='cat-container']").ToArray();
                //HtmlNode[] nodesSunset = Document.DocumentNode.SelectNodes("//span[@class='part']").ToArray();
                // TopLevel = false;
            }
            

        }
        private void Form1_Load()
        {
            
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // comboBox1.Text += "Warszawa";
            string BielskoToday = "https://pogoda.interia.pl/prognoza-dlugoterminowa-bielsko-biala,cId,1359";
            string WarszawaToday = "https://pogoda.interia.pl/prognoza-dlugoterminowa-warszawa,cId,36917";
            string PoznanToday = "";
            string Miasto = comboBox1.Text;

            if (comboBox1.Text == "Warszawa")
            {
                Miasto = WarszawaToday;
            }
            else { Miasto = BielskoToday; }

            using (var scraper = new ItemScraper(Miasto))
            { 
                var item = scraper.Execute();
                pictureBox4.Visible = true;
                LabMoonSet.Text = item.MoonSet;
                LabMoonRise.Text = item.MoonRise;
                LabSunRise.Text = item.SunRise;
                LabSunSet.Text = item.SunSet;
                LabWindValue.Text = item.Wind;
                LabDEsc.Text = item.Description;
               //  LabPressureValue.Text = item.Presure+" hPa";
                LabTemp.Text = item.Temperature;
                TempActual.Text = item.TempActual;
                LabCityName.Text = item.CityName;

                if (item.Description == "Zachmurzenie duże" || item.Description == "Przejściowe zachmurzenie" || item.Description == "Przejściowe małe" || item.Description == "Zachmurzenie umiarkowane")
                {
                    PictureDesc.BackgroundImage = Image.FromFile(@"C:\Users\Bartek\documents\visual studio 2015\Projects\WheaterAppi\WheaterAppi\Resources\Cloudy.png");
                    var odnoscnikAktywnosci = Convert.ToDouble(item.Temperature);
                    SugerowanaAktywnosc.Items.Add("");
                    //if ()//comboBox1.Items.Add("Zrob dzien przed Tv");
                }
                else if (item.Description == "Częściowo słonecznie" || item.Description == "Przeważnie słonecznie")
                {
                    PictureDesc.BackgroundImage = Image.FromFile(@"C:\Users\Bartek\documents\visual studio 2015\Projects\WheaterAppi\WheaterAppi\Resources\CloudSunny.png");
                }
                else if (item.Description == "Słonecznie"|| item.Description == "Bezchmurnie")
                {
                    PictureDesc.BackgroundImage = Image.FromFile(@"C:\Users\Bartek\documents\visual studio 2015\Projects\WheaterAppi\WheaterAppi\Resources\Sunny.png");
                    //comboBox1.Items.Add("Zrob dzien przed Tv");
                    //var odnoscnikAktywnosci = Convert.ToDouble(item.Temperature);
                    SugerowanaAktywnosc.Items.Add("- przejażdżka na rowerze");
                    SugerowanaAktywnosc.Items.Add("- opalanie się");
                    SugerowanaAktywnosc.Items.Add("- gra w siatkówke");
                    SugerowanaAktywnosc.Items.Add("- basen");
                    SugerowanaAktywnosc.Items.Add("- zapal grilla");
                }
                else { PictureDesc.BackgroundImage = Image.FromFile(@"C:\Users\Bartek\documents\visual studio 2015\Projects\WheaterAppi\WheaterAppi\Resources\Budza.png"); }



                //LabelTime.Text = GetWheather.BielskoToday.Temperature;

                //LabelTime.Text = item.Temperature;
                // chyba jest no i tam musisz reszte zrobic, teraz ci zwraca jeden obiekt 
                // dobra a teraz zeby mi np kolejna rzecz zwracało to robie tak samo jak z temeratura ?
                //tak, mistrzu dzieki
                // jak hakowanie prawei
                // mozesz tez tak sobie robic,superrrrr
                //DZIEKUJE prosze :P
                //czegop szukasz ?
                // mysle gdzie to dac
                //zaczekaj chwile
                //aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa dziala :D nawet spoko wyglada, no wyglad tez musi byc 

            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
           
        }
    }
}
