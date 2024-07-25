using MongoDB.Bson;
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
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        student h;
        Form form1;
        static MongoClient c = new MongoClient();
        static IMongoDatabase db = c.GetDatabase("covid19");
        static IMongoCollection<student> collection = db.GetCollection<student>("test");
       

        public Form2(student h, Form form)
        {
            InitializeComponent();
            this.h = h;
            form1 = form;
        }
        public void redalldoument()
        {
            List<student> list = collection.AsQueryable().ToList<student>();
            dataGridView1.DataSource = list;

            metroTextBox6.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();

           // metroTextBox2.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
           // metroTextBox3.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
           //// metroTextBox4.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
           // metroTextBox5.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
           /* foreach (RadioButton rb in groupBox4.Controls)
            {
                if (rb.Text == dataGridView1.Rows[0].Cells[5].Value.ToString())

                {
                    rb.Checked = true;
                }
            }*/


            metroComboBox1.SelectedItem = dataGridView1.Rows[0].Cells[6].Value.ToString();
          //  dateTimePicker1.Value = DateTime.ParseExact(dataGridView1.Rows[0].Cells[8].Value.ToString(),
    //"dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            metroComboBox3.SelectedItem = dataGridView1.Rows[0].Cells[9].Value.ToString();




        }

        private void Form2_Load(object sender, EventArgs e)
        {
            metroTextBox6.Hide();
            metroComboBox1.Items.Add("positive");
            metroComboBox1.Items.Add("negative");
            metroComboBox1.SelectedIndex = 1;

            /* metroComboBox2.Items.Add("sfax");
             metroComboBox2.Items.Add("tunis");
             metroComboBox2.Items.Add("nabeul");
             metroComboBox2.SelectedIndex = 1;*/

            metroComboBox3.Items.Add("14");
            metroComboBox3.Items.Add("21");
            metroComboBox3.Items.Add("28");
            metroComboBox3.SelectedIndex = 1;

           /* foreach (RadioButton rb in groupBox4.Controls)
            {
                if (rb.Checked == false)

                {
                    rb.Checked = true;
                }
            }*/
            redalldoument();

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            metroTextBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
           // metroTextBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
           // metroTextBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
           // metroTextBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
           // metroTextBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
           /* foreach (RadioButton rb in groupBox4.Controls)
            {
                if (rb.Text == dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString())

                {
                    rb.Checked = true;
                }
            }*/


            metroComboBox1.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            //dateTimePicker1.Value = DateTime.ParseExact(dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString(),
  // "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            metroComboBox3.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
          
            if (metroComboBox1.SelectedIndex == -1)
            { { MessageBox.Show("Please select patient  result test", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); return; } }

            if (dateTimePicker1.Text.Length == 0)
            {
                { MessageBox.Show("Please select patient  detection date ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            }
            if (dateTimePicker1.Value.Date > DateTime.Now.Date)
            {
                { MessageBox.Show("Please select patient  detection date < datetoday ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            }

            if (metroComboBox3.SelectedIndex == -1)
            { { MessageBox.Show("Please select patient  time confinment", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); return; } }


            //MessageBox.Show(metroComboBox1.SelectedItem.ToString());
            // string value6 = "empty";
            // string value7 = "empty";
            string value8 = "empty";
            Nullable<DateTime> dt = null;
            dt = new DateTime();
           // DateTime dt2 = dt ?? DateTime.MinValue;
            DateTime dt3 = dt ?? DateTime.MinValue;

           
                   // string operation = rb.Text;

            var updateDef = Builders<student>.Update.Set("result", metroComboBox1.SelectedItem.ToString()).Set("month_detection", dateTimePicker1.Value)
                        .Set("confinementtime", metroComboBox3.SelectedItem.ToString()).Set("patientsituation", value8).Set("situationdate", dt3);
                    collection.UpdateOne(s => s.Id == ObjectId.Parse(metroTextBox6.Text), updateDef);

                    // row.Cells[2].Value = operation;
               
            

            redalldoument();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

            Form3 f3 = new Form3(h, this);
             f3.Show();
            Form2 f2 = new Form2(h,this);
            this.Hide();
        }

        private void metroButton3_Click_1(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(h);
            f4.Show();
           // Form2 f2 = new Form2(h, this);
            this.Hide();
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            metroComboBox1.SelectedIndex = -1;
            metroComboBox3.SelectedIndex = -1;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
