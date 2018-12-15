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
	public partial class ContactUs : ContentPage
	{
		public ContactUs ()
		{
			InitializeComponent ();
		}

        private async void Contact_Click(object sender, EventArgs e)
        {
            await DisplayAlert("Thank you!", "Thank you for contacting, " +
                "Our team will comeback as soon as possible to you", "Ok");
            await Navigation.PushAsync(new MainPage());
        }
    }
}