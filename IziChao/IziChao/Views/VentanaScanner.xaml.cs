using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace IziChao.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VentanaScanner : ContentPage
    {
        public VentanaScanner()
        {
            InitializeComponent();

        }

        private async void BtnScanner_Clicked(object sender, EventArgs e)
        {
            try
            {
                var scanner = new ZXing.Mobile.MobileBarcodeScanner();
                scanner.TopText = "Enfoca el código QR dentro del cuadro";
                scanner.BottomText = ":)";

                var result = await scanner.Scan();

                if (result != null)
                {
                    txtResultado.Text = result.Text;
                    await Navigation.PushModalAsync(new Ventana5Descripcion());
                }

            }catch(Exception ex)
            {
                await DisplayAlert("Error ", ex.Message.ToString(), "Ok");
            }
            
        }

    }
}