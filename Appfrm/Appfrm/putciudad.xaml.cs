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
    public partial class putciudad : ContentPage
    {
        private string url = "https://desfrlopez.me/asosa/api/ciudad";
        public putciudad()
        {
            InitializeComponent();
        }
        private async Task actualizarciudadAsync()
        {
            using (var httpClient = new HttpClient())
            {
                Classciudad x = new Classciudad()
                {
                    idciudad = int.Parse(idciudad.Text),
                    idPais = idPais.Text,
                    nombre_ciudad = nombre_ciudad.Text
                };
                url = url + "/" + x.idciudad;
                var body = x.toJson();
                HttpContent c = new StringContent(body, Encoding.UTF8, "application/json");
                var response = await httpClient.PutAsync(url, c);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    resultado.Text = "Actulizacion Exitosa";
                }
                else
                {
                    resultado.Text = "Actulizacion Fallida";
                }
                idPais.Text = "";
                nombre_ciudad.Text = "";
            }
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            actualizarciudadAsync();
        }
        private void idciudad_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}