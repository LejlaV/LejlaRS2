using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MyDentalCare.Mobile.ViewModels;
using MyDentalCare.Model;
using MyDentalCare.Model.Requests;
using Xamarin.Forms;

namespace MyDentalCare.Mobile.ViewModels
{
	public class StomatoloskaOrdinacijaViewModel
	{
		private readonly APIService _stomatoloskaOrdinacija = new APIService("StomatoloskaOrdinacija");
		private readonly APIService _adresa = new APIService("adresa");

		public StomatoloskaOrdinacijaViewModel()
		{
			PrikazStomatoloskeOrdinacijeCommand = new Command(async () => await PrikazOrdinacije());
			UcitajAdrese();
		}

		public StomatoloskaOrdinacija StomatoloskaOrdinacija { get; set; }
		public ObservableCollection<StomatoloskaOrdinacija> StomatoloskaOrdinacijaList { get; set; } = new ObservableCollection<StomatoloskaOrdinacija>();
		public List<Adresa> AdresaList { get; set; } = new List<Adresa>();
		public ICommand PrikazStomatoloskeOrdinacijeCommand { get; set; }

		public void UcitajAdrese()
		{
			Task<List<Adresa>> task = Task.Run<List<Adresa>>(async () => await _adresa.Get<List<Adresa>>(null));
			AdresaList.Clear();
			AdresaList.AddRange(task.Result);
		}

		public async Task PrikazOrdinacije()
		{
			var list = await _stomatoloskaOrdinacija.Get<IEnumerable<StomatoloskaOrdinacija>>(null);
			StomatoloskaOrdinacijaList.Clear();
			foreach (var item in list)
			{
				StomatoloskaOrdinacijaList.Add(item);
			}
		}
	}
}
