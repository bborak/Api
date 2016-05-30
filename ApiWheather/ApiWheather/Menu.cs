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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Dzisiaj_Click(object sender, EventArgs e)
        {
            Dzisiaj dzisiaj = new Dzisiaj();
            dzisiaj.ShowDialog();
            

        }

        private void Wyjdz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
