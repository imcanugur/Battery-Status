using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.WindowsAPICodePack.Net;
using Microsoft.WindowsAPICodePack.ApplicationServices;
using Microsoft.WindowsAPICodePack.Shell;


namespace batterystatus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Top = Screen.PrimaryScreen.Bounds.Height - this.Height - 50;
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width + 45;
            timer1.Start();
        }

        private void flatProgressBar1_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
            }
            else if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            flatProgressBar1.Value = PowerManager.BatteryLifePercent;
            if (PowerManager.PowerSource.ToString() == "Battery")
            {
                label1.Text = "Batarya";
            }
            if (PowerManager.PowerSource.ToString() == "AC")
            {
                label1.Text = "Şarj";
            }
            BatteryState batteryState = PowerManager.GetCurrentBatteryState();
            label3.Text = batteryState.MaxCharge + " mWh";
            label4.Text = batteryState.CurrentCharge + " mWh";
            flatProgressBar1.Value = PowerManager.BatteryLifePercent;
            label2.Text = PowerManager.BatteryLifePercent.ToString() + "%";
            label5.Text = PowerManager.PowerSource.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uğur CAN", "Uğur CAN", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
            }
            else if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
        }
    }
}
