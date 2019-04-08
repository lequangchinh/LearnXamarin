using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoStyle
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DemoDynamicStyle : ContentPage
	{
        bool originalStyle = true;
		public DemoDynamicStyle ()
		{
			InitializeComponent ();
            Resources["stySearchBar"] = Resources["styBlueSearchBar"];
		}
        void OnChangeStyleButtonClicked(object sender, EventArgs e)
        {
            if (originalStyle)
            {
                Resources["stySearchBar"] = Resources["styGreenSearchBar"];
                originalStyle = false;
            }
            else
            {
                Resources["stySearchBar"] = Resources["styBlueSearchBar"];
                originalStyle = true;
            }
        }
    }
}