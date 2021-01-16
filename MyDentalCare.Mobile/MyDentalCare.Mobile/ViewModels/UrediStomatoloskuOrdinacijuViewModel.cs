using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using MyDentalCare.Mobile.ViewModels;
using MyDentalCare.Model;
using MyDentalCare.Model.Requests;

namespace MyDentalCare.Mobile.ViewModels
{
	public class UrediStomatoloskuOrdinacijuViewModel
	{
		public StomatoloskaOrdinacija StomatoloskaOrdinacija { get; set; }
		private readonly APIService _stomatoloskaOrdinacija = new APIService("StomatoloskaOrdinacija");
		private readonly APIService _adresa = new APIService("adresa");
		public ObservableCollection<StomatoloskaOrdinacija> StomatoloskaOrdinacijaList { get; set; } = new ObservableCollection<StomatoloskaOrdinacija>();
		public List<Adresa> AdresaList { get; set; } = new List<Adresa>();

		public UrediStomatoloskuOrdinacijuViewModel()
		{
			UcitajAdrese();
		}

		public void UcitajAdrese()
		{
			Task<List<Adresa>> task = Task.Run<List<Adresa>>(async () => await _adresa.Get<List<Adresa>>(null));
			AdresaList.Clear();
			AdresaList.AddRange(task.Result);
		}
	}
}
