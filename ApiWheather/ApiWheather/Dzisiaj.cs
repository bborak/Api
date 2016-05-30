using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApiWheather
{
    public partial class Dzisiaj : Form
    {
        private double deszcz = 89;
        public Dzisiaj()
        {
            InitializeComponent();
            TempRano.Text = "Temperatura";
            DeszczRano.Text = Convert.ToString(deszcz)+" mm ";
            ZachmRano.Text = "Zachmurzenie";
            WilgotRano.Text = "Wilgotnosc";

            TempPol.Text = "Temperatura";
            DeszczPol.Text = Convert.ToString(deszcz) + " mm ";
            ZachmPol.Text = "Zachmurzenie";
            WilgotPol.Text = "Wilgotnosc";

            TempWiecz.Text = "Temperatura";
            DeszczWiecz.Text = Convert.ToString(deszcz) + " mm ";
            ZachmWiecz.Text = "Zachmurzenie";
            WilgotWiecz.Text = "Wilgotnosc";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TempRano.ReadOnly = true;
            
        }

        private void DeszczRano_TextChanged(object sender, EventArgs e)
        {
            DeszczRano.ReadOnly = true;
        }

        private void ZachmRano_TextChanged(object sender, EventArgs e)
        {
            ZachmRano.ReadOnly = true;
        }

        private void WilgotRano_TextChanged(object sender, EventArgs e)
        {
            WilgotRano.ReadOnly = true;
        }

        private void MenuDzis_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

    }
}
