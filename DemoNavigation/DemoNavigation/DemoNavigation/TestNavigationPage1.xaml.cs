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
	public partial class TestNavigationPage1 : ContentPage
	{
		public TestNavigationPage1 ()
		{
			InitializeComponent ();
		}
        

        async void OnNextPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TestNavigationPage2());
        }
    }
}