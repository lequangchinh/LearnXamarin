using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoNavigation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ContentPage content = new ContentPage();// ?????

            Button btnButton = new Button
            {
                Text = "New Button",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            btnButton.Clicked += async (sender, args) => await Navigation.PushAsync(content);

            Content = new StackLayout
            {
                Children =
                {
                    btnButton
                }
            };
        }
    }
}
