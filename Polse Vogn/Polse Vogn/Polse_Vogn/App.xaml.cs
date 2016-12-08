using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Polse_Vogn.Views;
using Xamarin.Forms;

namespace Polse_Vogn
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PolseListPage();
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
