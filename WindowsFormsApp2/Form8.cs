using MongoDB.Driver;
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
    public partial class Form8 : MetroFramework.Forms.MetroForm
    {
        student h;
        static MongoClient c = new MongoClient();
        static IMongoDatabase db = c.GetDatabase("covid19");
        static IMongoCollection<user> collection = db.GetCollection<user>("user");

        public Form8(student h)
        {
            InitializeComponent();
            this.h = h;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            { { MessageBox.Show("user name empty! ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); return; } }
            if (textBox2.Text == "")
            { { MessageBox.Show("password empty ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); return; } }

            string hj = dataGridView1.Rows[0].Cells[1].Value.ToString();
            string hjk = dataGridView1.Rows[0].Cells[2].Value.ToString();
            if (textBox1.Text != hj)
            { { MessageBox.Show("Please enter  valid username ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); return; } }
            if (textBox2.Text != hjk)
            { { MessageBox.Show("Please enter  valid password ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); return; } }

            Form4 f4 = new Form4(h);
            f4.Show();
            // Form1 f1 = new Form1(h);
            this.Hide();

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            List<user> list = collection.AsQueryable().ToList<user>();
            dataGridView1.DataSource = list;
            dataGridView1.Hide();

            /*for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
            {
                for (int col = 0; col < dataGrid.Rows[rows].Cells.Count; col++)
                {
                    string value = dataGrid.Rows[rows].Cells[col].Value.ToString();

                }
            }*/
       
          //  MessageBox.Show(hj);
          //  MessageBox.Show(hjk);

        }
    }
}
