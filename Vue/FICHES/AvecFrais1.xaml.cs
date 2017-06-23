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
    public partial class AvecFrais1 : ContentPage
    {
        public AvecFrais1()
        {
            InitializeComponent();
            cont = Containeur.Instance;
        }

        Containeur cont;
        private void ValiderF(object sender, ToggledEventArgs e)
        {

            // DisplayAlert("hey", ""+Geocoding.GetLatLon("Solre le chateau").lat,"OK");
            DisplayAlert("hey", "" + Geocoding.GetMatrix("Solre le chateau","Clairfayts"), "OK");
            //            cont.Save();

            //   cont.PageType();
        }
        private void AnnulerF(object sender, ToggledEventArgs e)
        {
            cont.PageType();
        }
    }
}
