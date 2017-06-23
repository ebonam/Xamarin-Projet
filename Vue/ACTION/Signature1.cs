using SignaturePad.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace XamarinFinal.Vue
{
    public class Signature1 : ContentPage
    {
        SignaturePadView _signature;
        public Signature1()
        {


            _signature = new SignaturePadView();
            _signature.BackgroundColor = Color.White;
            _signature.SignatureLineColor = Color.Black;
            _signature.HeightRequest = 150;
            _signature.WidthRequest = 240;
            _signature.StrokeColor = Color.Black;
            _signature.StrokeWidth = 2;
            _signature.CaptionText = "Mettre à jour signature";
            _signature.ClearText = "Vider ";
            _signature.ClearTextColor = Color.Black;

            Button btnDone = new Button
            {
                HorizontalOptions = LayoutOptions.Center,
                Text = "Save"
            };
            btnDone.Clicked += BtnDone_Clicked;

            Content = new StackLayout
            {
                Spacing = 10,
                Children = {
                     new Label { Text = "Mettre ajour la signature" },
                    _signature,
                btnDone
            }
            };
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDone_Clicked(object sender, EventArgs e)
      {
        // Stream s=   _signature.SignaturePadCanvas.GetImageStreamAsync(SignatureImageFormat.Png);    
        //    _signature.GetImageStreamAsync(SignatureImageFormat.Png);

        }
    }
}