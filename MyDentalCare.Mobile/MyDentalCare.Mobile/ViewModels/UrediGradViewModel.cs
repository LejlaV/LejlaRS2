using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using MyDentalCare.Model;

namespace MyDentalCare.Mobile.ViewModels
{
	public class UrediGradViewModel : BaseViewModel
	{
		public Grad Grad { get; set; }
		private readonly APIService _grad = new APIService("grad");
		private readonly APIService _drzava = new APIService("drzava");

		public ObservableCollection<Grad> GradList { get; set; } = new ObservableCollection<Grad>();
		public List<Drzava> DrzavaList { get; set; } = new List<Drzava>();

		public UrediGradViewModel()
		{
			UcitajDrzave();
		}
		public void UcitajDrzave()
		{
			Task<List<Drzava>> task = Task.Run<List<Drzava>>(async () => await _drzava.Get<List<Drzava>>(null));
			DrzavaList.Clear();
			DrzavaList.AddRange(task.Result);
		}
	}
}
