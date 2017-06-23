

using System;
using SignaturePad.Forms;
using Xamarin.Forms;

public class CaptureSignature : ContentPage
{
    SignaturePadView signaturePadView;

    public CaptureSignature()
    {
        signaturePadView = new SignaturePadView();

        signaturePadView.BackgroundColor = Color.Yellow;
        signaturePadView.SignatureLineColor = Color.Black;
        signaturePadView.HeightRequest = 150;
        signaturePadView.WidthRequest = 240;
        signaturePadView.StrokeColor = Color.Black;
        signaturePadView.StrokeWidth = 2;
        signaturePadView.CaptionText = "Please sign above";
        signaturePadView.ClearText = "Clear";
        signaturePadView.ClearTextColor = Color.Red;

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
                signaturePadView,
                btnDone
            }
        };
    }

    private void BtnDone_Clicked(object sender, EventArgs e)
    {
        
    }
}