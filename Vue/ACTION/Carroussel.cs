
using System.Collections.Generic;
using System.Threading;
using Xamarin.Forms;
using XamarinFinal;

namespace Xamarin.vue
{
    public class MainPageCS : CarouselPage
    {
        public MainPageCS(App app)
        {
            //  switch(RuntimePlateform);
            
            var padding = new Thickness(0, 40, 0, 0);
            ConnSql s = ConnSql.Instance;
            var listUser = s.CountUtilisateur();

            if (listUser.Count != 0)
            {
                List<ContentPage> listContent = new List<ContentPage>();
                //List<>
                for (int i = 0; i < listUser.Count; i++)
                {

                    Button bouton1 = new Button2();
                    bouton1.Text = "Creer nouveau";
                    bouton1.HorizontalOptions = LayoutOptions.Center;
                    bouton1.VerticalOptions = LayoutOptions.EndAndExpand;
                   bouton1.Clicked += (sender, ea) => { App.Instance.ToNewUser();    }
                        ;


                    Button2 bouton2 = new Button2();
                    bouton2.Text = "Supprimer ";
                    bouton2.HorizontalOptions = LayoutOptions.Center;
                    bouton2.VerticalOptions = LayoutOptions.Center
                  ;
                    bouton2.utilisateur = listUser[i];
                    bouton2.Clicked += (sender, ea) => {
                        var e = i; Containeur.Instance.delUser(bouton2.utilisateur);
                        App.Instance.ToCarrousel();

                    };

                    Button2 bouton = new Button2();
                    bouton.Text = "Selectionner ";
                    bouton.HorizontalOptions = LayoutOptions.Center;
                        bouton.VerticalOptions = LayoutOptions.Center
                      ;
                    bouton.utilisateur =listUser[i];
                    bouton.Clicked += (sender, ea) => { var e = i; Containeur.Instance.SetUser(bouton.utilisateur); 
                    };// } //fonctionClicked;
                    string str = listUser[i].nom;
                    string str2 = listUser[i].prenom;
                    var redContentPage = new ContentPage
                    {
                        Padding = padding,
                        Content = new StackLayout
                        {
                            Children = {
                    new Label {
                        Text = "Selectionnez un compte",
                        FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center
                    }, new StackLayout {
                        VerticalOptions=LayoutOptions.CenterAndExpand,
                        Children = {                            new Label {
                        Text = str,
                        FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center
                    },
                            new Label {
                        Text = str2,
                        FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center
                    },
                            new StackLayout
                            {
                                Orientation=StackOrientation.Horizontal,
                                VerticalOptions=LayoutOptions.CenterAndExpand,
                                Children= {

                                            bouton,
                                            bouton2
                                           }

                            }
                        }
                    },bouton1
                }
                        }
                    };
                    
                    listContent.Add(redContentPage);

                }

                foreach (ContentPage cp in listContent)
                {

                    Children.Add(cp);
                }

            }
            else
            {



                var redContentPage = new ContentPage {
                    Padding = padding,
                    Content = new StackLayout
                    {

            } };
                Children.Add(redContentPage);
                Thread.Sleep(100);
                    App.Instance.ToNewUser();

                }
        }




    }
}