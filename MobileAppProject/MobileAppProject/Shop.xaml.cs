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
        private async void Adidas_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Adidas());
        }

        private async void Puma_Tap(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Puma());
        }
        private async void Puma_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Puma());
        }

        private async void Nike_Tap(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Nike());
        }
        private async void Nike_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Nike());
        }

        private async void Converse_Tap(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Converse());
        }
        private async void Converse_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Converse());
        }

        private async void Reebok_Tap(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Reebok());
        }
        private async void Reebok_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Reebok());
        }

        private async void Timberland_Tap(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Timberland());
        }
        private async void Timberland_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Timberland());
        }
    }
}