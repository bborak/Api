using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WheaterAppi
{
    public partial class Tommorow : Form
    {
        public Tommorow()
        {
            InitializeComponent();

            button1.TabStop = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.BackColor = Color.FromArgb(50, 124, 203);

            button4.TabStop = false;
            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 0;
            button4.BackColor = Color.FromArgb(50, 124, 203);

            button6.TabStop = false;
            button6.FlatStyle = FlatStyle.Flat;
            button6.FlatAppearance.BorderSize = 0;
            button6.BackColor = Color.FromArgb(50, 124, 203);

            //  Form1.DefaultBackColor = Color.FromArgb(50, 124, 203);
            panel3.BackColor = Color.FromArgb(50, 124, 203);
            
        }
    }
}
