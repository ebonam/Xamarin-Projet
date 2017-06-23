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
    public partial class Deconnexion : ContentPage
    {
        public Deconnexion()
        {
            InitializeComponent();

         App.Instance.ToCarrousel();
        }
    }
}