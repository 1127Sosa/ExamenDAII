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
    public partial class getcategoria : ContentPage
    {
        private string url = "https://desfrlopez.me/asosa/api/categoria";


        public getcategoria()
        {
            InitializeComponent();
            getCate();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            getCate();
        }

        private async Task getCate()
        {
            using (var httpClient = new HttpClient())
            {

                var response = await httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    List<Classcat> contenido = JsonConvert.DeserializeObject<List<Classcat>>(content);

                    string tempRes = "";

                    for (int i = 0; i < contenido.Count; i++)
                    {

                        tempRes = tempRes + "idcategoria: " + contenido[i].idcategoria + " nombre: " + contenido[i].nombre + " abreviacion: " + contenido[i].abreviacion + "\n";

                    }

                    resultado.Text = tempRes;
                }
                else
                {
                    resultado.Text = "Carga Fallida de Categorias";
                }




            }
        }
    }
}