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
    public partial class AvecFraisConfirmation : ContentPage
    {
        public AvecFraisConfirmation()
        {
            InitializeComponent();
            cont = Containeur.Instance;
        }

        Containeur cont;
        private void VoirTrajet(object sender, ToggledEventArgs e)
        {
            if (this.Lieu.Text != "" && LieuArr.Text != "")
            { App.Instance.ToMap(new List<string> { Lieu.Text, LieuArr.Text }, Lieu.Text, LieuArr.Text); }


        }

        private void VoirTrajet2(object sender, ToggledEventArgs e)
        {
            if (this.Lieu.Text != "" && LieuArr.Text != "")
            { App.Instance.ToMap(new List<string> { Lieu.Text, LieuArr.Text }, Lieu.Text, LieuArr.Text); }


        }

        private void ValiderF(object sender, ToggledEventArgs e)
        {
            cont.PageType();
        }
        private void AnnulerF(object sender, ToggledEventArgs e)
        {
            cont.Save();
            cont.PageType();
        }
    }
}