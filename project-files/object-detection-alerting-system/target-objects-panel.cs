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
    public partial class target_objects_panel : Form
    {
        public target_objects_panel()
        {
            InitializeComponent();
        }

        public string selected_objects = "";

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            target_objects.Text = "";

            foreach (var item in listBox1.SelectedItems) {

                target_objects.Text += "," + item.ToString();
            }

            target_objects.Text = target_objects.Text.TrimStart(',');
            selected_objects = target_objects.Text; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            target_objects.Text = "";

            foreach (var item in listBox1.Items)
            {

                target_objects.Text += "," + item.ToString();
            }

            target_objects.Text = target_objects.Text.TrimStart(',');
            selected_objects = target_objects.Text;

        }
    }
}
