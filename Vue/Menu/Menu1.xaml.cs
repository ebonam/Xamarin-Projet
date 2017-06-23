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
    public partial class Menu1 : MasterDetailPage
    {
        private  static readonly Menu1 instance = new Menu1();
        
        public static Menu1 Instance
        {
            get
            {
                return instance;
            }
        }

        public void NewInstance()
        {
            InitializeComponent();


            MasterPage.ListView.ItemSelected += ListView_ItemSelected;

            var item= new Menu1MenuItem();
        item.TargetType = typeof(Fichiers);
            var page = (Page)Activator.CreateInstance(typeof(DAUVP_Vue));// item.TargetType);
        page.Title = "braw";
            Detail = new NavigationPage(page);

        MasterPage.ListView.SelectedItem = null;
            IsPresented = false;
 }

    private Menu1()
        {
            InitializeComponent();

         
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
         /*   var page = (Page)Activator.CreateInstance(typeof(DAUVP_Vue));// item.TargetType);
            page.Title = " ";
            Detail = new NavigationPage(page);

            MasterPage.ListView.SelectedItem = null;
            IsPresented = false;
  */
    }

        public void Change(Type t,string str)
        {

            var page = (Page)Activator.CreateInstance(t);
            page.Title = str;
            Detail = new NavigationPage(page);

        

        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Menu1MenuItem;
            if (item == null)
                return;
            if (item.Title == "Deconnexion") { App.Instance.ToCarrousel(); return; }
            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;
            Detail = new NavigationPage(page);
            MasterPage.ListView.SelectedItem = null;
            IsPresented = false;
        }
    }
}

