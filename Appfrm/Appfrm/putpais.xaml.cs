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
    public partial class putpais : ContentPage
    {
        private string url = "https://desfrlopez.me/asosa/api/pais";
        public putpais() 
        { 
            InitializeComponent(); 
        }
        private async Task actualizarpaisAsync()
        {
            using (var httpClient = new HttpClient())
            {
                Classpais x = new Classpais()
                {
                    idPais = int.Parse(idPais.Text),
                    nombre_pais = nombre_pais.Text,
                    codigo_de_area = codigo_de_area.Text
                };
                url = url + "/" + x.idPais;
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
                nombre_pais.Text = "";
                codigo_de_area.Text = "";
            }
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            actualizarpaisAsync();
        }
        private void idpais_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}