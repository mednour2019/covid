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
    public partial class Form6 : MetroFramework.Forms.MetroForm
    {
        student h;
        Form form1;
        static MongoClient c = new MongoClient();
        static IMongoDatabase db = c.GetDatabase("covid19");
        static IMongoCollection<student> collection = db.GetCollection<student>("test");
        static DataTable tabmesure;

        public Form6(student h, Form form)
        {
            InitializeComponent();
            this.h = h;
            form1 = form;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = h.tabmesure2;

            List<student> list = collection.AsQueryable().ToList<student>();
            dataGridView1.DataSource = list;
            tabmesure = new DataTable();
            tabmesure.Columns.Add(new DataColumn("patient_code", typeof(string)));
           // tabmesure.Columns.Add(new DataColumn("patient_fisrtname", typeof(string)));
           // tabmesure.Columns.Add(new DataColumn("patient_lastname", typeof(string)));
            tabmesure.Columns.Add(new DataColumn("patient_age", typeof(string)));
            tabmesure.Columns.Add(new DataColumn("patient_sexe", typeof(string)));
            tabmesure.Columns.Add(new DataColumn("patient_city", typeof(string)));
            tabmesure.Columns.Add(new DataColumn("result", typeof(string)));
            tabmesure.Columns.Add(new DataColumn("month_detection", typeof(string)));
            tabmesure.Columns.Add(new DataColumn("confinementtime", typeof(string)));



            DataRow drLocal = null;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                drLocal = tabmesure.NewRow();
                drLocal["patient_code"] = row.Cells["patient_code"].Value;
               // drLocal["patient_fisrtname"] = row.Cells["patient_firstname"].Value;
               // drLocal["patient_lastname"] = row.Cells["patient_lastname"].Value;
                drLocal["patient_age"] = row.Cells["patient_age"].Value;
                drLocal["patient_sexe"] = row.Cells["patient_sexe"].Value;
                drLocal["patient_city"] = row.Cells["patient_city"].Value;
                drLocal["result"] = row.Cells["result"].Value;
                drLocal["month_detection"] = row.Cells["month_detection"].Value;
                drLocal["confinementtime"] = row.Cells["confinementtime"].Value;

                // MessageBox.Show(drLocal["patient_code"].ToString());

                tabmesure.Rows.Add(drLocal);


            }



            dataGridView2.DataSource = tabmesure;
            dataGridView1.Hide();



            int nbpos = 0;
            int nbneg = 0;
            foreach (DataRow r in tabmesure.Rows)
            {
                if (r["result"].ToString().ToUpper() == "POSITIVE")
                { nbpos++; }
                else
                 if (r["result"].ToString().ToUpper() == "NEGATIVE")
                { nbneg++; }

                  }

          this.chart1.Series["TEST"].Points.AddXY("POSITIVE", nbpos);
            this.chart1.Series["TEST"].Points.AddXY("NEGATIVE", nbneg);


            int nbnab = 0;
            int nbsfax = 0;
            int nbtun = 0;

            foreach (DataRow r in tabmesure.Rows)
            {
                if (r["patient_city"].ToString().ToUpper() == "SFAX" && (r["result"].ToString().ToUpper() == "POSITIVE"))
                { nbsfax++; }
                else
                 if (r["patient_city"].ToString().ToUpper() == "NABEUL" && (r["result"].ToString().ToUpper() == "POSITIVE"))
                { nbnab++; }
                else
                    if (r["patient_city"].ToString().ToUpper() == "TUNIS" && (r["result"].ToString().ToUpper() == "POSITIVE"))
                { nbtun++; }

            }
            this.chart2.Series["city"].Points.AddXY("sfax", nbsfax);
            this.chart2.Series["city"].Points.AddXY("nabeul", nbnab);
            this.chart2.Series["city"].Points.AddXY("tunis", nbtun);


        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            tabmesure.DefaultView.RowFilter = string.Format("[patient_city] LIKE '%{0}%'", metroTextBox1.Text);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(h);
            f4.Show();
           // Form1 f1 = new Form1(help);
            this.Hide();
        }
    }
}
