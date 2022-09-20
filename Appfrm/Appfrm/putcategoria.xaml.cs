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
    public partial class putcategoria : ContentPage
    {
        private string url = "https://desfrlopez.me/asosa/api/categoria";
        public putcategoria() { InitializeComponent(); }
        private async Task actualizarCategoriaAsync()
        {
            using (var httpClient = new HttpClient())
            {
                Classcat x = new Classcat() 
                { idcategoria = int.Parse(idcategoria.Text), 
                    nombre = nombre.Text, 
                    abreviacion = abreviacion.Text };
                url = url + "/" + x.idcategoria; 
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
                abreviacion.Text = "";              
            }         
        }          
        private void Button_Clicked(object sender, EventArgs e)         
        {             
            actualizarCategoriaAsync();         
        }          
        private void idcategoria_TextChanged(object sender, TextChangedEventArgs e)         
        {          
        }
            
    }
}