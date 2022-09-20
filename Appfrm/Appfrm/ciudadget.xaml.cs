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
    public partial class ciudadget : ContentPage
    {
        private string url = "https://desfrlopez.me/asosa/api/ciudad/";
        public ciudadget()
        {
            InitializeComponent();
        }

        private async Task crearPersonaAsync()
        {
            using (var httpClient = new HttpClient())
            {

                Classciudad x = new Classciudad()
                {
                    idPais = idPais.Text,
                    nombre_ciudad = nombre_ciudad.Text,
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

                idPais.Text = "";
                nombre_ciudad.Text = "";

            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            crearPersonaAsync();
        }
    }
}