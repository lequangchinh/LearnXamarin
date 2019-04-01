using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoControl.Controls.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoControl.Controls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DemoText : ContentPage
	{
		public DemoText ()
		{
			InitializeComponent ();
        }

        async void OnTextEntryButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new TextEntryDemo()));
        }
        async void OnTextEditorButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new TextEditorDemo()));
        }
    }
}