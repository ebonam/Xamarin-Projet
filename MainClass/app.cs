using Xamarin.Forms;
using System;

using XamarinFinal.Vue;
using Xamarin.vue;
using XamarinFinal;
using XamarinFinal.Vue.FICHES;

public class App : Application
{
    private static readonly App instance = new App();

    public static App Instance
    {
        get
        {
            return instance;
        }
    }
    Containeur c;
    private App()
    {
      
        c = Containeur.Instance;
     //   new pdfDAUVP().generate();
    ToChoixUser();//   MainPage = new Menu1();// MainPageCS(this);
    }

    public void ToMap(System.Collections.Generic.List<string> s, string debut, string fin) {

         MainPage= new MapPageCS2(s,debut,fin);
    }

    public void ToChoixUser()
    {
               int i = c.nbUser();
       if (i == 0) MainPage = new Test();
      else
 MainPage = new MainPageCS(this);
    }


    internal void ToCarrousel()
    {
        if (Containeur.Instance.nbUser() == 0)
        {
            MainPage = new Test();
        }else
        { MainPage = new MainPageCS(this); }
    }
    public void ToFile()
    {

        MainPage = new Fichier2();

    }

    public void ToMenu()
    {

        MainPage = Menu1.Instance;//MainPageCS(this);

    }



    internal void ToNewUser()
    {

        MainPage = new Test();
    }
}
