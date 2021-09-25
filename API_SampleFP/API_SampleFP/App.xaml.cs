using API_SampleFP.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace API_SampleFP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CurrencyPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
