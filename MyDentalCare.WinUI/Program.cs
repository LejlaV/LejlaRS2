using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDentalCare.WinUI;
using MyDentalCare.WinUI.Korisnik;
using MyDentalCare.WinUI.Lijek;
using MyDentalCare.WinUI.Usluge;
using MyDentalCare.WinUI.Kategorija;
using MyDentalCare.WinUI.Dijagnoza;
using MyDentalCare.WinUI.Clanak;
using MyDentalCare.WinUI.Rezervacija;
using MyDentalCare.WinUI.Pregled;
using MyDentalCare.WinUI.MedicinskiKarton;
using MyDentalCare.WinUI.Login;
using MyDentalCare.WinUI.Pacijent;
using MyDentalCare.WinUI.Izvjestaji;

namespace MyDentalCare.WinUI
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frmLogin());
		}
	}
}
