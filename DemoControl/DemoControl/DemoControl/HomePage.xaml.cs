using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoControl.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoControl
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
		}
        async void OnDemoLayoutButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DemoLayout());
        }
        async void OnDemoSliderButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DemoSlider());
        }
        async void OnDemoTextButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DemoText());
        }
        async void OnDemoImageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DemoImage());
        }
        async void OnDemoBoxViewButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DemoBoxview());
        }
        async void OnDemoDatePickerButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DemoDatePicker());
        }
        async void OnDemoTableViewButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DemoTabView());
        }
    }
}