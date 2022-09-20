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
    public partial class putproducto : ContentPage
    {
        private string url = "https://desfrlopez.me/asosa/api/producto";
        public putproducto()
        {
            InitializeComponent();
        }
        private async Task actualizarproductoAsync()
        {
            using (var httpClient = new HttpClient())
            {
                Classprod x = new Classprod()
                {
                    idproducto = int.Parse(idproducto.Text),
                    nombrecomercial = nombrecomercial.Text,
                    idProveedor = idProveedor.Text,
                    idcategoria = idcategoria.Text
                };
                url = url + "/" + x.idproducto;
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
                nombrecomercial.Text = "";
                idProveedor.Text = "";
                idcategoria.Text = "";
            }
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            actualizarproductoAsync();
        }
        private void idproducto_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}