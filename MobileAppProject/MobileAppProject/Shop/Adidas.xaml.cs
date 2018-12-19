using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileAppProject
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Adidas : ContentPage
	{
		public Adidas ()
		{
			InitializeComponent ();
		}

        float counter;


        private async void AddedCart(object sender, EventArgs e)
        {
            counter++;
            await DisplayAlert("Added To Cart", "Your Cart has been updated", "Ok");
        }

        async void Bought(object sender, EventArgs e)
        {
            var answer = await DisplayAlert("Are you sure?", "Are you sure you want to buy this product?", "Yes", "No");
            Debug.WriteLine("Answer: " + answer);
            if(answer == true)
            {
                await Navigation.PushAsync(new MainPage());
            }
           
        }


    }
}