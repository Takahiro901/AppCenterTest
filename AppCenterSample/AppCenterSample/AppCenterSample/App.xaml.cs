using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AppCenterSample
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new AppCenterSample.MainPage();
		}

		protected override void OnStart ()
		{
            // Handle when your app starts
            AppCenter.Start("3843f52d-a806-436d-b45a-7d6af4370df9",
                   typeof(Analytics));
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
