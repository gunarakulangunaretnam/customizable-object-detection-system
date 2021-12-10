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
    public partial class sub_dashboard : Form
    {
        public sub_dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            model_management model_Management = new model_management(); 
            model_Management.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            system_management model_Management = new system_management();
            model_Management.Show();
            this.Hide();
            
        }

        private void sub_dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
