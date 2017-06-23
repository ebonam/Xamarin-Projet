using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinFinal;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFinal.Vue
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DAUVP_Vue : ContentPage
    {
        public DAUVP_Vue()
        {
            InitializeComponent();
            cont = Containeur.Instance;
            init();
        }

        public void init()
        {

            _CV.Text = cont.dauvp.CV.ToString();
            this._MarquePicker.SelectedItem = cont.dauvp.Marque;
            this._Immatriculation.Text = cont.dauvp.immatriculation;
            _NomAssureur.Text = cont.dauvp.nomAssureur;
            _PoliceN.Text = cont.dauvp.Police;
            _AddresseAgence.Text = cont.dauvp.AddresseAssureur;
        }

        Containeur cont;
        private void ValiderF(object sender, ToggledEventArgs e)
        {
            cont.Save();
            if (_CV.Text != null && _MarquePicker.SelectedItem != null && _Immatriculation.Text != null
                && _NomAssureur.Text != null && _PoliceN.Text != null && _AddresseAgence != null)
            {
                cont.dauvp.CV = int.Parse(_CV.Text);
                cont.dauvp.Marque = this._MarquePicker.SelectedItem.ToString();
                cont.dauvp.immatriculation = this._Immatriculation.Text;
                cont.dauvp.nomAssureur = _NomAssureur.Text;
                cont.dauvp.Police = _PoliceN.Text;
                cont.dauvp.AddresseAssureur = _AddresseAgence.Text;
                cont.dauvp.idUser = cont.utilisateur._id;
                cont.Save();
                cont.PageType();
            }

        }
        private void AnnulerF(object sender, ToggledEventArgs e)
        {
            cont.PageType();
        }
    }
}
