using MyDentalCare.Mobile.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyDentalCare.Mobile.ViewModels
{
	public class ItemDetailViewModelAdmin : BaseViewModel
	{
		public Item Item { get; set; }
		public ItemDetailViewModelAdmin(Item item = null)
		{
			Title = item?.Text;
			Item = item;
		}
	}
}
