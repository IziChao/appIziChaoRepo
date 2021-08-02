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
    public partial class Ventana5Descripcion : ContentPage
    {
        public Ventana5Descripcion()
        {
            
            InitializeComponent();
            
        }

        private async void BtnCarrito_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new VentanaCarrito());

            
        }

        private async void BtnAgregar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new VentanaCarrito());
        }

        private async void BtnBuscar_Clicked(object sender, EventArgs e)
        {
            
        }


    }
}