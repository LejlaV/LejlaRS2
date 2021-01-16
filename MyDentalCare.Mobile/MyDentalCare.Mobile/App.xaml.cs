using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyDentalCare.Mobile.Services;
using MyDentalCare.Mobile.Views;
using System.Globalization;
using System.Threading;
using DotNetty.Transport.Bootstrapping;

namespace MyDentalCare.Mobile
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			//DependencyService.Register<MockDataStore>();
			//MainPage = new ContentPage();
			//MainPage = new LoginPage();
			MainPage = new LoginPage();
		}
		protected override void OnStart()
		{
			//MainPage = new MainPageAdmin();
		}
		protected override void OnSleep()
		{
		}
		protected override void OnResume()
		{
		}
	}
}
