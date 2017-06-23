using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFinal.Vue
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu1Master : ContentPage
    {
        public ListView ListView => ListViewMenuItems;
        Containeur c;
        private static readonly Menu1Master instance = new Menu1Master();
        public void rebind()
        { BindingContext = new Menu1MasterViewModel(c); }
        public static Menu1Master Instance
        {
            get
            {
                return instance;
            }
        }

        private Menu1Master()
        {
            InitializeComponent();
            c = Containeur.Instance;
            BindingContext = new Menu1MasterViewModel(c);
        }



        class Menu1MasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<Menu1MenuItem> MenuItems { get; }
            public Menu1MasterViewModel(Containeur c)
            {
                if (c.Type == 0)
                {
                    MenuItems = new ObservableCollection<Menu1MenuItem>(new[]
                    {
                        /**TODO CHANGER LES PAGES ICI */
                    new Menu1MenuItem { Id = 0, Title = "DAUVP" , TargetType=typeof(DAUVP_Vue)},
                    new Menu1MenuItem { Id = 1, Title = "Modifier Utilisateur" , TargetType=typeof(Compte_Utilisateur)},
                    new Menu1MenuItem { Id = 2, Title = "Ouvrir",  TargetType=typeof(Fichiers)},
                    new Menu1MenuItem { Id = 3, Title = "Envoyer par courriel", TargetType=typeof(ParMail) },
                    new Menu1MenuItem { Id = 4, Title = "Modifier Signature", TargetType=typeof(Signature1) },
                    new Menu1MenuItem { Id = 5, Title = "Fermer",  TargetType=typeof(Quitter)},
                    new Menu1MenuItem { Id = 6, Title = "Deconnexion",  TargetType=typeof(Deconnexion)},
                    });

                }
                else if (c.Type == 1)
                {
                    MenuItems = new ObservableCollection<Menu1MenuItem>(new[]
                    {
                                             new Menu1MenuItem {Id = 0, Title = "Frais avant Deplacement" , TargetType=typeof(AvecFrais1)},
                    new Menu1MenuItem { Id = 1, Title = "Frais apres Deplacement" , TargetType=typeof(AvecFraisConfirmation)},
                    new Menu1MenuItem { Id = 2, Title = "Ouvrir",  TargetType=typeof(Fichiers)},
                        new Menu1MenuItem { Id = 3, Title = "Modifier Utilisateur" , TargetType=typeof(Compte_Utilisateur)},
                    new Menu1MenuItem { Id = 4, Title = "Envoyer par courriel", TargetType=typeof(ParMail) },
                    new Menu1MenuItem { Id = 5, Title = "Modifier Signature", TargetType=typeof(Signature1) },
                    new Menu1MenuItem { Id = 6, Title = "Fermer" , TargetType=typeof(Quitter)},
                    new Menu1MenuItem { Id = 7, Title = "Deconnexion",  TargetType=typeof(Deconnexion)}, }

                /**TODO CHANGER LES PAGES ICI */
                );
                }
                else
                {
                    MenuItems = new ObservableCollection<Menu1MenuItem>(new[]
                    {
                new Menu1MenuItem { Id = 0, Title = "SF avant Deplacement" , TargetType=typeof(SansFrais1)},
                    new Menu1MenuItem { Id = 1, Title = "Modifier Utilisateur" , TargetType=typeof(Compte_Utilisateur)},
                    new Menu1MenuItem { Id = 2, Title = "Ouvrir",  TargetType=typeof(Fichiers)},
                    new Menu1MenuItem { Id = 3, Title = "Envoyer par courriel", TargetType=typeof(ParMail) },
                    new Menu1MenuItem { Id = 4, Title = "Modifier Signature", TargetType=typeof(Signature1) },
                    new Menu1MenuItem { Id = 5, Title = "Fermer",  TargetType=typeof(Quitter)},
                    new Menu1MenuItem { Id = 6, Title = "Deconnexion",  TargetType=typeof(Deconnexion)},
                    });
                    /**TODO CHANGER LES PAGES ICI */
                }
            }
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName]string propertyName = "") =>
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }

}
