﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IziChao.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ventana2InicioS : ContentPage
    {
        public Ventana2InicioS()
        {
            InitializeComponent();
        }

        private async  void BtnIngresar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new VentanaScanner());
        }

       
    }
}