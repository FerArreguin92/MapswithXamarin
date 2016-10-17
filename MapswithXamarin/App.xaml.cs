// File: App.xaml.cs
// Author: Fernando Arreguín Leija - farreguin@alasa.com
// 2016 - All Rights Reserved
using Xamarin.Forms;

namespace MapswithXamarin
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new MapswithXamarinPage();
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
