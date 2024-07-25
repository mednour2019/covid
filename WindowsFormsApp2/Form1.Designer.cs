namespace WindowsFormsApp2
{
    partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.metroButton1 = new MetroFramework.Controls.MetroButton();
			this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
			this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
			this.metroTextBox5 = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
			this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
			this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
			this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
			this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
			this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
			this.metroButton2 = new MetroFramework.Controls.MetroButton();
			this.metroButton3 = new MetroFramework.Controls.MetroButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.metroButton4 = new MetroFramework.Controls.MetroButton();
			this.metroTextBox6 = new MetroFramework.Controls.MetroTextBox();
			this.metroButton5 = new MetroFramework.Controls.MetroButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
			this.dataGridView1.Location = new System.Drawing.Point(20, 60);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(729, 150);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// metroButton1
			// 
			this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.metroButton1.Location = new System.Drawing.Point(6, 18);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new System.Drawing.Size(82, 30);
			this.metroButton1.TabIndex = 12;
			this.metroButton1.Text = "ADD";
			this.metroButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
			// 
			// metroTextBox2
			// 
			this.metroTextBox2.Location = new System.Drawing.Point(154, 29);
			this.metroTextBox2.Name = "metroTextBox2";
			this.metroTextBox2.Size = new System.Drawing.Size(123, 23);
			this.metroTextBox2.TabIndex = 17;
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.BackColor = System.Drawing.Color.LightGray;
			this.metroLabel4.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.metroLabel4.Location = new System.Drawing.Point(28, 29);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(85, 19);
			this.metroLabel4.TabIndex = 18;
			this.metroLabel4.Text = "Code patient";
			// 
			// metroLabel5
			// 
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.Location = new System.Drawing.Point(6, 68);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(114, 19);
			this.metroLabel5.TabIndex = 19;
			this.metroLabel5.Text = "First name patient";
			// 
			// metroTextBox3
			// 
			this.metroTextBox3.Location = new System.Drawing.Point(154, 64);
			this.metroTextBox3.Name = "metroTextBox3";
			this.metroTextBox3.Size = new System.Drawing.Size(123, 23);
			this.metroTextBox3.TabIndex = 20;
			// 
			// metroTextBox4
			// 
			this.metroTextBox4.Location = new System.Drawing.Point(154, 104);
			this.metroTextBox4.Name = "metroTextBox4";
			this.metroTextBox4.Size = new System.Drawing.Size(123, 23);
			this.metroTextBox4.TabIndex = 21;
			// 
			// metroLabel6
			// 
			this.metroLabel6.AutoSize = true;
			this.metroLabel6.Location = new System.Drawing.Point(8, 108);
			this.metroLabel6.Name = "metroLabel6";
			this.metroLabel6.Size = new System.Drawing.Size(112, 19);
			this.metroLabel6.TabIndex = 22;
			this.metroLabel6.Text = "Last name patient";
			// 
			// metroTextBox5
			// 
			this.metroTextBox5.Location = new System.Drawing.Point(154, 187);
			this.metroTextBox5.Name = "metroTextBox5";
			this.metroTextBox5.Size = new System.Drawing.Size(123, 23);
			this.metroTextBox5.TabIndex = 23;
			// 
			// metroLabel7
			// 
			this.metroLabel7.AutoSize = true;
			this.metroLabel7.Location = new System.Drawing.Point(36, 187);
			this.metroLabel7.Name = "metroLabel7";
			this.metroLabel7.Size = new System.Drawing.Size(77, 19);
			this.metroLabel7.TabIndex = 24;
			this.metroLabel7.Text = "Age patient";
			// 
			// metroRadioButton1
			// 
			this.metroRadioButton1.AutoSize = true;
			this.metroRadioButton1.Location = new System.Drawing.Point(29, 19);
			this.metroRadioButton1.Name = "metroRadioButton1";
			this.metroRadioButton1.Size = new System.Drawing.Size(49, 15);
			this.metroRadioButton1.TabIndex = 25;
			this.metroRadioButton1.TabStop = true;
			this.metroRadioButton1.Text = "Male";
			this.metroRadioButton1.UseVisualStyleBackColor = true;
			// 
			// metroRadioButton2
			// 
			this.metroRadioButton2.AutoSize = true;
			this.metroRadioButton2.Location = new System.Drawing.Point(17, 48);
			this.metroRadioButton2.Name = "metroRadioButton2";
			this.metroRadioButton2.Size = new System.Drawing.Size(61, 15);
			this.metroRadioButton2.TabIndex = 26;
			this.metroRadioButton2.TabStop = true;
			this.metroRadioButton2.Text = "Female";
			this.metroRadioButton2.UseVisualStyleBackColor = true;
			// 
			// metroLabel8
			// 
			this.metroLabel8.AutoSize = true;
			this.metroLabel8.Location = new System.Drawing.Point(38, 227);
			this.metroLabel8.Name = "metroLabel8";
			this.metroLabel8.Size = new System.Drawing.Size(80, 19);
			this.metroLabel8.TabIndex = 27;
			this.metroLabel8.Text = "Sexe patient";
			// 
			// metroComboBox2
			// 
			this.metroComboBox2.FormattingEnabled = true;
			this.metroComboBox2.ItemHeight = 23;
			this.metroComboBox2.Location = new System.Drawing.Point(154, 137);
			this.metroComboBox2.Name = "metroComboBox2";
			this.metroComboBox2.Size = new System.Drawing.Size(125, 29);
			this.metroComboBox2.TabIndex = 29;
			this.metroComboBox2.SelectedIndexChanged += new System.EventHandler(this.metroComboBox2_SelectedIndexChanged);
			// 
			// metroLabel9
			// 
			this.metroLabel9.AutoSize = true;
			this.metroLabel9.Location = new System.Drawing.Point(38, 147);
			this.metroLabel9.Name = "metroLabel9";
			this.metroLabel9.Size = new System.Drawing.Size(75, 19);
			this.metroLabel9.TabIndex = 30;
			this.metroLabel9.Text = "City patient";
			// 
			// metroButton2
			// 
			this.metroButton2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.metroButton2.Location = new System.Drawing.Point(6, 54);
			this.metroButton2.Name = "metroButton2";
			this.metroButton2.Size = new System.Drawing.Size(82, 29);
			this.metroButton2.TabIndex = 33;
			this.metroButton2.Text = "UPDATE";
			this.metroButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
			// 
			// metroButton3
			// 
			this.metroButton3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.metroButton3.Location = new System.Drawing.Point(6, 89);
			this.metroButton3.Name = "metroButton3";
			this.metroButton3.Size = new System.Drawing.Size(82, 33);
			this.metroButton3.TabIndex = 34;
			this.metroButton3.Text = "DELETE";
			this.metroButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.groupBox2.Controls.Add(this.groupBox4);
			this.groupBox2.Controls.Add(this.metroTextBox2);
			this.groupBox2.Controls.Add(this.metroLabel4);
			this.groupBox2.Controls.Add(this.metroTextBox3);
			this.groupBox2.Controls.Add(this.metroLabel5);
			this.groupBox2.Controls.Add(this.metroTextBox4);
			this.groupBox2.Controls.Add(this.metroLabel8);
			this.groupBox2.Controls.Add(this.metroTextBox5);
			this.groupBox2.Controls.Add(this.metroLabel7);
			this.groupBox2.Controls.Add(this.metroLabel6);
			this.groupBox2.Controls.Add(this.metroComboBox2);
			this.groupBox2.Controls.Add(this.metroLabel9);
			this.groupBox2.Location = new System.Drawing.Point(52, 237);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(375, 307);
			this.groupBox2.TabIndex = 36;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Information Patient";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.metroRadioButton2);
			this.groupBox4.Controls.Add(this.metroRadioButton1);
			this.groupBox4.Location = new System.Drawing.Point(154, 216);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(101, 85);
			this.groupBox4.TabIndex = 38;
			this.groupBox4.TabStop = false;
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
			this.groupBox3.Controls.Add(this.pictureBox5);
			this.groupBox3.Controls.Add(this.pictureBox4);
			this.groupBox3.Controls.Add(this.pictureBox3);
			this.groupBox3.Controls.Add(this.pictureBox2);
			this.groupBox3.Controls.Add(this.metroButton1);
			this.groupBox3.Controls.Add(this.metroButton2);
			this.groupBox3.Controls.Add(this.metroButton4);
			this.groupBox3.Controls.Add(this.metroButton3);
			this.groupBox3.Location = new System.Drawing.Point(450, 291);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(103, 175);
			this.groupBox3.TabIndex = 37;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Events";
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(9, 131);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(32, 29);
			this.pictureBox5.TabIndex = 40;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(6, 89);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(30, 33);
			this.pictureBox4.TabIndex = 40;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(6, 56);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(35, 27);
			this.pictureBox3.TabIndex = 40;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(6, 19);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(33, 28);
			this.pictureBox2.TabIndex = 40;
			this.pictureBox2.TabStop = false;
			// 
			// metroButton4
			// 
			this.metroButton4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.metroButton4.Location = new System.Drawing.Point(9, 131);
			this.metroButton4.Name = "metroButton4";
			this.metroButton4.Size = new System.Drawing.Size(79, 29);
			this.metroButton4.TabIndex = 35;
			this.metroButton4.Text = "CANCEL";
			this.metroButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
			// 
			// metroTextBox6
			// 
			this.metroTextBox6.Location = new System.Drawing.Point(624, 19);
			this.metroTextBox6.Name = "metroTextBox6";
			this.metroTextBox6.Size = new System.Drawing.Size(123, 23);
			this.metroTextBox6.TabIndex = 10;
			// 
			// metroButton5
			// 
			this.metroButton5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.metroButton5.Location = new System.Drawing.Point(290, 19);
			this.metroButton5.Name = "metroButton5";
			this.metroButton5.Size = new System.Drawing.Size(82, 40);
			this.metroButton5.TabIndex = 38;
			this.metroButton5.Text = "HOME";
			this.metroButton5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click_1);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(296, 24);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(29, 30);
			this.pictureBox1.TabIndex = 39;
			this.pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(769, 570);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.metroButton5);
			this.Controls.Add(this.metroTextBox6);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form1";
			this.Style = MetroFramework.MetroColorStyle.Silver;
			this.Text = "Data_Information_Patient";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroTextBox metroTextBox4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox metroTextBox5;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroTextBox metroTextBox6;
        private MetroFramework.Controls.MetroButton metroButton5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

