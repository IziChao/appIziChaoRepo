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
    public partial class VentanaPago : ContentPage
    {
        public VentanaPago()
        {
            InitializeComponent();
        }

        private async void BtnPagarCompra_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new VentanaFinalizarCompra());
        }
    }
}