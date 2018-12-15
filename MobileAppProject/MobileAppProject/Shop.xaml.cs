using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileAppProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Shop : ContentPage
    {
        public Shop()
        {
            InitializeComponent();
        }

        private async void Adidas_Tap(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Adidas());
        }

        private async void Puma_Tap(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Puma());
        }

 
    }
}