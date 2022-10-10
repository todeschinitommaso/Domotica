using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telecomando
{
    public partial class Form1 : Form
    {
        private Telecomando t;
        public Form1()
        {
            InitializeComponent();
            t = new Telecomando();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void power_Click(object sender, EventArgs e)
        {
            if(power.Text == "ON")
            {
                power.Text = "OFF";
                power.ForeColor = Color.Green;
                t.accendi();
            }

            else
            {
                power.Text = "ON";
                power.ForeColor = Color.Red;
                t.spegni();
            }
        }
    }
}
