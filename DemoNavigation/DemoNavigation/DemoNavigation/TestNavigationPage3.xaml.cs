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
	public partial class TestNavigationPage3 : ContentPage
	{
		public TestNavigationPage3 ()
		{
			InitializeComponent ();
		}
        async void OnPreviousButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        void OnReturnRootButtonClicked(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
        void OnInsertPage2aButtonClicked(object sender, EventArgs e)
        {
            var pgPage2a = Navigation.NavigationStack.FirstOrDefault(p => p.Title == "Page 2a");
            if(pgPage2a == null)
            {
                Navigation.InsertPageBefore(new TestNavigationPage2a(), this);
            }
            
        }
        void OnRemovePage2ButtonClicked(object sender, EventArgs e)
        {
            var pgPage2 = Navigation.NavigationStack.FirstOrDefault(p => p.Title == "Page 2");
            if(pgPage2 != null)
            {
                Navigation.RemovePage(pgPage2);
            }
        }

    }
}