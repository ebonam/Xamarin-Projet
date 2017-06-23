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
    public partial class Sauvegarde : ContentPage
    {
        Containeur c;
        public Sauvegarde()
        {
            c = Containeur.Instance;
            InitializeComponent();
        }

        private void Save(object sender, TextChangedEventArgs e)
        {
            c.Save();
            c.PageType();

        }
    }
}