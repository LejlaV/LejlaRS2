using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using MyDentalCare.Model;
using MyDentalCare.Model.Requests;

namespace MyDentalCare.Mobile.ViewModels
{
	public class UrediMedicinskiKartonViewModel :  BaseViewModel
	{
		private readonly APIService _medicinskiKarton = new APIService("MedicinskiKarton");
		private readonly APIService _pacijent = new APIService("Pacijent");
		public MedicinskiKarton MedicinskiKarton { get; set; }

		public UrediMedicinskiKartonViewModel()
		{
		}
		public ObservableCollection<MedicinskiKarton> MedicinskiKartonList { get; set; } = new ObservableCollection<MedicinskiKarton>();
		public List<Pacijent> PacijentList { get; set; } = new List<Pacijent>();

	}
}
