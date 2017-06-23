using Android.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFinal.Vue
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ParMail : ContentPage
    {
        public ParMail()
        {

            InitializeComponent();


            c = Containeur.Instance;
            if (c.Type == 1)
            {
                this.Fiche.IsVisible = true;
            }
            else this.Fiche.IsVisible = false;
        }
        Containeur c;

        /// <summary>
        /// Ajouter au listenner de bouton 
        /// </summary>

        void Send()
        {
            var email = new Intent(Android.Content.Intent.ActionSend);
            
            email.PutExtra(Android.Content.Intent.ExtraEmail,
new string[] { "person1@xamarin.com" });

            email.PutExtra(Android.Content.Intent.ExtraCc,
            new string[] { "person3@xamarin.com" });

            email.PutExtra(Android.Content.Intent.ExtraSubject, "");

            email.PutExtra(Android.Content.Intent.ExtraText,
            "Hello from Xamarin.Android");
        }

    }
}