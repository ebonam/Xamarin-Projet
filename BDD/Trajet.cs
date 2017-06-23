using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Xamarin.Forms;
using SQLite;

namespace XamarinFinal
{
    public class Trajet
    {
        [PrimaryKey, AutoIncrement, Column("_id")]



        public int _id { get; set; }
        public int typeFiche { get; set; }
        public int idFiche { get; set; }
        public int idUser { get; set; }
        public string idAddresseDep { get; set; }
        public DatePicker heureDep { get; set; }
        public DatePicker  dateDep { get; set; }
        
        public string idAddresseArr { get; set; }
        public DatePicker heureArr { get; set; }
        public DatePicker dateArr { get; set; }

      public void moveTo(Trajet tr)
        {
          
        }
    }
}