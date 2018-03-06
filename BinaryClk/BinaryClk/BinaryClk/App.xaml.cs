using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace BinaryClk
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new BinaryClk.MainPage();
		}

		protected override void OnStart ()
		{
            MainPage = new BinaryClk.MainPage();
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
