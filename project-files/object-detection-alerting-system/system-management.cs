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


        int selectedIndex;

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
            SelectData();
            getModels();
            alarm_status_combo.SelectedIndex = 0;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void opacity_trackbar_Scroll(object sender, EventArgs e)
        {
            min_threshold_text.Text = min_tracker.Value.ToString();
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

                    targetObjectText += "," + txt.Replace(" ", "_");

                }
                else {

                    targetObjectText += "," + txt;

                }

            }

            return targetObjectText = targetObjectText.TrimStart(',');

        }

        public void ClearForms() {

            system_name_box.Clear();
            model_list_combo.Text = "";
            target_objects.Clear();
            alarm_status_combo.Text = "";
            warning_message_box.Clear();
            min_threshold_text.Text = "50";
            min_tracker.Value = 50;

        }


        public void DeleteSystem(int index) {

            string systemName =  dataGridView1.Rows[index].Cells[1].Value.ToString();

            SQLiteConnection SqlConnection = new SQLiteConnection("Data Source=system-files/database.db");
            SqlConnection.Open();

            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM created_systems WHERE system_name = '"+ systemName + "'", SqlConnection);
            cmd.ExecuteNonQuery();

            SqlConnection.Close();

            SelectData();

        }

        public void SelectData()
        {
            DataTable dataGridViewTable = new DataTable();
            dataGridViewTable.Columns.Add("No");
            dataGridViewTable.Columns.Add("System Name");
            dataGridViewTable.Columns.Add("Model Name");
            dataGridViewTable.Columns.Add("Target Objects");
            dataGridViewTable.Columns.Add("Alarm Status");
            dataGridViewTable.Columns.Add("Warning Message");
            dataGridViewTable.Columns.Add("Minimum Threshold");


            SQLiteConnection SqlConnection = new SQLiteConnection("Data Source=system-files/database.db");
            SqlConnection.Open();

            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM created_systems", SqlConnection);
            SQLiteDataReader result = cmd.ExecuteReader();

            int index = 0;

            while(result.Read()) {
                index++;

                dataGridViewTable.Rows.Add(index, result["system_name"], result["model_name"], result["target_objects"], result["alarm_status"], result["warning_message"], result["min_threshold"]);
                
            }

            dataGridView1.DataSource = dataGridViewTable;

            SqlConnection.Close();
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
                
                SqlConnection.Close();

                SelectData();
                ClearForms();
                MessageBox.Show("Data Inserted!");

            }
            else {

                MessageBox.Show("Please fill out all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = dataGridView1.CurrentRow.Index;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Please confirm before proceed" + "\n" + "Do you want to delete this system ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DeleteSystem(selectedIndex);
            }
            
        }

        public void WriteWarningMessageToTextFile(string messgae) {

            using (StreamWriter writetext = new StreamWriter("system-files/alarm-text-to-speech-notes.txt"))
            {

                writetext.WriteLine(messgae);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string modelName = dataGridView1.Rows[selectedIndex].Cells[2].Value.ToString();
            string targetObjects = target_objects_cleanup(dataGridView1.Rows[selectedIndex].Cells[3].Value.ToString()).ToLower();
            string alarmStatus = dataGridView1.Rows[selectedIndex].Cells[4].Value.ToString();
           
            string warningMessage = "";

            string minThreshold = dataGridView1.Rows[selectedIndex].Cells[6].Value.ToString();

            if (alarmStatus == "On")
            {
                alarmStatus = "[TRUE]";
                warningMessage = dataGridView1.Rows[selectedIndex].Cells[5].Value.ToString();
                WriteWarningMessageToTextFile(warningMessage);

            }
            else if(alarmStatus == "Off") {

                alarmStatus = "[FALSE]";

            }

            using (StreamWriter writetext = new StreamWriter("run.bat"))
            {

                writetext.WriteLine("python run.py -m "+ modelName + " -l "+ targetObjects + " -a "+ alarmStatus + " -t "+ minThreshold + "");
            
            }

            System.Diagnostics.Process.Start(@"run.bat");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearForms();
        }
    }
}
