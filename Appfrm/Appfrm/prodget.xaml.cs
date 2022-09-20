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
    public partial class prodget : ContentPage
    {
        private string url = "https://desfrlopez.me/asosa/api/producto/";
        public prodget()
        {
            InitializeComponent();
        }

        private async Task crearPersonaAsync()
        {
            using (var httpClient = new HttpClient())
            {

                Classprod x = new Classprod()
                {
                    nombrecomercial = nombrecomercial.Text,
                    idProveedor = idProveedor.Text,
                    idcategoria = idcategoria.Text,
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

                nombrecomercial.Text = "";
                idProveedor.Text = "";
                idcategoria.Text = "";

            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            crearPersonaAsync();
        }
    }
}