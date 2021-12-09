using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace object_detection_alerting_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int progressBarValue = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            progressBarValue++;
            progressBar1.Value = progressBarValue;

            if(progressBarValue == 100)
            {
                timer1.Stop();
                this.Hide();
                sub_dashboard sub_Dashboard = new sub_dashboard();
                sub_Dashboard.Show();
            }
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
