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
    public partial class categoria : ContentPage
    {
        public categoria()
        {
            InitializeComponent();
        }

        private void getcategoria_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new catget());
        }

        private void deletecat_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new catdelete());
        }

        private void GetCate_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new getcategoria());
        }

        private void putcategoria_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new putcategoria());
        }
    }
}