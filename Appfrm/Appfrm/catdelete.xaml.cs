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
    public partial class catdelete : ContentPage
    {

        private string url = "https://desfrlopez.me/asosa/api/categoria";
        public catdelete()
        {
            InitializeComponent();
        }

        private async Task borrarPersonaAsync()
        {
            using (var httpClient = new HttpClient())
            {

                url = url + "/" + idcategoria.Text; 
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

                idcategoria.Text = "";


            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            borrarPersonaAsync();
        }
    }
}