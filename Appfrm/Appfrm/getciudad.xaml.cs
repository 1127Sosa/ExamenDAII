using Newtonsoft.Json;
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
    public partial class getciudad : ContentPage
    {
        private string url = "https://desfrlopez.me/asosa/api/ciudad";


        public getciudad()
        {
            InitializeComponent();
            getCiud();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            getCiud();
        }

        private async Task getCiud()
        {
            using (var httpClient = new HttpClient())
            {

                var response = await httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    List<Classciudad> contenido = JsonConvert.DeserializeObject<List<Classciudad>>(content);

                    string tempRes = "";

                    for (int i = 0; i < contenido.Count; i++)
                    {

                        tempRes = tempRes + "idciudad: " + contenido[i].idciudad + " idPais: " + contenido[i].idPais + " nombre_ciudad: " + contenido[i].nombre_ciudad + "\n";

                    }

                    resultado.Text = tempRes;
                }
                else
                {
                    resultado.Text = "Carga Fallida de Ciudades";
                }




            }
        }
    }
}