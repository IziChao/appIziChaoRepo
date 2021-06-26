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
    public partial class VentanaFinalizarCompra : ContentPage
    {
        public VentanaFinalizarCompra()
        {
            InitializeComponent();
        }

        private async void BtnSalir_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Ventana1Principal());
        }

        private async void BtnOtraCompra_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new VentanaScanner());
        }
    }
}