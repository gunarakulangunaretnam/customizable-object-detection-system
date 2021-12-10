namespace object_detection_alerting_system
{
    partial class system_management
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.min_threshold_text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.min_tracker = new System.Windows.Forms.TrackBar();
            this.warning_message_box = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.alarm_status_combo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.model_list_combo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.system_name_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.target_objects = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.min_tracker)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(102, 629);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1728, 385);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "System Name";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkRed;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(102, 568);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(370, 44);
            this.button4.TabIndex = 6;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.target_objects);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.min_threshold_text);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.min_tracker);
            this.groupBox1.Controls.Add(this.warning_message_box);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.alarm_status_combo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.model_list_combo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.system_name_box);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(102, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1728, 504);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Systems";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(1511, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 44);
            this.button2.TabIndex = 9;
            this.button2.Text = "Create";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // min_threshold_text
            // 
            this.min_threshold_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min_threshold_text.Location = new System.Drawing.Point(1626, 288);
            this.min_threshold_text.Multiline = true;
            this.min_threshold_text.Name = "min_threshold_text";
            this.min_threshold_text.ReadOnly = true;
            this.min_threshold_text.Size = new System.Drawing.Size(65, 34);
            this.min_threshold_text.TabIndex = 58;
            this.min_threshold_text.Text = "50";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(850, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 25);
            this.label6.TabIndex = 57;
            this.label6.Text = "Minimum Threshold";
            // 
            // min_tracker
            // 
            this.min_tracker.Location = new System.Drawing.Point(1135, 293);
            this.min_tracker.Maximum = 100;
            this.min_tracker.Name = "min_tracker";
            this.min_tracker.Size = new System.Drawing.Size(485, 56);
            this.min_tracker.TabIndex = 56;
            this.min_tracker.Value = 50;
            this.min_tracker.Scroll += new System.EventHandler(this.opacity_trackbar_Scroll);
            // 
            // warning_message_box
            // 
            this.warning_message_box.Location = new System.Drawing.Point(1135, 79);
            this.warning_message_box.MaxLength = 300;
            this.warning_message_box.Name = "warning_message_box";
            this.warning_message_box.Size = new System.Drawing.Size(556, 136);
            this.warning_message_box.TabIndex = 9;
            this.warning_message_box.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(850, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Alarm Warning Message";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // alarm_status_combo
            // 
            this.alarm_status_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.alarm_status_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarm_status_combo.FormattingEnabled = true;
            this.alarm_status_combo.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.alarm_status_combo.Location = new System.Drawing.Point(230, 420);
            this.alarm_status_combo.Name = "alarm_status_combo";
            this.alarm_status_combo.Size = new System.Drawing.Size(159, 30);
            this.alarm_status_combo.TabIndex = 7;
            this.alarm_status_combo.SelectedIndexChanged += new System.EventHandler(this.alarm_status_combo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Alarm Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Target Objects";
            // 
            // model_list_combo
            // 
            this.model_list_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.model_list_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.model_list_combo.FormattingEnabled = true;
            this.model_list_combo.Location = new System.Drawing.Point(230, 172);
            this.model_list_combo.Name = "model_list_combo";
            this.model_list_combo.Size = new System.Drawing.Size(482, 30);
            this.model_list_combo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select a model";
            // 
            // system_name_box
            // 
            this.system_name_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.system_name_box.Location = new System.Drawing.Point(230, 79);
            this.system_name_box.Multiline = true;
            this.system_name_box.Name = "system_name_box";
            this.system_name_box.Size = new System.Drawing.Size(482, 34);
            this.system_name_box.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(494, 568);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(370, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "Start the System";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // target_objects
            // 
            this.target_objects.Location = new System.Drawing.Point(230, 251);
            this.target_objects.MaxLength = 300;
            this.target_objects.Name = "target_objects";
            this.target_objects.ReadOnly = true;
            this.target_objects.Size = new System.Drawing.Size(482, 117);
            this.target_objects.TabIndex = 59;
            this.target_objects.Text = "";
            this.target_objects.Click += new System.EventHandler(this.target_objects_Click);
            this.target_objects.TextChanged += new System.EventHandler(this.target_objects_TextChanged);
            // 
            // system_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Name = "system_management";
            this.Text = "System Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.system_management_FormClosed);
            this.Load += new System.EventHandler(this.system_management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.min_tracker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox system_name_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox model_list_combo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox alarm_status_combo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar min_tracker;
        private System.Windows.Forms.RichTextBox warning_message_box;
        private System.Windows.Forms.TextBox min_threshold_text;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox target_objects;
    }
}