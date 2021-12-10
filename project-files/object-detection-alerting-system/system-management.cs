using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

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

                warning_message_box.Enabled = false;

            }
            else {

                warning_message_box.Enabled = true;

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

        public string target_objects_cleanup(string textData) {

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

            return targetObjectText = targetObjectText.TrimStart(',');

        }
        
      
        

        private void button2_Click(object sender, EventArgs e)
        {

            if (system_name_box.Text != "" && model_list_combo.Text != "" && target_objects.Text != "" && alarm_status_combo.Text != "")
            {
                string warningMessage = "";

                if (alarm_status_combo.Text == "Off")
                {

                    warningMessage = "[SKIPPED]";

                }
                else {

                    warningMessage = warning_message_box.Text;
                }


                SQLiteConnection SqlConnection = new SQLiteConnection("Data Source=system-files/database.db");
                SqlConnection.Open();

                SQLiteCommand cmd = new SQLiteCommand("INSERT INTO created_systems ('system_name','model_name','target_objects','alarm_status','warning_message','min_threshold') VALUES(@system_name, @model_name, @target_objects, @alarm_status, @warning_message, @min_threshold)", SqlConnection);
                cmd.Parameters.AddWithValue("@system_name", system_name_box.Text);
                cmd.Parameters.AddWithValue("@model_name", model_list_combo.Text);
                cmd.Parameters.AddWithValue("@target_objects", target_objects.Text);
                cmd.Parameters.AddWithValue("@alarm_status", alarm_status_combo.Text);
                cmd.Parameters.AddWithValue("@warning_message", warningMessage);
                cmd.Parameters.AddWithValue("@min_threshold", min_tracker.Value.ToString());
                cmd.ExecuteNonQuery();


            }
            else {

                MessageBox.Show("Please fill out all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
          
        }
    }
}
