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

namespace XamarinFinal
{
   public class Utilisateur
    {

        [PrimaryKey, AutoIncrement, Column("_id")]
        public int _id { get; set; }
        public Boolean Homme { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string numPhone { get; set; }
        public string mail { get; set; }
        public string addresseComplete { get; set; }
        public bool PersoUvhc { get; set; }

        public string grade { get; set; }
        public string nomComposante { get; set; }
        public DateTime dateNaissance { get; set; }
        public string LieuNaissance { get; set; }

        public string Etablissement { get; set; }
        public bool Fonctionnare { get; set; }
   

    }
}