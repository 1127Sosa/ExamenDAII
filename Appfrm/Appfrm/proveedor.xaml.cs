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
    public partial class proveedor : ContentPage
    {
        public proveedor()
        {
            InitializeComponent();
        }

        private void getproveedor_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new provget());
        }

        private void deleteprov_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new deleteprov());
        }

        private void Getpro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new getproveedor());
        }

        private void putproveedor_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new putproveedor());
        }
    }
}