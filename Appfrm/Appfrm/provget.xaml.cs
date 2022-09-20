using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Appfrm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class provget : ContentPage
    {
        private string url = "https://desfrlopez.me/asosa/api/proveedor/";
        public provget()
        {
            InitializeComponent();
        }

        private async Task crearPersonaAsync()
        {
            using (var httpClient = new HttpClient())
            {

                Classprov x = new Classprov()
                {
                    nombre = nombre.Text,
                    telefono = telefono.Text,
                    correo = correo.Text,
                    idciudad = idciudad.Text,
                };

                var body = x.toJson();
                HttpContent c = new StringContent(body, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync(url, c);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    resultado.Text = "Insercion Exitosa";
                }
                else
                {
                    resultado.Text = "Insercion Fallida";
                }

                nombre.Text = "";
                telefono.Text = "";
                correo.Text = "";
                idciudad.Text = "";

            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            crearPersonaAsync();
        }
    }
}