using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class student
    {
        /*private string v1;
        private DateTime value1;
        private string text1;
        private string text2;
        private string text3;
        private string text4;
        private string value2;
        private string v2;
        private string v3;
        private DateTime value3;*/

        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("patient_code")]
        public string patient_code { get; set; }
		[BsonElement("patient_firstname")]  // Changed from "patient_fisrtname"
		public string patient_firstname { get; set; }

		[BsonElement("patient_lastname")]
        public string patient_lastname { get; set; }

        [BsonElement("patient_age")]
        public string patient_age { get; set; }

        [BsonElement("patient_sexe")]
        public string patient_sexe { get; set; }
        [BsonElement("patient_city")]
        public string patient_city { get; set; }

        [BsonElement("result")]
        public string result{ get; set; }

         [BsonElement("month_detection")]
         public DateTime month_detection { get; set; }
     
      
        [BsonElement("confinementtime")]
        public string confinementtime  { get; set; }

        [BsonElement("patientsituation")]
        public string patientsituation { get; set; }

        [BsonElement("situationdate")]
        public DateTime situationdate { get; set; }

       // public DataTable tabmesure { get; set; }
      //  public DataTable tabmesure2 { get; set; }



        public student()
        {
        }

        public student(string patient_code, string patient_firstname, string patient_lastname, string patient_age, string patient_sexe, string patient_city, string result, 
            DateTime month_detection,    string confinementtime, string patientsituation, DateTime situationdate)
        {
            this.patient_code = patient_code;

            this.patient_firstname = patient_firstname;
            this.patient_lastname = patient_lastname;
            this.patient_age = patient_age;
            this.patient_sexe = patient_sexe;
            this.patient_city = patient_city;

            this.result = result;
            this.month_detection = month_detection;
         
          
            this.confinementtime = confinementtime;
            this.patientsituation = patientsituation;
            this.situationdate = situationdate;
        }

      
    }
}
