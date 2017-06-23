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
    public partial class Test : ContentPage
    {


        Containeur cont;
        public Test()
        {
            InitializeComponent();
            cont = Containeur.Instance;
            cont.utilisateur = new Utilisateur(); ;
            PersoUVHC.Toggled += switcher_Toggled;
        }

        private void AnnulerFct(object sender, TextChangedEventArgs e)
        {
            App.Instance.ToChoixUser();
        }
        private void ValiderFct(object sender, TextChangedEventArgs e)
        {
            if (Nom.Text != "" && prenom.Text != "" && numTel.Text != "" && Mail.Text != "" && LieuNaissance.Text!="" && Addresse.Text != ""                 )

            {
                cont.utilisateur.Homme = this.Homme.IsToggled;
                cont.utilisateur.nom = Nom.Text;
                cont.utilisateur.prenom = prenom.Text;
                cont.utilisateur.numPhone = numTel.Text;
                cont.utilisateur.mail = Mail.Text;
                cont.utilisateur.LieuNaissance = LieuNaissance.Text;

                cont.utilisateur.addresseComplete = Addresse.Text;
                cont.utilisateur.dateNaissance = DateNaissance.Date;


                cont.utilisateur.PersoUvhc = PersoUVHC.IsToggled;
                if (PersoUVHC.IsToggled && Grade.Text != "" && NomComposante.Text != "" )
                {
                    cont.utilisateur.grade = Grade.Text;

                    cont.utilisateur.nomComposante = NomComposante.Text;
                    cont.addUser();
                    App.Instance.ToFile();

                }
                else if (true)
                {
                    cont.addUser();
                    App.Instance.ToFile();
                }
                else { }
            }
        }



        private void switcher_Toggled(object sender, ToggledEventArgs e)
        {
            if (PersoUVHC.IsToggled)
            {
                ContaineurUVHC.IsVisible = true;
                ContaineurNonUVHC.IsVisible = false;
            }
            else
            {
                ContaineurUVHC.IsVisible = false; ContaineurNonUVHC.IsVisible = true;
            }
        }
    }
}
