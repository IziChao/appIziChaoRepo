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
    public partial class Ventana3CrearCuenta : ContentPage
    {
        public Ventana3CrearCuenta()
        {
            InitializeComponent();
        }

        private async void BtnCrearCuenta_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new VentanaScanner());
        }
    }
}