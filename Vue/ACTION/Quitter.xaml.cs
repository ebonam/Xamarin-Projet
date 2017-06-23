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
    public partial class Quitter : ContentPage
    {/// <summary>
    /// 
    /// </summary>
        public Quitter()
        {
            if (Device.OS == TargetPlatform.Android)
            {
                Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
            }

                InitializeComponent();
        }
    }
}