using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using IziChao.Modelo;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.IO;
using RestSharp;

namespace IziChao.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ventana3CrearCuenta : ContentPage
    {
        public Ventana3CrearCuenta()
        {
            InitializeComponent();

        }

        private  async Task<bool>  validarFormulario()
        {
            //Valida si el valor en el Entry se encuentra vacio o es igual a Null
            if (String.IsNullOrWhiteSpace(txtdni.Text) || String.IsNullOrWhiteSpace(txtNombre.Text) ||  String.IsNullOrWhiteSpace(txtApe.Text) || String.IsNullOrWhiteSpace(txtContra.Text))
            {
                await this.DisplayAlert("Advertencia", "Todos los campos son obligatorios.", "OK");
                return false;
            }
            //Valida que solo se ingresen letras
            if (txtApe.Text.ToCharArray().Any(Char.IsDigit) || txtNombre.Text.ToCharArray().Any(Char.IsDigit))
            {
                await this.DisplayAlert("Advertencia", "Los nombres y apellidos no deben contener números", "OK");
                return false;
            }


            //Valida si se ingresan caracteres especiales
            string caractEspecial = @"^[^ ][a-zA-Z ]+[^ ]$";
           
            bool resultado = Regex.IsMatch(txtNombre.Text, caractEspecial, RegexOptions.IgnoreCase);
            bool resultado1 = Regex.IsMatch(txtApe.Text, caractEspecial, RegexOptions.IgnoreCase);
            bool resultado2 = Regex.IsMatch(txtdni.Text, caractEspecial, RegexOptions.IgnoreCase);
            
            if (!resultado )
            {
                await this.DisplayAlert("Advertencia", "No se aceptan caracteres especiales en el campo Nombres, intente de nuevo.", "OK");
                return false;
            }

            else  if (!resultado1)
            {
                await this.DisplayAlert("Advertencia", "No se aceptan caracteres especiales en el campo Apellidos, intente de nuevo.", "OK");
                return false;
            }

           else  if (resultado2)
            {
                await this.DisplayAlert("Advertencia", "No se aceptan caracteres especiales en el campo DNI, intente de nuevo.", "OK");
                return false;
            }


            //Valida que solo se ingresen numeros
            if (!txtdni.Text.ToCharArray().All(Char.IsDigit))
            {
                await this.DisplayAlert("Advertencia", "El formato del DNI es incorrecto, solo se aceptan numeros.", "OK");
                return false;
            }
            else if (txtdni.Text.Length != 8)
            {
                await this.DisplayAlert("Advertencia", "El número de DNI no es válido", "OK");
                return false;
            }
           
            

            if (txtContra.Text.Length < 6)
            {
                await this.DisplayAlert("Advertencia", "La contraseña debe tener 6 caracteres como mínimo", "OK");
                return false;
            } 
            return true;
        }

        

       

         private async void BtnIngresar_Clicked(object sender, EventArgs e)
        {
           
            if (await  validarFormulario())
            {
                WebClient cliente = new WebClient();
                login user = new login
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApe.Text,
                    Id = Convert.ToInt32(txtdni.Text),
                    Contra = txtContra.Text
                };


                var parametros = new System.Collections.Specialized.NameValueCollection();
                parametros.Add("Nombre", user.Nombre);
                parametros.Add("Apellido", user.Apellido);
                parametros.Add("Id", user.Id.ToString());
                parametros.Add("Contra", user.Contra);
                //await Navigation.PushModalAsync(new VentanaScanner());
                Uri RequestUri = new Uri("https://app-a0114080-d095-4516-bd24-d2072f0e5755.cleverapps.io/insertar.php");

                cliente.UploadValuesAsync(RequestUri, "POST", parametros);
                txtApe.Text = "";
                txtNombre.Text = "";
                txtdni.Text = "";
                txtContra.Text = "";

                await DisplayAlert("Mensaje", "Cuenta creada exitosamente", "OK");
                string usuario = user.Nombre + " " +  user.Apellido;
                await Navigation.PushModalAsync(new VentanaScanner(usuario));

            }













        }

    }
}