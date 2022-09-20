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
    public partial class producto : ContentPage
    {
        public producto()
        {
            InitializeComponent();
        }

        private void getproducto_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new prodget());
        }

        private void deleteprod_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new deleteprod());
        }

        private void Getprod_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new getproducto());
        }

        private void putproducto_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new putproducto());
        }
    }
}