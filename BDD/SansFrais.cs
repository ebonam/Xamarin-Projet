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
namespace XamarinFinal.BDD
{
  public  class SansFrais: FileInterface
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int _id { get; set; }
        public string name { get; set; }
        public string motif { get; set; }
        public int idTrajetAlle { get; set; }
        public int idTrajetRetour { get; set; }
        public string om { get; set; }

        public override string ToString()
        {
            string str = "";
            str += _id + "/2/SansFrais"+ name;
            return str;
        }

    }

}
