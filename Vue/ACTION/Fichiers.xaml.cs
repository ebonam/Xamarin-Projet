using Android.OS;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFinal.BDD;

namespace XamarinFinal.Vue
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Fichiers : ContentPage
    {

        Containeur c;
        public Fichiers()
        {
            c = Containeur.Instance;
            InitializeComponent();
            //   List<FileInterface> foo = new List<FileInterface>();

            FileName.Text = DateTime.Now.ToString();
            List<FileInterface> foo = c.sql.getAllFile(c.utilisateur);

            List<string> d = new List<string>();
            if (foo.Count != 0)
            {
                foreach (FileInterface f in foo)
                {
                    d.Add(f.ToString());

                }
                listView.ItemsSource = d;// new[] { "a", "1", "b","2", "c","3" };
            }
            else
            {
                listView.ItemsSource = new[] { " Rien" };
            }
        }

        string Selected = "";
        public void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return; // has been set to null, do not 'process' tapped event
         //   DisplayAlert("Tapped", e.SelectedItem + " row was tapped", "OK");
            Selected = "" + e.SelectedItem.ToString();
            // ((ListView)sender).SelectedItem = null; // de-select the row
        }
        public void OnCellClicked(object sender, EventArgs e)
        {
            var b = (Button)sender;
            var t = b.CommandParameter;
          //  DisplayAlert("clicked", "clicked" + t, "OK");
        }
        private void Button_Cancel(object sender, EventArgs e)
        {
            c.PageType();
        }


        private void Button_Create(object sender, EventArgs e)
        {
            if (_Picker.SelectedItem == null) { }
            else
            {
                if(this.FileName.Text!=""){
                    if (_Picker.SelectedItem.ToString() == "DAUVP")
                    {

                        c.New(0, FileName.Text);
                    }
                    else if (_Picker.SelectedItem.ToString() == "Avec Frais") { c.New(1, FileName.Text); }
                    else if (_Picker.SelectedItem.ToString() == "Sans Frais") { c.New(2, FileName.Text); }
                    //c.New();
                    App.Instance.ToMenu();
                }
            }
        }
        private void Button_Supprimer(object sender, EventArgs e)
        {
            string[] res = Selected.Split('/');
            if (res.Length > 0)
            {
                int type = int.Parse(res[1]);
                int id = int.Parse(res[0]);
                c.Delete(type, id);
                
               //listView.ItemsSource
            }
        }
        private void Button_Open(object sender, EventArgs e)
        {
            string[] res = Selected.Split('/');
            if (res.Length > 1)
            {
                int type = int.Parse(res[1]);
                int id = int.Parse(res[0]);
                DisplayAlert("clicked", "clicked" + id, "OK");
                c.Open(type, id);
                c.PageType();
            }
        }
    }
}