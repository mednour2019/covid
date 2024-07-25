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
    public partial class Form5 : MetroFramework.Forms.MetroForm
    {
        student h;
        Form form1;
        static MongoClient c = new MongoClient();
        static IMongoDatabase db = c.GetDatabase("covid19");
        static IMongoCollection<student> collection = db.GetCollection<student>("test");
        static DataTable tabmesure;



        public Form5(student h, Form form)
        {
            InitializeComponent();
            this.h= h;
            form1 = form;
        }

        private void Form5_Load(object sender, EventArgs e)
        {



            List<student> list = collection.AsQueryable().ToList<student>();
            dataGridView1.DataSource = list;

            tabmesure = new DataTable();
            tabmesure.Columns.Add(new DataColumn("patient_code", typeof(string)));
			tabmesure.Columns.Add(new DataColumn("patient_firstname", typeof(string)));  // Corrected spelling
			tabmesure.Columns.Add(new DataColumn("patient_lastname", typeof(string)));
            tabmesure.Columns.Add(new DataColumn("patient_age", typeof(string)));
            tabmesure.Columns.Add(new DataColumn("patient_sexe", typeof(string)));
            tabmesure.Columns.Add(new DataColumn("patient_city", typeof(string)));

            DataRow drLocal = null;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                drLocal = tabmesure.NewRow();
                drLocal["patient_code"] = row.Cells["patient_code"].Value;
                drLocal["patient_firstname"] = row.Cells["patient_firstname"].Value;
                drLocal["patient_lastname"] = row.Cells["patient_lastname"].Value;
                drLocal["patient_age"] = row.Cells["patient_age"].Value;
                drLocal["patient_sexe"] = row.Cells["patient_sexe"].Value;
                drLocal["patient_city"] = row.Cells["patient_city"].Value;
                // MessageBox.Show(drLocal["patient_code"].ToString());

                tabmesure.Rows.Add(drLocal);


            }



            dataGridView2.DataSource = tabmesure;

            int nbh = 0;
            int nbf = 0;
            foreach (DataRow r in tabmesure.Rows)
            {
                if (r["patient_sexe"].ToString().ToUpper() == "MALE")
                { nbh++; }
                else
                { nbf++; }






            }





            this.chart1.Series["SEXE"].Points.AddXY("FEMALE", nbf);
            this.chart1.Series["SEXE"].Points.AddXY("MALE", nbh);


            dataGridView1.Hide();


            /* foreach (DataColumn dc in h.tabmesure.Columns)
            {

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());

            }
            foreach (DataRow dr in h.tabmesure.Rows)
            {

                dataGridView1.Rows.Add(dr.ItemArray);

            }*/
            /* dataGridView1.DataSource = h.tabmesure ;
             int nbh = 0;
             int nbf = 0;
             foreach (DataRow r in h.tabmesure.Rows)
             {
                 if (r["patient_sexe"].ToString().ToUpper() == "MALE")
                 { nbh++; }
                 else
                 { nbf++; }






                 }*/



            // this.chart1.Series["SEXE"].Points.AddXY("FEMALE", nbf);
            //this.chart1.Series["SEXE"].Points.AddXY("MALE", nbh);

            /* foreach (DataGridViewRow row in dataGridView1.Rows)
             {
                 foreach (DataGridViewCell cell in row.Cells)
                 {
                    MessageBox.Show( cell.Value.ToString());

                 }
             }*/

        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
           tabmesure.DefaultView.RowFilter = string.Format("[patient_firstname] LIKE '%{0}%'", metroTextBox1.Text);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(h);
            f4.Show();
            //Form1 f1 = new Form1(help);
            this.Hide();
        }
    }
}
