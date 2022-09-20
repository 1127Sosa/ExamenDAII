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
    public partial class deleteprov : ContentPage
    {
        private string url = "https://desfrlopez.me/asosa/api/proveedor";
        public deleteprov()
        {
            InitializeComponent();
        }

        private async Task borrarPersonaAsync()
        {
            using (var httpClient = new HttpClient())
            {

                url = url + "/" + idProveedor.Text;
                var response = await httpClient.DeleteAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    resultado.Text = "Borrado Exitoso";
                }
                else
                {
                    resultado.Text = "Borrado Fallido";
                }

                idProveedor.Text = "";


            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            borrarPersonaAsync();
        }
    }
}