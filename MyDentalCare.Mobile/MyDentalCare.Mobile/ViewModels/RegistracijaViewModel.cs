using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MyDentalCare.Mobile.Views;
using MyDentalCare.Model;
using MyDentalCare.Model.Requests;
using Xamarin.Forms;

namespace MyDentalCare.Mobile.ViewModels
{
	public class RegistracijaViewModel : BaseViewModel
	{
		private APIService _pacijent = new APIService("Pacijent");

        public RegistracijaViewModel()
        {
            RegistracijaCommand = new Command(async () => await Registracija());
        }
      
        public ICommand RegistracijaCommand { get; set; }
        
        public async Task Registracija()
        {
            IsBusy = true;
            await _pacijent.Insert<Pacijent>(new PacijentUpsertRequest()
            {
                Ime = _ime,
                Prezime = _prezime,
                DatumRegistracije = DateTime.Now,
                BrojTelefona = _telefon,
                Email = _email,
                KorisnickoIme = _korisnickoIme,
                Password = _lozinka,
                PasswordConfirmation = _passwordConfirmation,
            });
            Application.Current.MainPage = new LoginPage();
        }

        string _ime = string.Empty;
        public string Ime
        {
            get { return _ime; }
            set { SetProperty(ref _ime, value); }
        }
        string _prezime = string.Empty;
        public string Prezime
        {
            get { return _prezime; }
            set { SetProperty(ref _prezime, value); }
        }
        DateTime _datumRegistracaije = DateTime.Now;
        string _telefon = string.Empty;
        public string BrojTelefona
        {
            get { return _telefon; }
            set { SetProperty(ref _telefon, value); }
        }
        string _email = string.Empty;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        string _korisnickoIme = string.Empty;
        public string KorisnickoIme
        {
            get { return _korisnickoIme; }
            set { SetProperty(ref _korisnickoIme, value); }
        }

        string _lozinka = string.Empty;
        public string Lozinka
        {
            get { return _lozinka; }
            set { SetProperty(ref _lozinka, value); }
        }
        string _passwordConfirmation = string.Empty;
        public string PasswordConfirmation
        {
            get { return _passwordConfirmation; }
            set { SetProperty(ref _passwordConfirmation, value); }
        }
    }
}
