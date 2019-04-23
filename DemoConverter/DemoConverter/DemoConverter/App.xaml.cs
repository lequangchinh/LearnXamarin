using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DemoConverter.View;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace DemoConverter
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new User();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
