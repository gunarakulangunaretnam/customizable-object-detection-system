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

namespace object_detection_alerting_system
{
    public partial class model_management : Form
    {
        public model_management()
        {
            InitializeComponent();
        }

        int selectedIndex;

        private void button1_Click(object sender, EventArgs e)
        {
            if (model_url_textbox.Text != "")
            {

                if (model_url_textbox.Text.Contains("download.tensorflow.org"))
                {

                    using (StreamWriter writetext = new StreamWriter("download-models.bat"))
                    {
                        writetext.WriteLine("python download-models.py -u "+ model_url_textbox.Text);
                    }

                    model_url_textbox.Text = "";

                    System.Diagnostics.Process.Start(@"download-models.bat");



                }
                else {
                    model_url_textbox.Text = "";
                    MessageBox.Show("Sorry, unable to download from this url.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else {

                MessageBox.Show("Please enter a url", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string targetURL = @"https://github.com/tensorflow/models/blob/master/research/object_detection/g3doc/tf2_detection_zoo.md";
            System.Diagnostics.Process.Start(targetURL);

        }

        public void getModels() {

            string[] folders = System.IO.Directory.GetDirectories(@"data/models/", "*", System.IO.SearchOption.TopDirectoryOnly);

            DataTable dataGridViewTable = new DataTable();
            dataGridViewTable.Columns.Add("No");
            dataGridViewTable.Columns.Add("Model Name");

            

            for (int i = 0; i < folders.Length; i++)
            {

                string[] modelNameParts = folders[i].Split('/');

                string modelName = modelNameParts[modelNameParts.Length -1];

                dataGridViewTable.Rows.Add(i, modelName);

            }

            dataGridView1.DataSource = dataGridViewTable;


        }

        private void model_management_Load(object sender, EventArgs e)
        {
            getModels();
        }

        private void model_management_FormClosed(object sender, FormClosedEventArgs e)
        {
            sub_dashboard sub_Dashboard = new sub_dashboard();
            sub_Dashboard.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             selectedIndex = dataGridView1.CurrentRow.Index;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Please confirm before proceed" + "\n" + "Do you want to delete this model ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                string modelPath = "data/models/"+dataGridView1.Rows[selectedIndex].Cells[1].Value.ToString();
                Directory.Delete(modelPath, true);
                dataGridView1.Rows.RemoveAt(Convert.ToInt32(selectedIndex));
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            getModels();
        }
    }
}
