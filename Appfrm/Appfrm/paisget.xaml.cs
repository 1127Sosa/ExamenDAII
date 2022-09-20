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
    public partial class paisget : ContentPage
    {
        private string url = "https://desfrlopez.me/asosa/api/pais/";
        public paisget()
        {
            InitializeComponent();
        }

        private async Task crearPersonaAsync()
        {
            using (var httpClient = new HttpClient())
            {

                Classpais x = new Classpais()
                {
                    nombre_pais = nombre_pais.Text,
                    codigo_de_area = codigo_de_area.Text,
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

                nombre_pais.Text = "";
                codigo_de_area.Text = "";

            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            crearPersonaAsync();
        }
    }
}