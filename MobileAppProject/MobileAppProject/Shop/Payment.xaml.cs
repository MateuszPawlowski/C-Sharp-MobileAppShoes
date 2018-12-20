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
	public partial class Payment : ContentPage
	{
		public Payment ()
		{
			InitializeComponent ();
		}

        // Payment Method
        private async void Payment_Made(object sender, EventArgs e)
        {
              var answer = await DisplayAlert("Make Sure!", "Are you sure you want to buy all ?", "Yes", "No");
              Debug.WriteLine("Answer: " + answer);
              if(answer == true)
              {
                  await Navigation.PushAsync(new MainPage());
              }
        }

        // Go back a page
        private async void BackPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Shop());
        }

    }
}