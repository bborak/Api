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
    public partial class AddDeleteACtiv : Form
    {

        public static List<Activity> Activities { get; set; }

        public AddDeleteACtiv()
        {
            InitializeComponent();
            using (var db = new ContextWheather())
            {

                panelAddDelete.BackColor = Color.FromArgb(43, 145, 184);
                FormBorderStyle = FormBorderStyle.None;
                //TextboxNameActiv.Visible = false;
                //comboBox1.Visible = false;
                //panel2.Visible = false;
                comboBox1.Items.Add("Słoneczna");
                comboBox1.Items.Add("Pochmurna");
                comboBox1.Items.Add("Burzowa");
                comboBox1.Text="Wybierz";

                //
//                comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
                }
            
        }

        private void pictureboxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAddActivity_Click(object sender, EventArgs e)
        {
            //TextboxNameActiv.Visible = true;
            //comboBox1.Visible = true;
            //panel2.Visible = true;

        }

        private void ButtonSaveActiv_Click(object sender, EventArgs e)
        {
            using (var db = new ContextWheather())
            {

                if (TextboxNameActiv.Text != "Wpisz" && comboBox1.Text != "Wybierz")
                {
                    var IDnew = db.Activities.Max(n => n.ID);
                    if (comboBox1.Text == "Słoneczna")
                    {
                        db.Activities.Add(
                            new Activity
                            { ID = (IDnew + 1), NameOfActivity = TextboxNameActiv.Text, DescriptionOfActivity = "Sunny" });
                    }
                    else if (comboBox1.Text == "Pochmurna")
                    {
                        db.Activities.Add(
                            new Activity
                            { ID = (IDnew + 1), NameOfActivity = TextboxNameActiv.Text, DescriptionOfActivity = "Cloudy" });
                    }
                    else
                    {
                        db.Activities.Add(
                         new Activity
                         { ID = (IDnew + 1), NameOfActivity = TextboxNameActiv.Text, DescriptionOfActivity = "Storm" });
                    }
                    MessageBox.Show("Zapisano pomślnie");
                    // db.SaveChanges();  
                }

                else { MessageBox.Show("Nie zapisano pomślnie!"+Environment.NewLine+"Description( Nie wpisałeś nazwy lub nie wybrałeś rodzaju pogody)"); }

            }
        }

        private void ButtDelete_Click(object sender, EventArgs e)
        {
            using (var db = new ContextWheather())
            {
                var dousuniecia = listBox1.SelectedItem.ToString();
           //     var usunzbazy = db.Activities.Single(n => n.NameOfActivity == dousuniecia).ID;

                var deletete = db.Activities.FirstOrDefault(w => w.NameOfActivity == dousuniecia);
                db.Activities.Remove(deletete);
                listBox1.Items.Clear();
               // db.SaveChanges();
                MessageBox.Show("Usunieto pomyślnie!");
            }
        }

        private void Butwczytaj_Click(object sender, EventArgs e)
        {
            using (var db = new ContextWheather())
            {
   
                var dane = from p in db.Activities orderby p.ID select p;
                foreach (var mindane in dane)
                {
                    listBox1.Items.Add(mindane.NameOfActivity);
                }

            }
        }
    }
}

