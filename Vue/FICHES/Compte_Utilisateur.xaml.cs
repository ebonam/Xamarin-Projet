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
    public partial class Compte_Utilisateur : ContentPage
    {
        Containeur cont;

        public Compte_Utilisateur()
        {
            InitializeComponent();
            cont = Containeur.Instance;

            Nom.Text = cont.utilisateur.nom;
            prenom.Text = cont.utilisateur.prenom;
            numTel.Text = cont.utilisateur.numPhone;
            Addresse.Text = cont.utilisateur.addresseComplete;
            Mail.Text = cont.utilisateur.mail;
           LieuNaissance.Text = cont.utilisateur.LieuNaissance ;
            DateNaissance.Date= cont.utilisateur.dateNaissance ;

   PersoUVHC.IsToggled = cont.utilisateur.PersoUvhc;


            Grade.Text = cont.utilisateur.grade;
            NomComposante.Text= cont.utilisateur.nomComposante;
            PersoUVHC.Toggled += switcher_Toggled;

            Etablissement.Text = cont.utilisateur.Etablissement;




        }



        //faire pareil pour le reste 
        private void ValiderF(object sender, ToggledEventArgs e)
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
            if (PersoUVHC.IsToggled && Grade.Text != "" && NomComposante.Text != "")
            {
                cont.utilisateur.grade = Grade.Text;

                cont.utilisateur.nomComposante = NomComposante.Text;
                cont.SaveUser();
                cont.PageType();


            }
            else if (true)
            {

                cont.utilisateur.Fonctionnare = Fonctionnaire.IsToggled;
                cont.utilisateur.nomComposante = NomComposante.Text;

                cont.SaveUser();
                cont.PageType();
            }
            else { }

          
        }
        private void AnnulerF(object sender, ToggledEventArgs e)
        {
cont.PageType();
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
