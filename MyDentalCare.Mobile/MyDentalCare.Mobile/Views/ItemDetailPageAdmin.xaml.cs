using MyDentalCare.Mobile.Models;
using MyDentalCare.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyDentalCare.Mobile.Views
{
	//[XamlCompilation(XamlCompilationOptions.Compile)]
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class ItemDetailPageAdmin : ContentPage
	{
		ItemDetailViewModelAdmin viewModel;
		public ItemDetailPageAdmin(ItemDetailViewModelAdmin viewModel)
		{
			InitializeComponent();
			BindingContext = this.viewModel = viewModel;
		}
		public ItemDetailPageAdmin()
		{
			InitializeComponent();

			var item = new Item
			{
				Text = "Item 1",
				Description = "This is an item description."
			};

			viewModel = new ItemDetailViewModelAdmin(item);
			BindingContext = viewModel;
		}
	}
}