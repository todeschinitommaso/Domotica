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

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            int vol = Convert.ToInt32(numericUpDown2.Value);
            if (power.Text == "OFF")
                t.setVolume(vol);

            else
                MessageBox.Show("TV spenta");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int chn = Convert.ToInt32(numericUpDown1.Value);
            if (power.Text == "OFF")
                t.setVolume(chn);

            else
                MessageBox.Show("TV spenta");
        }

        private void infrarossi_CheckedChanged(object sender, EventArgs e)
        {
            t.setSegnale(t.infrarossi, t.bluetooth, t.WiFi);
        }

        private void bluetooth_CheckedChanged(object sender, EventArgs e)
        {
            t.setSegnale(t.bluetooth, t.infrarossi, t.WiFi);
        }

        private void wifi_CheckedChanged(object sender, EventArgs e)
        {
            t.setSegnale(t.WiFi, t.infrarossi, t.bluetooth);
            
        }
    }
}
