namespace object_detection_alerting_system
{
    partial class target_objects_panel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.target_objects = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.target_objects);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(26, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(993, 688);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Target Objects";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Person",
            "Bicycle",
            "Car",
            "Motorcycle",
            "Airplane",
            "Bus",
            "Train",
            "Truck",
            "Boat",
            "Traffic Light",
            "Fire Hydrant",
            "Stop Sign",
            "Parking Meter",
            "Bench",
            "Bird",
            "Cat",
            "Dog",
            "Horse",
            "Sheep",
            "Cow",
            "Elephant",
            "Bear",
            "Zebra",
            "Giraffe",
            "Backpack",
            "Umbrella",
            "Handbag",
            "Tie",
            "Suitcase",
            "Frisbee",
            "Skis",
            "Snowboard",
            "Sports Ball",
            "Kite",
            "Baseball Bat",
            "Baseball Glove",
            "Skateboard",
            "Surfboard",
            "Tennis Racket",
            "Bottle",
            "Wine Glass",
            "Cup",
            "Fork",
            "Knife",
            "Spoon",
            "Bowl",
            "Banana",
            "Apple",
            "Sandwich",
            "Orange",
            "Broccoli",
            "Carrot",
            "Hot Dog",
            "Pizza",
            "Donut",
            "Cake",
            "Chair",
            "Couch",
            "Potted Plant",
            "Bed",
            "Dining Table",
            "Toilet",
            "TV",
            "Laptop",
            "Mouse",
            "Remote",
            "Keyboard",
            "Cell Phone",
            "Microwave",
            "Oven",
            "Toaster",
            "Sink",
            "Refrigerator",
            "Book",
            "Clock",
            "Vase",
            "Scissors",
            "Teddy Bear",
            "Hair Drier",
            "Toothbrush"});
            this.listBox1.Location = new System.Drawing.Point(32, 62);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(271, 580);
            this.listBox1.TabIndex = 0;
            // 
            // target_objects
            // 
            this.target_objects.Location = new System.Drawing.Point(435, 62);
            this.target_objects.MaxLength = 300;
            this.target_objects.Name = "target_objects";
            this.target_objects.ReadOnly = true;
            this.target_objects.Size = new System.Drawing.Size(552, 522);
            this.target_objects.TabIndex = 60;
            this.target_objects.Text = "";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(821, 620);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 44);
            this.button3.TabIndex = 61;
            this.button3.Text = "Done";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // target_objects_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 748);
            this.Controls.Add(this.groupBox1);
            this.Name = "target_objects_panel";
            this.Text = "Target Objects";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox target_objects;
        private System.Windows.Forms.Button button3;
    }
}