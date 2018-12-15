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
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
		}

        private async void Shop_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Shop());
        }

        private async void Login_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }

        private async void AboutUs_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutUs());
        }

        private async void Contact_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContactUs());
        }
    }
}