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

        // Tap adidas
        private async void Adidas_Tap(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Adidas());
        }
        // Click adidas
        private async void Adidas_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Adidas());
        }

        // Tap puma
        private async void Puma_Tap(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Puma());
        }
        // Click puma
        private async void Puma_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Puma());
        }

        // Tap nike
        private async void Nike_Tap(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Nike());
        }
        // Click nike
        private async void Nike_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Nike());
        }

        // Tap converse
        private async void Converse_Tap(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Converse());
        }
        // Click converse
        private async void Converse_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Converse());
        }

        // Tap reebok
        private async void Reebok_Tap(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Reebok());
        }
        // Click reebok
        private async void Reebok_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Reebok());
        }

        // Tap timberland
        private async void Timberland_Tap(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Timberland());
        }
        // Click timberland
        private async void Timberland_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Timberland());
        }

        // Go back home
        private async void HomePage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

    }
}