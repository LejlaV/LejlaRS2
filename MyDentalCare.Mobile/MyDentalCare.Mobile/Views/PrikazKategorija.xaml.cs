﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDentalCare.Mobile.ViewModels;
using MyDentalCare.Model;
using MyDentalCare.Model.Requests;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyDentalCare.Mobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PrikazKategorija : ContentPage
	{
		public APIService _kategorija = new APIService("Kategorija");
		
		KategorijaViewModel model = null;

		public PrikazKategorija()
		{
			InitializeComponent();
			BindingContext = model = new KategorijaViewModel();
		}

		protected async override void OnAppearing()
		{
			base.OnAppearing();
			await model.PrikazKategorija();
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
			var btn = sender as Button;
			var item = btn.BindingContext as Kategorija;
			await Navigation.PushAsync(new UrediKategoriju(item));
		}
	}
}