using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Cinefolis.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Cinefolis
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();


            MainPage = new Cinefolis.Views.View1();
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
