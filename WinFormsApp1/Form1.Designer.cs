namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            comboBox3 = new ComboBox();
            checkBox1 = new CheckBox();
            linkLabel1 = new LinkLabel();
            lblFilePath = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(113, 294);
            button1.Name = "button1";
            button1.Size = new Size(203, 52);
            button1.TabIndex = 0;
            button1.Text = "Slect Images";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "4", "3", "2" });
            comboBox1.Location = new Point(112, 367);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(203, 23);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "4";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 349);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 3;
            label1.Text = "Scale Ratio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 408);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 5;
            label2.Text = "Output Format";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "png", "jpg", "webp" });
            comboBox2.Location = new Point(112, 426);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(203, 23);
            comboBox2.TabIndex = 4;
            comboBox2.Text = "png";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Location = new Point(112, 528);
            button3.Name = "button3";
            button3.Size = new Size(205, 48);
            button3.TabIndex = 6;
            button3.Text = "Convert";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Resizer;
            pictureBox1.Location = new Point(113, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 471);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 9;
            label3.Text = "Model Name";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "realesr-animevideov3", "realesrgan-x4plus", "realesrgan-x4plus-anime", "realesrnet-x4plus" });
            comboBox3.Location = new Point(112, 489);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(203, 23);
            comboBox3.TabIndex = 8;
            comboBox3.Text = "realesrgan-x4plus";
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(113, 269);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(149, 19);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "FolderBase Proccessing";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(164, 698);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(98, 15);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "©-2023 Bigjavani";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // lblFilePath
            // 
            lblFilePath.BorderStyle = BorderStyle.Fixed3D;
            lblFilePath.FlatStyle = FlatStyle.Flat;
            lblFilePath.Location = new Point(12, 612);
            lblFilePath.Name = "lblFilePath";
            lblFilePath.Size = new Size(429, 76);
            lblFilePath.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 593);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 13;
            label4.Text = "Log:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 729);
            Controls.Add(label4);
            Controls.Add(lblFilePath);
            Controls.Add(linkLabel1);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(comboBox3);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ImageResizer";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox2;
        private Button button3;
        private PictureBox pictureBox1;
        private Label label3;
        private ComboBox comboBox3;
        private CheckBox checkBox1;
        private LinkLabel linkLabel1;
        private Label lblFilePath;
        private Label label4;
    }
}