using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form4 : MetroFramework.Forms.MetroForm
    {
        student h;
        Form form1;
        public Form4(student h)
        {
            InitializeComponent();
            this.h = h;
            //form1 = form;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(h, this);
            f5.Show();
            Form1 f1 = new Form1(h);
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6(h, this);
            f6.Show();
            Form1 f1 = new Form1(h);
            this.Hide();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7(h, this);
            f7.Show();
            Form1 f1 = new Form1(h);
            this.Hide();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(h, this);
            f3.Show();
            //Form1 f1 = new Form1(h);
            this.Hide();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(h);
            f1.Show();
           // Form1 f1 = new Form1(h);
            this.Hide();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(h,this);
            f5.Show();
            // Form1 f1 = new Form1(h);
            this.Hide();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(h, this);
            f2.Show();
            // Form1 f1 = new Form1(h);
            this.Hide();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6(h, this);
            f6.Show();
            // Form1 f1 = new Form1(h);
            this.Hide();
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7(h, this);
            f7.Show();
            // Form1 f1 = new Form1(h);
            this.Hide();
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            Form8 f8 = new Form8(h);
            f8.Show();
            // Form1 f1 = new Form1(h);
            this.Hide();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {

        }
    }
}
