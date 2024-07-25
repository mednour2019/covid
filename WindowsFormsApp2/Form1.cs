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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    { static MongoClient c=new MongoClient();
        static IMongoDatabase db = c.GetDatabase("covid19");
        static IMongoCollection<student> collection = db.GetCollection<student>("test");
       // student h;
       
       public void redalldoument()
        {
            List<student> list = collection.AsQueryable().ToList<student>();
            dataGridView1.DataSource = list;
           metroTextBox6.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            metroTextBox2.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            metroTextBox3.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            metroTextBox4.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
            metroTextBox5.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
            foreach (RadioButton rb in groupBox4.Controls)
            {
                if (rb.Text == dataGridView1.Rows[0].Cells[5].Value.ToString())

                {
                    rb.Checked = true;
                }
            }


            metroComboBox2.SelectedItem = dataGridView1.Rows[0].Cells[6].Value.ToString();


        }

          




        student help;

        public Form1(student help)
        {
            InitializeComponent();
            this.help=help;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           // metroComboBox1.Items.Add("positive");
           // metroComboBox1.Items.Add("negative");
        

            metroComboBox2.Items.Add("sfax");
           metroComboBox2.Items.Add("tunis");
            metroComboBox2.Items.Add("nabeul");
            metroComboBox2.SelectedIndex = 1;
            metroTextBox6.Hide();

           // metroComboBox3.Items.Add("14");
           // metroComboBox3.Items.Add("21");
           // metroComboBox3.Items.Add("28");

            foreach (RadioButton rb in groupBox4.Controls)
            {
                if (rb.Checked==false)

                {
                    rb.Checked = true;
                }
            }

            redalldoument();
           

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /* textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
             textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
             textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();*/

            metroTextBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            metroTextBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            metroTextBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            metroTextBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            metroTextBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            foreach (RadioButton rb in groupBox4.Controls)
            {
                if (rb.Text == dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString())

                {
                    rb.Checked = true;
                }
            }


            metroComboBox2.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         /*  student s = new student(textBox1.Text, textBox2.Text);
          
           collection.InsertOne(s);
           redalldoument();*/

         



        }

        private void button2_Click(object sender, EventArgs e)
        {
           /* var updateDef = Builders<student>.Update.Set("item", textBox1.Text).Set("qty", textBox2.Text);
            collection.UpdateOne(s => s.Id == ObjectId.Parse(textBox3.Text), updateDef);
            redalldoument();*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
           /* collection.DeleteOne(s => s.Id == ObjectId.Parse(textBox3.Text));
            redalldoument();*/
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            if (metroTextBox2.Text == "")
            { { MessageBox.Show("Please enter  patient code", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); return; } }
            if (metroTextBox3.Text == "")
            { { MessageBox.Show("Please enter  patient first name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); return; } }
            if (metroTextBox4.Text == "")
            { { MessageBox.Show("Please enter  patient last name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); return; } }
            if (metroComboBox2.SelectedIndex == -1)
            { { MessageBox.Show("Please select patient city", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); return; } }
            if (metroTextBox5.Text == "")
            { { MessageBox.Show("Please enter  patient age", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); return; } }
            int parsedValue;
            if (!int.TryParse(metroTextBox5.Text, out parsedValue))
            {
               // MessageBox.Show("This is a number only field");
                MessageBox.Show("This is a number only field", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (metroRadioButton1.Checked == false && metroRadioButton2.Checked == false)
            {
                { { MessageBox.Show("Please select patient sexe", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); return; } }

            }







            string value = "";
            bool isChecked = metroRadioButton1.Checked;
            if (isChecked)
                value = metroRadioButton1.Text;
            else
                value = metroRadioButton2.Text;

            string value2 = "empty";
            Nullable<DateTime> dt = null;
            dt = new DateTime();
            DateTime dt2 = dt ?? DateTime.MinValue;
            DateTime dt3 = dt ?? DateTime.MinValue;
           // string value4 = "empty";
            string value5 = "empty";
            string value6 = "empty";




            student s = new student(metroTextBox2.Text, metroTextBox3.Text, metroTextBox4.Text, metroTextBox5.Text, value, metroComboBox2.SelectedItem.ToString(), value5, dt3,  
             value6, value2, dt2);


            collection.InsertOne(s);
            redalldoument();

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {



            if (metroTextBox2.Text == "")
            { { MessageBox.Show("Please enter  patient code", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); return; } }
            if (metroTextBox3.Text == "")
            { { MessageBox.Show("Please enter  patient first name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); return; } }
            if (metroTextBox4.Text == "")
            { { MessageBox.Show("Please enter  patient last name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); return; } }
            if (metroComboBox2.SelectedIndex == -1)
            { { MessageBox.Show("Please select patient city", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); return; } }
            if (metroTextBox5.Text == "")
            { { MessageBox.Show("Please enter  patient age", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); return; } }
            int parsedValue;
            if (!int.TryParse(metroTextBox5.Text, out parsedValue))
            {
                // MessageBox.Show("This is a number only field");
                MessageBox.Show("This is a number only field", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (metroRadioButton1.Checked == false && metroRadioButton2.Checked == false)
            {
                { { MessageBox.Show("Please select patient sexe", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); return; } }

            }





            //MessageBox.Show(metroComboBox1.SelectedItem.ToString());
            string value6 = "empty";
            string value7 = "empty";
            string value8 = "empty";
            Nullable<DateTime> dt = null;
            dt = new DateTime();
            DateTime dt2 = dt ?? DateTime.MinValue;
            DateTime dt3 = dt ?? DateTime.MinValue;
           
             foreach (RadioButton rb in groupBox4.Controls)
             {
             if (rb.Checked == true)
            {
            string operation = rb.Text;
         
            var updateDef = Builders<student>.Update.Set("patient_code", metroTextBox2.Text).Set("patient_firstname", metroTextBox3.Text)
                        .Set("patient_lastname", metroTextBox4.Text).Set("patient_age", metroTextBox5.Text)
                        .Set("patient_sexe", operation).Set("patient_city", metroComboBox2.SelectedItem.ToString())
                        .Set("result", value6).Set("result", value6).Set("month_detection", dt2)
                        .Set("confinementtime", value7).Set("patientsituation", value8).Set("situationdate", dt3);
                    collection.UpdateOne(s => s.Id == ObjectId.Parse(metroTextBox6.Text), updateDef);
               
                    // row.Cells[2].Value = operation;
               }
         }

            redalldoument();

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            collection.DeleteOne(s => s.Id == ObjectId.Parse(metroTextBox6.Text));
            redalldoument(); 
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            metroTextBox2.Text = string.Empty;
            metroTextBox3.Text = string.Empty;
            metroTextBox4.Text = string.Empty;

            metroComboBox2.SelectedIndex = -1;
            metroTextBox5.Text = string.Empty;

           /* metroComboBox2.SelectedIndex = -1;
            metroComboBox3.SelectedIndex = -1;*/
            foreach (RadioButton rb in groupBox4.Controls)

            {
                if (rb.Checked == true)
                {
                    rb.Checked = false;
                }
            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(help, this);
            f2.Show();
            Form1 f11 = new Form1(help);
            this.Hide();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
           /* help.tabmesure = new DataTable();
            help.tabmesure.Columns.Add(new DataColumn("patient_code", typeof(string)));
            help.tabmesure.Columns.Add(new DataColumn("patient_fisrtname", typeof(string)));
            help.tabmesure.Columns.Add(new DataColumn("patient_lastname", typeof(string)));
            help.tabmesure.Columns.Add(new DataColumn("patient_age", typeof(string)));
            help.tabmesure.Columns.Add(new DataColumn("patient_sexe", typeof(string)));
            help.tabmesure.Columns.Add(new DataColumn("patient_city", typeof(string)));

            DataRow drLocal = null;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                drLocal = help.tabmesure.NewRow();
                drLocal["patient_code"] = row.Cells["patient_code"].Value;
                drLocal["patient_fisrtname"] = row.Cells["patient_firstname"].Value;
                drLocal["patient_lastname"] = row.Cells["patient_lastname"].Value;
                drLocal["patient_age"] = row.Cells["patient_age"].Value;
                drLocal["patient_sexe"] = row.Cells["patient_sexe"].Value;
                drLocal["patient_city"] = row.Cells["patient_city"].Value;
               // MessageBox.Show(drLocal["patient_code"].ToString());

                help.tabmesure.Rows.Add(drLocal);


            }*/



           /* help.tabmesure2 = new DataTable();
            help.tabmesure2.Columns.Add(new DataColumn("patient_code", typeof(string)));
           // help.tabmesure2.Columns.Add(new DataColumn("patient_fisrtname", typeof(string)));
           // help.tabmesure2.Columns.Add(new DataColumn("patient_lastname", typeof(string)));
            help.tabmesure2.Columns.Add(new DataColumn("patient_age", typeof(string)));
            help.tabmesure2.Columns.Add(new DataColumn("patient_sexe", typeof(string)));
            help.tabmesure2.Columns.Add(new DataColumn("patient_city", typeof(string)));
            help.tabmesure2.Columns.Add(new DataColumn("result", typeof(string)));
            help.tabmesure2.Columns.Add(new DataColumn("month_detection", typeof(string)));
            help.tabmesure2.Columns.Add(new DataColumn("confinementtime", typeof(string)));
            DataRow drLocal2 = null;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                drLocal2 = help.tabmesure2.NewRow();
                drLocal2["patient_code"] = row.Cells["patient_code"].Value;
                //drLocal2["patient_fisrtname"] = row.Cells["patient_firstname"].Value;
               // drLocal2["patient_lastname"] = row.Cells["patient_lastname"].Value;
                drLocal2["patient_age"] = row.Cells["patient_age"].Value;
                drLocal2["patient_sexe"] = row.Cells["patient_sexe"].Value;
                drLocal2["patient_city"] = row.Cells["patient_city"].Value;
                drLocal2["result"] = row.Cells["result"].Value;
                // MessageBox.Show(drLocal["patient_code"].ToString());
                drLocal2["month_detection"] = row.Cells["month_detection"].Value;
                drLocal2["confinementtime"] = row.Cells["confinementtime"].Value;

                help.tabmesure2.Rows.Add(drLocal2);


            }*/



            Form4 f4 = new Form4(help);
            f4.Show();
            Form1 f1 = new Form1(help);
            this.Hide();


        }

        private void metroButton5_Click_1(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(help);
            f4.Show();
           // Form1 f1 = new Form1(help);
            this.Hide();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
