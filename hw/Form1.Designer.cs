namespace hw
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toolStripContainer1 = new ToolStripContainer();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            checkBox1 = new CheckBox();
            label2 = new Label();
            listView1 = new ListView();
            Name = new ColumnHeader();
            Location = new ColumnHeader();
            Size = new ColumnHeader();
            label3 = new Label();
            result = new Label();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(label1);
            toolStripContainer1.ContentPanel.Controls.Add(textBox1);
            toolStripContainer1.ContentPanel.Size = new Size(300, 325);
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(300, 350);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 6);
            label1.Name = "label1";
            label1.Size = new Size(145, 32);
            label1.TabIndex = 6;
            label1.Text = "File's format";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(31, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 39);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(285, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(477, 39);
            textBox2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(813, 62);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 3;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(993, 62);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 4;
            button2.Text = "Stop";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(891, 12);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(198, 36);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Subdirectories";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(463, 31);
            label2.Name = "label2";
            label2.Size = new Size(134, 32);
            label2.TabIndex = 7;
            label2.Text = "File's name";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Name, Location, Size });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(205, 179);
            listView1.Name = "listView1";
            listView1.Size = new Size(791, 591);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Name
            // 
            Name.Text = "Name";
            Name.Width = 230;
            // 
            // Location
            // 
            Location.Text = "Location";
            Location.Width = 460;
            // 
            // Size
            // 
            Size.Text = "Size";
            Size.Width = 100;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(492, 129);
            label3.Name = "label3";
            label3.Size = new Size(187, 32);
            label3.TabIndex = 9;
            label3.Text = "Result of search:";
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(685, 129);
            result.Name = "result";
            result.Size = new Size(27, 32);
            result.TabIndex = 10;
            result.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 826);
            Controls.Add(result);
            Controls.Add(label3);
            Controls.Add(listView1);
            Controls.Add(label2);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(toolStripContainer1);
            Text = "Form1";
            Load += Form1_Load;
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.ContentPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripContainer toolStripContainer1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private CheckBox checkBox1;
        private Label label1;
        private Label label2;
        private ListView listView1;
        private ColumnHeader Name;
        private ColumnHeader Location;
        private ColumnHeader Size;
        private Label label3;
        private Label result;
    }
}
