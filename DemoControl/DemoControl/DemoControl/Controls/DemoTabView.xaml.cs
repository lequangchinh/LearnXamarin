using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoControl.Controls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DemoTabView : ContentPage
	{
		public DemoTabView ()
		{
			InitializeComponent ();

            Content = new TableView
            {
                Root = new TableRoot
                {
                    new TableSection("Ring")
                    {
                      // TableSection constructor takes title as an optional parameter
                      new SwitchCell { Text = "New Voice Mail" },
                      new SwitchCell { Text = "New Mail", On = true }
                    }
                },
                Intent = TableIntent.Settings
            };
        }
    }
}