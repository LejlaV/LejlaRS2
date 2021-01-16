using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDentalCare.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyDentalCare.Mobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DijagnozePage : ContentPage
	{
		private DijagnozeViewModel model = null;

		public DijagnozePage()
		{
			InitializeComponent();
			BindingContext = model = new DijagnozeViewModel();
		}
		protected async override void OnAppearing()
		{
			base.OnAppearing();
			await model.PrikazDijagnoza();
		}
		private void Button_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new PrikazDijagnoza());
		}

		private void Button_Clicked_1(object sender, EventArgs e)
		{
			Navigation.PushAsync(new DodajDijagnozu());
		}
	}
}