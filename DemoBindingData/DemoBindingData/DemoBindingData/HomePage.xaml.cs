using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoBindingData
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
		}
        async void OnDemoBindingContexClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DemoBindingContex());
        }

        async void OnDemoNoBindingContexClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DemoNoBindingContex());
        }
    }
}