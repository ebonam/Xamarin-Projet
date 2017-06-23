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
    public partial class SansFrais1 : ContentPage
    {
        Trajet traj;
        Trajet traj2;
        Containeur cont;
        private void ValiderF(object sender, ToggledEventArgs e)
        {



            cont.listTrajet = cont.getTrajet(cont.SansFrais._id);
            
     cont.SansFrais.motif = this.Motif.Text ;
              cont.SansFrais.om= this.OM.Text;
            
            traj.dateArr=this.DateArr ;
            traj2.dateArr=this.DateArr1  ;

             traj.dateDep= this.DateDep;
            traj2.dateDep=this.DateDep1;

            traj.idAddresseArr=            this.LieuArr.Text ;
            traj2.idAddresseArr=this.LieuArr1.Text ;

 traj.idAddresseDep = this.Lieu.Text;
 traj2.idAddresseDep = this.LieuArr.Text;

            cont.listTrajet = new List<Trajet>();
            cont.listTrajet.Add(traj);
            cont.listTrajet.Add(traj2);



            cont.Save();
            cont.PageType();
        }
        private void AnnulerF(object sender, ToggledEventArgs e)
        {
            
            cont.PageType();
        }

        


        private void SwitchChanged(object sender, ToggledEventArgs e) {
       
       

        }


        private void VoirTrajet(object sender, ToggledEventArgs e) {
            if (this.Lieu.Text != "" && LieuArr.Text != "")
            { App.Instance.ToMap(new List<string> {Lieu.Text, LieuArr.Text }, Lieu.Text, LieuArr.Text); }


        }

        private void VoirTrajet2(object sender, ToggledEventArgs e)
        {
            if (this.Lieu1.Text != "" && LieuArr1.Text != "")
            { App.Instance.ToMap(new List<string> { Lieu1.Text, LieuArr1.Text }, Lieu1.Text, LieuArr1.Text); }

        }


        private void Spoiler1(object sender, ToggledEventArgs e)
        {
            if (_Spoiler2L.IsVisible)
                _Spoiler2L.IsVisible = false;
            else
                _Spoiler2L.IsVisible = true;
        }
        private void Spoiler(object sender, ToggledEventArgs e)
        {
            if (_Spoiler1L.IsVisible)
                _Spoiler1L.IsVisible = false;
            else
                _Spoiler1L.IsVisible = true;
        }




        public SansFrais1()
        {
            InitializeComponent();
            cont = Containeur.Instance;
         cont.listTrajet=   cont.getTrajet(cont.SansFrais._id);
            traj = cont.listTrajet[0];
             traj2 = cont.listTrajet[1];

            this.Motif.Text=cont.SansFrais.motif;
            this.OM.Text = cont.SansFrais.om;
            this.DateArr =traj.dateArr;
            this.DateArr1 = traj2.dateArr;

            this.DateDep = traj.dateDep;
            this.DateDep1 = traj2.dateDep;

            this.LieuArr.Text = traj.idAddresseArr;
            this.LieuArr1.Text = traj2.idAddresseArr;

            this.Lieu.Text = traj.idAddresseDep;
            this.LieuArr.Text = traj2.idAddresseDep;
        }
    }
}