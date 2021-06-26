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
    public partial class VentanaScanner : ContentPage
    {
        public VentanaScanner()
        {
            InitializeComponent();
        }

        private async void BtnScanner_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Ventana5Descripcion());
        }

    }
}