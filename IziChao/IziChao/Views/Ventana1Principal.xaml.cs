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
    public partial class Ventana1Principal : ContentPage
    {
        public Ventana1Principal()
        {
            InitializeComponent();
        }

        public async void BtnV1IniciarS_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Ventana2InicioS());   
        }

        private async void BtnV1CrearC_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Ventana3CrearCuenta());
        }
    }
}