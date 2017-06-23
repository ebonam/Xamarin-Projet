using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using XamarinFinal.BDD;

namespace XamarinFinal
{
 public   class DAUVP :FileInterface
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int _id { get; set; }
        public int idUser { get; set; }
        public string Marque { get; set; }
        public string immatriculation { get; set; }
        public int CV { get; set; }
        public string nomAssureur { get; set; }
        public string AddresseAssureur{ get; set; }
        public string Police { get; set; }

public string name { get; set; }
        
        public override string ToString() {
            string str = "";
            str +=_id+"/0/";
            str +="DAUVP-"+name;
            return str;
        }

    }
}