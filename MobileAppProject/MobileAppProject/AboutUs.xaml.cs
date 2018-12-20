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
	public partial class AboutUs : ContentPage
	{
		public AboutUs ()
		{
			InitializeComponent ();
        }

        // Go back to home
        private async void HomePage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

    }
}