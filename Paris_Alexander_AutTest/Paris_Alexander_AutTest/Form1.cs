using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Paris_Alexander_AutTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string Tankstand;
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
           
        }

        private void btn_autoerstellen_Click(object sender, EventArgs e)
        {
            if (txtb_marke.Text != "" && comb_farbe.Text != "" && txtb_ps.Text != "" && txtb_tankgröße.Text != "" && txtb_verbrauch.Text != "")
            {
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
                groupBox4.Enabled = true;
                rtxtb_info.Text += "Marke:" + txtb_marke.Text;
                rtxtb_info.Text += "    Farbe:" + comb_farbe.Text;
            }
        }

        private void btn_tanken_Click(object sender, EventArgs e)
        {
             Tankstand += txtb_tanken.Text;
             rtxtb_info.Text += "   Tankstand:" + Tankstand+ "l";
        }
    }
}
