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
    public partial class getproveedor : ContentPage
    {
        private string url = "https://desfrlopez.me/asosa/api/proveedor";


        public getproveedor()
        {
            InitializeComponent();
            getpro();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            getpro();
        }

        private async Task getpro()
        {
            using (var httpClient = new HttpClient())
            {

                var response = await httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    List<Classprov> contenido = JsonConvert.DeserializeObject<List<Classprov>>(content);

                    string tempRes = "";

                    for (int i = 0; i < contenido.Count; i++)
                    {

                        tempRes = tempRes + "idProveedor: " + contenido[i].idProveedor + " nombre: " + contenido[i].nombre + " telefono: " + contenido[i].telefono + " correo: " + contenido[i].correo + " idciudad: " + contenido[i].idciudad + "\n";

                    }

                    resultado.Text = tempRes;
                }
                else
                {
                    resultado.Text = "Carga Fallida de Proveedores";
                }




            }
        }
    }
}