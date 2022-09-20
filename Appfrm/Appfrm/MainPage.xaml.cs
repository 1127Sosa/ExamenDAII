using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Appfrm
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btncategoria_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new categoria());
        }

        private void btnpais_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new pais());
        }

        private void btnciudad_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ciudad());
        }

        private void btnproveedor_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new proveedor());
        }

        private void btnproducto_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new producto());
        }

        private void btnespecial_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new getespecial());
        }
    }
}
