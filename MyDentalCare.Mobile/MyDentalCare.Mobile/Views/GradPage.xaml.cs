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
	public partial class GradPage : ContentPage
	{
		private GradViewModel model = null;

		public GradPage()
		{
			InitializeComponent();
			BindingContext = model = new GradViewModel();
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new PrikazGradova());

		}

		private void Button_Clicked_1(object sender, EventArgs e)
		{
			Navigation.PushAsync(new DodajGrad());
		}
	}
}