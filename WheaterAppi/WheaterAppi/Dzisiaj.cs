﻿using HtmlAgilityPack;
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

                //var CityPoznan = db.Citys.First(n => n.NameCity == "Poznan").NameCity;
                //var CityWarsaw = db.Citys.First(n => n.NameCity == "Warszawa").NameCity;
                //var CityBielsko = db.Citys.First(n => n.NameCity == "Bielsko-Biała").NameCity;

                comboBox1.Items.Add("Poznań");
                comboBox1.Items.Add("Warszawa");
                comboBox1.Items.Add("Bielsko");
                //var itemAcc = db.Activities.Single(n => n.ID == 9).NameOfActivity;
                //comboBox1.Text = itemAcc;
                //db.SaveChanges();
                //    comboBox1.Text = city1name;
                //}
                //city1name = db.Citys.Where(n => n.ID == 16).First().NameCity;
                //  comboBox1.Text = city1name;
                //db.SaveChanges();
                //var datetime = DateTime.Now;
                //var date = datetime.Date;
                //LabData.Text = Convert.ToString(date);
                button1.TabStop = false;
                button1.FlatStyle = FlatStyle.Flat;
                button1.FlatAppearance.BorderSize = 0;
                button1.BackColor = Color.FromArgb(50, 124, 203);
                button1.TabStop = false;
                button2.FlatStyle = FlatStyle.Flat;
                button2.FlatAppearance.BorderSize = 0;
                button2.BackColor = Color.FromArgb(50, 124, 203);
                comboBox1.Text = "Wybierz miasto";       
                PanelLeft.BackColor = Color.FromArgb(50, 124, 203);
                //PanelTommorow.BackColor = Color.FromArgb(27, 71, 120);
               // MainPanel.BackColor = Color.FromArgb(3, 109, 163); stary kolor

                MainPanel.BackColor = Color.FromArgb(0, 51, 102);
                FormBorderStyle = FormBorderStyle.None;
                MoonBox.Visible = false;


                pictureBox6.Visible = false;
                pictureBox3.Visible = false;
                pictureBox5.Visible = false;
                pictureMoonArrow.Visible = false;
                pictureBox4.Visible = false;
                //zmien na false !!!!!!!!!!!!

                //LabCityName.Visible = false;
                //LabDEsc.Visible = false;
                //LabTemp.Visible = false;
                //Odczuwalna.Visible = false;
                //LabWiatr.Visible = false;
                //LabWindValue.Visible = false;
                //TempActual.Visible = false;
                //LabSunSet.Visible = false;
                //LabSunRise.Visible = false;
                //LabMoonRise.Visible = false;
                //LabMoonSet.Visible = false;
                //label3.Visible = false;
                //LabelTime.Visible = false;
                //LabSugerAktyw.Visible = false;

                //--------------FALSE----------------------
                //    SugerowanaAktywnosc.BackColor = Color.FromArgb(3, 109, 163);

                SugerowanaAktywnosc.BackColor = Color.FromArgb(0, 51, 102);
                SugerowanaAktywnosc.BorderStyle = BorderStyle.None;
                SugerowanaAktywnosc.ForeColor = Color.White;
                LabSugerAktyw.ForeColor = Color.White;
                LabSugerAktyw.Font = new Font(this.Font, FontStyle.Bold);

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
            if (comboBox1.Text != "Wybierz") { 
            using (var db = new ContextWheather()) {
                // comboBox1.Text += "Warszawa";
                string BielskoToday = "https://pogoda.interia.pl/prognoza-dlugoterminowa-bielsko-biala,cId,1359";
                string WarszawaToday = "https://pogoda.interia.pl/prognoza-dlugoterminowa-warszawa,cId,36917";
                string PoznanToday = "https://pogoda.interia.pl/prognoza-szczegolowa-poznan,cId,27457";
                string Miasto = comboBox1.Text;

                LabelTime.Text = DateTime.Now.ToShortTimeString().ToString();


                if (comboBox1.Text == "Warszawa"){Miasto = WarszawaToday;}
                else if (comboBox1.Text == "Poznań") { Miasto = PoznanToday; }
                else  { Miasto = BielskoToday; }

                    using (var scraper = new ItemScraper(Miasto))
                    {

                        var item = scraper.Execute();
                        pictureBox4.Visible = true;
                        MoonBox.Visible = true;
                        pictureBox3.Visible = true;
                        pictureBox5.Visible = true;
                        pictureBox6.Visible = true;
                        pictureMoonArrow.Visible = true;

                        LabCityName.Visible = true;
                        LabDEsc.Visible = true;
                        LabTemp.Visible = true;
                        Odczuwalna.Visible = true;
                        LabWiatr.Visible = true;
                        LabWindValue.Visible = true;
                        TempActual.Visible = true;
                        LabMoonSet.Visible = true;
                        LabMoonRise.Visible = true;
                        LabSunRise.Visible = true;
                        LabSunSet.Visible = true;
                        label3.Visible = true;
                        LabelTime.Visible = true;
                        LabSugerAktyw.Visible = true;

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
                            foreach (var itemki in db.Activities.Where(n => n.DescriptionOfActivity == "Cloudy").ToList())
                            {
                                SugerowanaAktywnosc.Items.Add("- " + itemki.NameOfActivity);
                            }

                            PictureDesc.BackgroundImage = Image.FromFile(@"C:\Users\Bartek\Documents\GitHub\Api\WheaterAppi\WheaterAppi\Resources\Cloudy.png");
                            var odnoscnikAktywnosci = Convert.ToDouble(item.Temperature);
                            SugerowanaAktywnosc.Items.Add("");
                            //if ()//comboBox1.Items.Add("Zrob dzien przed Tv");
                        }
                        else if (item.Description == "Częściowo słonecznie" || item.Description == "Przeważnie słonecznie")
                        {
                            foreach (var itemki in db.Activities.Where(n => n.DescriptionOfActivity == "Sunny" || n.DescriptionOfActivity == "Cloudy").ToList())
                            {
                                SugerowanaAktywnosc.Items.Add("- " + itemki.NameOfActivity);
                            }

                            PictureDesc.BackgroundImage = Image.FromFile(@"C:\Users\Bartek\Documents\GitHub\Api\WheaterAppi\WheaterAppi\Resources\CloudSunny.png");
                        }
                        else if (item.Description == "Słonecznie" || item.Description == "Bezchmurnie")
                        {
                            foreach (var itemki in db.Activities.Where(n => n.DescriptionOfActivity == "Sunny").ToList())
                            {
                                SugerowanaAktywnosc.Items.Add("- " + itemki.NameOfActivity);
                            }

                            PictureDesc.BackgroundImage = Image.FromFile(@"C:\Users\Bartek\Documents\GitHub\Api\WheaterAppi\WheaterAppi\Resources\Sunny.png");
                            //comboBox1.Items.Add("Zrob dzien przed Tv");
                            //var odnoscnikAktywnosci = Convert.ToDouble(ite
                        }
                        else
                        {
                            foreach (var itemki in db.Activities.Where(n => n.DescriptionOfActivity == "Storm" || n.DescriptionOfActivity == "Cloudy").ToList())
                            {
                                SugerowanaAktywnosc.Items.Add("- " + itemki.NameOfActivity);
                            }

                            PictureDesc.BackgroundImage = Image.FromFile(@"C:\Users\Bartek\Documents\GitHub\Api\WheaterAppi\WheaterAppi\Resources\Budza.png");
                        }



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


                        //comboBox1.Items.Add("Poznań");
                        //comboBox1.Items.Add("Żywiec");
                        //comboBox1.Items.Add("Gdańsk");
                        //db.SaveChanges();

                        //HtmlNode[] AnodesTemperature = Document.DocumentNode.SelectNodes("//a[@class='title']").ToArray();
                        //HtmlNode[] nodesDescription = Document.DocumentNode.SelectNodes("//div[@class='emission-time']").ToArray();
                        //HtmlNode[] nodesSunRise = Document.DocumentNode.SelectNodes("//span[@class='cat-container']").ToArray();
                        //HtmlNode[] nodesSunset = Document.DocumentNode.SelectNodes("//span[@class='part']").ToArray();
                        // TopLevel = false;
                        //db.Citys.Add(new City { ID = 1, NameCity = "Warszawa" });
                        //db.Citys.Add(new City { ID = 13, NameCity = "Poznań" });
                        //db.Citys.Add(new City { ID = 14, NameCity = "Bielsko-Biała" });

                        //string city1name="";

                        //for (int i = 1; i <= 3; i++)
                        //{
                        //    //    var deleteing = db.Citys.First(c => c.ID == i);
                        //    //    db.Citys.Remove(deleteing);

                        // db.Activities.Add(new Activity { ID = 1, NameOfActivity = "Programing time", DescriptionOfActivity = "Sunny" });
                        //db.Activities.Add(new Activity { ID = 2, NameOfActivity = "Smażing", DescriptionOfActivity = "Sunny" });
                        //db.Activities.Add(new Activity { ID = 3, NameOfActivity = "Plażing", DescriptionOfActivity = "Sunny" });
                        //db.Activities.Add(new Activity { ID = 4, NameOfActivity = "Basening", DescriptionOfActivity = "Sunny" });
                        //db.Activities.Add(new Activity { ID = 5, NameOfActivity = "Grillowanie", DescriptionOfActivity = "Sunny" });
                        //db.Activities.Add(new Activity { ID = 7, NameOfActivity = "Programing Time", DescriptionOfActivity = "Sunny" });
                        //db.Activities.Add(new Activity { ID = 8, NameOfActivity = "Bieganie", DescriptionOfActivity = "Cloudy" });
                        //db.Activities.Add(new Activity { ID = 9, NameOfActivity = "Siłownia", DescriptionOfActivity = "Cloudy" });
                        //db.Activities.Add(new Activity { ID = 10, NameOfActivity = "Spacer", DescriptionOfActivity = "Cloudy" });
                        //db.Activities.Add(new Activity { ID = 11, NameOfActivity = "Programing Time", DescriptionOfActivity = "Cloudy" });
                        //db.Activities.Add(new Activity { ID = 12, NameOfActivity = "Posłuchaj muzyki", DescriptionOfActivity = "Cloudy" });
                        //db.Activities.Add(new Activity { ID = 13, NameOfActivity = "Oglądnij film w Tv", DescriptionOfActivity = "Cloudy" });
                        //db.Activities.Add(new Activity { ID = 14, NameOfActivity = "Wyjdz ze znajomymi do kina ", DescriptionOfActivity = "Cloudy" });
                        //db.Activities.Add(new Activity { ID = 15, NameOfActivity = "Poczytaj książke ", DescriptionOfActivity = "Storm" });
                        //db.Activities.Add(new Activity { ID = 16, NameOfActivity = "Krótka drzemka ? ", DescriptionOfActivity = "Storm" });
                        //db.Activities.Add(new Activity { ID = 17, NameOfActivity = "Programing Time", DescriptionOfActivity = "Storm" });




                    }

                }
            }
            MessageBox.Show("Nie wybrałeś miasta !"+Environment.NewLine+
                "Domyślnie wczytano miasto Bielsko-Biała");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AddDeleteACtiv dodajUsun = new AddDeleteACtiv();
            dodajUsun.ShowDialog();
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
