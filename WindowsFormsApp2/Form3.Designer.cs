namespace WindowsFormsApp2
{
    partial class Form3
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.metroButton2 = new MetroFramework.Controls.MetroButton();
			this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
			this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.metroButton1 = new MetroFramework.Controls.MetroButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.metroButton3 = new MetroFramework.Controls.MetroButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(23, 73);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(600, 150);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// metroButton2
			// 
			this.metroButton2.Location = new System.Drawing.Point(6, 19);
			this.metroButton2.Name = "metroButton2";
			this.metroButton2.Size = new System.Drawing.Size(78, 28);
			this.metroButton2.TabIndex = 2;
			this.metroButton2.Text = "update";
			this.metroButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
			// 
			// metroComboBox1
			// 
			this.metroComboBox1.FormattingEnabled = true;
			this.metroComboBox1.ItemHeight = 23;
			this.metroComboBox1.Location = new System.Drawing.Point(64, 58);
			this.metroComboBox1.Name = "metroComboBox1";
			this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
			this.metroComboBox1.TabIndex = 3;
			// 
			// metroTextBox1
			// 
			this.metroTextBox1.Location = new System.Drawing.Point(474, 30);
			this.metroTextBox1.Name = "metroTextBox1";
			this.metroTextBox1.Size = new System.Drawing.Size(121, 23);
			this.metroTextBox1.TabIndex = 4;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(19, 130);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 5;
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(64, 26);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(104, 19);
			this.metroLabel2.TabIndex = 7;
			this.metroLabel2.Text = "Patient_Situation";
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(64, 103);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(92, 19);
			this.metroLabel3.TabIndex = 8;
			this.metroLabel3.Text = "Situation_Date";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.groupBox1.Controls.Add(this.pictureBox5);
			this.groupBox1.Controls.Add(this.pictureBox3);
			this.groupBox1.Controls.Add(this.metroButton2);
			this.groupBox1.Controls.Add(this.metroButton1);
			this.groupBox1.Location = new System.Drawing.Point(309, 260);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(97, 103);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Events";
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(6, 61);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(35, 29);
			this.pictureBox5.TabIndex = 42;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(6, 20);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(35, 27);
			this.pictureBox3.TabIndex = 42;
			this.pictureBox3.TabStop = false;
			// 
			// metroButton1
			// 
			this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.metroButton1.Location = new System.Drawing.Point(6, 61);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new System.Drawing.Size(78, 29);
			this.metroButton1.TabIndex = 3;
			this.metroButton1.Text = "Clear";
			this.metroButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.groupBox2.Controls.Add(this.metroComboBox1);
			this.groupBox2.Controls.Add(this.metroLabel2);
			this.groupBox2.Controls.Add(this.metroLabel3);
			this.groupBox2.Controls.Add(this.dateTimePicker1);
			this.groupBox2.Location = new System.Drawing.Point(55, 234);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(232, 184);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Situation Data";
			// 
			// metroButton3
			// 
			this.metroButton3.Location = new System.Drawing.Point(294, 23);
			this.metroButton3.Name = "metroButton3";
			this.metroButton3.Size = new System.Drawing.Size(75, 30);
			this.metroButton3.TabIndex = 11;
			this.metroButton3.Text = "HOME";
			this.metroButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(294, 23);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(29, 30);
			this.pictureBox1.TabIndex = 41;
			this.pictureBox1.TabStop = false;
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(639, 450);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.metroButton3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.metroTextBox1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form3";
			this.Style = MetroFramework.MetroColorStyle.Silver;
			this.Text = "Situation_Test_Data";
			this.Load += new System.EventHandler(this.Form3_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}