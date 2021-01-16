using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using MyDentalCare.Model;

namespace MyDentalCare.Mobile.ViewModels
{
	public class UrediClanakViewModel : BaseViewModel
	{
		public Clanak Clanak { get; set; }

		private readonly APIService _clanci = new APIService("clanak");
		private readonly APIService _kategorije = new APIService("Kategorija");

		public ObservableCollection<Clanak> ClanciList { get; set; } = new ObservableCollection<Clanak>();
		public List<Kategorija> KategorijeList { get; set; } = new List<Kategorija>();

		public UrediClanakViewModel()
		{
			UcitajKategorije();
		}
		public void UcitajKategorije()
		{
			Task<List<Kategorija>> task = Task.Run<List<Kategorija>>(async () => await _kategorije.Get<List<Kategorija>>(null));
			KategorijeList.Clear();
			KategorijeList.AddRange(task.Result);
		}

		private byte[] _slika;
		public byte[] Slika
		{
			get { return _slika; }
			set { SetProperty(ref _slika, value); }
		}
	}
}
