using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoPassingData
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public MainPage(string date)
        {
            InitializeComponent();
            lblDate.Text = date;
        }
        async void OnNextPageButtonClicked(object sender, EventArgs e)
        {
            var contact = new Contact
            {
                Name = "Jane Doe",
                Age = 30,
                Occupation = "Developer",
                Country = "USA"
            };

            var secondPage = new SecondPage();
            secondPage.BindingContext = contact;
            await Navigation.PushAsync(secondPage);
        }
    }
}
