using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MyDentalCare.Mobile.ViewModels;
using MyDentalCare.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyDentalCare.Mobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DodajMedicinskiKarton : ContentPage
	{
		private readonly APIService _medicinskiKarton = new APIService("MedicinskiKarton");
		private readonly APIService _pacijent = new APIService("Pacijent");
		MedicinskiKartonViewModel model = null;

		public DodajMedicinskiKarton()
		{
			InitializeComponent();
			BindingContext = model = new MedicinskiKartonViewModel();
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
			Model.Pacijent pacijent = this.PacijentPicker.SelectedItem as Model.Pacijent;
			try
			{
				if (this.PacijentPicker.SelectedItem!=null)
				{
					var listaMedKartona = await _medicinskiKarton.Get<List<Model.MedicinskiKarton>>(null);
					foreach (var item in listaMedKartona)
					{
						if (item.Pacijent.PacijentId == pacijent.PacijentId)
						{
							await Application.Current.MainPage.DisplayAlert(" ", "Medicinski karton za ovog pacijenta vec postoji!", "OK");
							return;
						}
					}

					var listaPacijenata = await _pacijent.Get<List<Model.Pacijent>>(null);
					foreach (var item in listaPacijenata)
					{
						if (item.PacijentId == pacijent.PacijentId)
						{
							string pacijentPodaci = item.Ime + " " + item.Prezime;
							model.Naziv = "Medicinski karton -> " + pacijentPodaci;
						}
					}
				}
					model.PacijentId = pacijent.PacijentId;
					model.Opis = this.Opis.Text;
					model.DatumVrijeme = DateTime.Now;
                    await model.DodajMedicinskiKarton();
                    await Navigation.PushAsync(new PrikazMedicinskihKartona());
			}
			catch (Exception err)
			{
				throw new Exception(err.Message);
			}
		}
	}
}