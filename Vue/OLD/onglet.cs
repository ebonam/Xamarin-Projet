
using Xamarin.Forms;
using XamarinFinal;

public class Onglet : TabbedPage
{
    public Onglet()
    {
      Containeur c = Containeur.Instance;

        switch (c.Type) {

            case 0: //dauvp
               // Children.Add(new DAUVP());
                break;
            case 1:
//                var navigationPage = new NavigationPage(new SchedulePageCS());
 /*               navigationPage.Icon = "schedule.png";
                navigationPage.Title = "Avec Frais";

                Children.Add(new TodayPageCS());
                Children.Add(navigationPage);
   */             break;
            case 2:

                //var navigationPage = new NavigationPage(new SchedulePageCS());
                /*               navigationPage.Icon = "schedule.png";
                               navigationPage.Title = "Avec Frais";

                               Children.Add(new TodayPageCS());
                               Children.Add(navigationPage);
                  */


                break;



        }
   
    }
}