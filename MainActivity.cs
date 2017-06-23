using Android.App;
using Android.Widget;
using Android.OS;
using XamarinFinal.Vue;

namespace XamarinFinal
{
    [Activity(Label = "XamarinFinal", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(App.Instance);
        }
    }
}

