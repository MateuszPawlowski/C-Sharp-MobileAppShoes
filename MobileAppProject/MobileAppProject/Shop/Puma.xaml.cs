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
	public partial class Puma : ContentPage
	{
		public Puma ()
		{
			InitializeComponent ();
		}

        // Add to Cart
        private async void AddedCart(object sender, EventArgs e)
        {
            await DisplayAlert("Added To Cart", "Your Cart has been updated", "Ok");
        }

        // Bought something
        private async void Bought(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Payment());
        }

        // Go back a page
        private async void BackPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Shop());
        }

    }
}