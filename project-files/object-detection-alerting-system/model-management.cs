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
    public partial class model_management : Form
    {
        public model_management()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (model_url_textbox.Text != "")
            {

               
            }
            else {

                MessageBox.Show("Please enter a url", "Wanring",MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string targetURL = @"https://github.com/tensorflow/models/blob/master/research/object_detection/g3doc/tf2_detection_zoo.md";
            System.Diagnostics.Process.Start(targetURL);

        }
    }
}
