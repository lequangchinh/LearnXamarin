using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoControl.Controls.Image;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoControl.Controls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DemoImage : ContentPage
	{
		public DemoImage ()
		{
			InitializeComponent ();
		}
        async void OnDemoLocalImageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ImageLocal());
        }
        
    }
}