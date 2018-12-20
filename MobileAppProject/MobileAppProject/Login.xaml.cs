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
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
		}

        // Login
        private async void Log_In(object sender, EventArgs e)
        {
            await DisplayAlert("Login Successful !", "You have logged in.", "Ok");
            await Navigation.PushAsync(new MainPage());
        }

        // Tap for help
        private async void Trouble_Tap(object sender, EventArgs e)
        {
            await DisplayAlert("ERROR 404", "There seems  to be a error, our team will " +
                "try and contact you as soon as the error is resolved.", "Ok");
        }

        // Facebook login
        private async void Facebook_Tap(object sender, EventArgs e)
        {
            await DisplayAlert("Login Successful !", "You have logged in.", "Ok");
            await Navigation.PushAsync(new MainPage());
        }

        // Go back home
        private async void HomePage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

    }
}