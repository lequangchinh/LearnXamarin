using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoNavigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TestNavigationPage2a : ContentPage
	{
		public TestNavigationPage2a ()
		{
			InitializeComponent ();
		}
        async void OnPreviousPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        async void OnNextPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TestNavigationPage3());
        }
    }
}