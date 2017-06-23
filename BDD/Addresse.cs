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

namespace XamarinFinal{
    //
   public class Addresse
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int _id { get; set; }
        public string addresse { get; set; }
        public int numRue { get; set; }
        public string CP { get; set; }
        public string Ville { get; set; }
        public string Pays { get; set; }
        public string Long { get; set; }
        public string Lat { get; set; }
        

        public string nomRue { get; set; }


    }
}