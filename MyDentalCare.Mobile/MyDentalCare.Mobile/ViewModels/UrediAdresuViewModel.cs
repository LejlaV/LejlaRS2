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
	public class UrediAdresuViewModel
	{
		public Adresa Adresa { get; set; }
		private readonly APIService _adresa = new APIService("adresa");
		private readonly APIService _grad = new APIService("grad");

		public ObservableCollection<Adresa> AdresaList { get; set; } = new ObservableCollection<Adresa>();
		public List<Grad> GradList { get; set; } = new List<Grad>();
		public UrediAdresuViewModel()
		{
			UcitajGradove();
		}
		public void UcitajGradove()
		{
			Task<List<Grad>> task = Task.Run<List<Grad>>(async () => await _grad.Get<List<Grad>>(null));
			GradList.Clear();
			GradList.AddRange(task.Result);
		}
	}
}
