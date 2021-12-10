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
    public partial class system_management : Form
    {
        public system_management()
        {
            InitializeComponent();
        }

        public void getModels()
        {

            string[] folders = System.IO.Directory.GetDirectories(@"data/models/", "*", System.IO.SearchOption.TopDirectoryOnly);


            for (int i = 0; i < folders.Length; i++)
            {

                string[] modelNameParts = folders[i].Split('/');

                string modelName = modelNameParts[modelNameParts.Length - 1];

                model_list_combo.Items.Add(modelName);

            }

        }

        private void system_management_FormClosed(object sender, FormClosedEventArgs e)
        {
            sub_dashboard sub_Dashboard = new sub_dashboard();
            sub_Dashboard.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void system_management_Load(object sender, EventArgs e)
        {
            getModels();
            alarm_status_combo.SelectedIndex = 0;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void opacity_trackbar_Scroll(object sender, EventArgs e)
        {
            textBox3.Text = min_tracker.Value.ToString();
        }

        private void alarm_status_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (alarm_status_combo.Text == "Off")
            {

                richTextBox1.Enabled = false;

            }
            else {

                richTextBox1.Enabled = true;

            }
            
        }

        private void target_objects_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void target_objects_Click(object sender, EventArgs e)
        {
            target_objects_panel TargetObject = new target_objects_panel();
            TargetObject.ShowDialog();
            target_objects.Text = TargetObject.selected_objects;
            
        }

        public void target_objects_cleanup(string textData) {

            string targetObjectText = "";

            string[] textSplited = textData.Split(',');

            foreach (string txt in textSplited) {

                if (txt.Contains(" "))
                {

                    targetObjectText += "," +txt.Replace(" ","_");

                }
                else {

                    targetObjectText += "," + txt;

                }

            }

            MessageBox.Show(targetObjectText.TrimStart(','));

        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            target_objects_cleanup(target_objects.Text);
        }
    }
}
