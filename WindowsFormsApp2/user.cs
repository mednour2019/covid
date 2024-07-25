using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class user
    {
        public user(string iden, string pass)
        {
            this.iden = iden;
            this.pass = pass;
        }

        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("iden")]
        public string iden { get; set; }
        [BsonElement("pass")]
        public string pass { get; set; }

        public user()
        {

        }

    }
   

}
