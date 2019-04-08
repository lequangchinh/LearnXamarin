using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace DemoStyle
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //MainPage = new DemoDynamicStyle();
            // MainPage = new DemoInheritanceStyle();
            // MainPage = new DemoExplicitStyle();
            // MainPage = new DemoImplicitStyle();
            MainPage = new MainPage();
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
