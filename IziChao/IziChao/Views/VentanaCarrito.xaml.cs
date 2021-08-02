using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IziChao.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VentanaCarrito : ContentPage
    {
        public VentanaCarrito()
        {
            InitializeComponent();
        }

        private async void BtnOtroP_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushModalAsync(new VentanaScanner());
        }

        private async void BtnPagar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new VentanaPago());
        }

    }
}