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
    public partial class ciudad : ContentPage
    {
        public ciudad()
        {
            InitializeComponent();
        }

        private void getciudad_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ciudadget());
        }

        private void deleteciudad_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new deleteciudad());
        }

        private void GetCiud_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new getciudad());
        }

        private void putciudad_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new putciudad());
        }
    }
}