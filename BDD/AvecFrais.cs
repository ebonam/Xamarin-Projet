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
    public class AvecFrais : FileInterface
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int _id { get; set; }
        public string name { get; set; }
        public int vehicule { get; set; }
        public int Train { get; set; }
        public int Avion { get; set; }
        public int Buyby { get; set; }
        public string autre { get; set; }
public int FraisAnnexe { get; set; }
        public string FraisAnnexeAutre { get; set; }


        public float montant { get; set;}
    
        public string observation { get; set; }






        

        public override string ToString()
        {
            string str = "";
            str += _id + "/1/AvecFrais" +name;
            return str;
        }

    }


}
