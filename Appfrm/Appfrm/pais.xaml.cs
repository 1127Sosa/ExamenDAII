using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Appfrm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class pais : ContentPage
    {
        public pais()
        {
            InitializeComponent();
        }

        private void getpais_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new paisget());
        }

        private void deletepais_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new deletepais());
        }

        private void GetPais_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new getpais());
        }

        private void putPais_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new putpais());
        }
    }
}