using System;
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
	public partial class UrediMedicinskiKarton : ContentPage
	{
		private readonly APIService _medicinskiKarton = new APIService("MedicinskiKarton");
		private readonly APIService _pacijent = new APIService("Pacijent");

		UrediMedicinskiKartonViewModel model = new UrediMedicinskiKartonViewModel();

		public UrediMedicinskiKarton(MedicinskiKarton medicinskiKarton)
		{
			InitializeComponent();
			BindingContext = model = new UrediMedicinskiKartonViewModel() { MedicinskiKarton = medicinskiKarton};
		}
		protected override void OnAppearing()
		{
			base.OnAppearing();
			BindingContext = model;
		}
		private async void Button_Clicked(object sender, EventArgs e)
		{
			try
			{
				var listaMedKartona = await _medicinskiKarton.Get<List<MedicinskiKarton>>(null);
				foreach (var item in listaMedKartona)
				{
					if(item.MedicinskiKartonId==model.MedicinskiKarton.MedicinskiKartonId)
					{
						MedicinskiKartonUpsertRequest request = new MedicinskiKartonUpsertRequest();
						request.PacijentId = item.PacijentId;
						request.Opis = this.Opis.Text;
						request.Naziv = item.Naziv;
						request.DatumVrijeme = item.DatumVrijeme;
						await _medicinskiKarton.Update<dynamic>(model.MedicinskiKarton.MedicinskiKartonId, request);
						await DisplayAlert("OK", "Uspješno izmjenjeno!", "OK");
						await Navigation.PushAsync(new PrikazMedicinskihKartona());
					}
				}
			}
			catch (Exception err)
			{
				throw new Exception(err.Message);
			}
		}

	}
}