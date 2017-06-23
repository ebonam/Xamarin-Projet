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
    class AvecFrais2
    {


        [PrimaryKey, AutoIncrement, Column("_id")]
        public int _id { get; set; }
        public float FraisIns { get; set; }
        public int Repasofferts { get; set; }
        public int RepasrU { get; set; }
        public int RepasASesFrais { get; set; }
        public int nbNuité { get; set; }
        public int nbNuitéPayé { get; set; }
        public int nbNuitéOfferte { get; set; }

    }
}