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
    public partial class putproveedor : ContentPage
    {
        private string url = "https://desfrlopez.me/asosa/api/proveedor";
        public putproveedor()
        {
            InitializeComponent();
        }
        private async Task actualizarproveedorAsync()
        {
            using (var httpClient = new HttpClient())
            {
                Classprov x = new Classprov()
                {
                    idProveedor = int.Parse(idProveedor.Text),
                    nombre = nombre.Text,
                    telefono = telefono.Text,
                    correo = correo.Text,
                    idciudad = idciudad.Text
                };
                url = url + "/" + x.idProveedor;
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
                nombre.Text = "";
                telefono.Text = "";
                correo.Text = "";
                idciudad.Text = "";
            }
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            actualizarproveedorAsync();
        }
        private void idproveedor_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}