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
    public partial class getproducto : ContentPage
    {
        private string url = "https://desfrlopez.me/asosa/api/producto";


        public getproducto()
        {
            InitializeComponent();
            getproduc();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            getproduc();
        }

        private async Task getproduc()
        {
            using (var httpClient = new HttpClient())
            {

                var response = await httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    List<Classprod> contenido = JsonConvert.DeserializeObject<List<Classprod>>(content);

                    string tempRes = "";

                    for (int i = 0; i < contenido.Count; i++)
                    {

                        tempRes = tempRes + "idproducto: " + contenido[i].idproducto + " nombrecomercial: " + contenido[i].nombrecomercial + " idProveedor: " + contenido[i].idProveedor + " idcategoria: " + contenido[i].idcategoria + "\n";

                    }

                    resultado.Text = tempRes;
                }
                else
                {
                    resultado.Text = "Carga Fallida de Productos";
                }




            }
        }
    }
}