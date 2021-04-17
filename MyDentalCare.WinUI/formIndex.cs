using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDentalCare.WinUI.Korisnik;
using MyDentalCare.WinUI.Pacijent;
using MyDentalCare.WinUI.MedicinskiKarton;
using MyDentalCare.WinUI.Rezervacija;
using MyDentalCare.WinUI.Pregled;
using MyDentalCare.WinUI.Lijek;
using MyDentalCare.WinUI.Dijagnoza;
using MyDentalCare.WinUI.Kategorija;
using MyDentalCare.WinUI.Clanak;
using MyDentalCare.WinUI.Usluge;
using MyDentalCare.WinUI.Izvjestaji;

namespace MyDentalCare.WinUI
{
	public partial class formIndex : Form
	{
		public formIndex()
		{
			InitializeComponent();
			customizeDesign();
		}
		private void customizeDesign()
		{
			SubMenuPanel1.Visible = false;
			subMenuPacijenti.Visible = false;
			subMenuMedKartoni.Visible = false;
			subMenuRezervacije.Visible = false;
			subMenuPregledi.Visible = false;
			subMenuClanak.Visible = false;
			subMenuLijekovi.Visible = false;
			subMenuDijagnoze.Visible = false;
			subMenuUsluge.Visible = false;
			subMenuIzvjestaji.Visible = false;
		}

		private void hideSubMenu()
		{
			if (SubMenuPanel1.Visible == true)
			{
				SubMenuPanel1.Visible = false;
			}
			if (subMenuPacijenti.Visible == true)
			{
				subMenuPacijenti.Visible = false;
			}
			if (subMenuMedKartoni.Visible == true)
			{
				subMenuMedKartoni.Visible = false;
			}
			if (subMenuRezervacije.Visible == true)
			{
				subMenuRezervacije.Visible = false;
			}
			if (subMenuPregledi.Visible == true)
			{
				subMenuPregledi.Visible = false;
			}
			if (subMenuClanak.Visible == true)
			{
				subMenuClanak.Visible = false;
			}
			if (subMenuLijekovi.Visible == true)
			{
				subMenuLijekovi.Visible = false;
			}
			if (subMenuDijagnoze.Visible == true)
			{
				subMenuDijagnoze.Visible = false;
			}
			if (subMenuUsluge.Visible == true)
			{
				subMenuUsluge.Visible = false;
			}
			if (subMenuIzvjestaji.Visible == true)
			{
				subMenuIzvjestaji.Visible = false;
			}
		}

		private void showSubMenu(Panel subMenu)
		{
			if (subMenu.Visible == false)
			{
				hideSubMenu();
				subMenu.Visible = true;
			}
			else subMenu.Visible = false;
		}

		#region SubMenuKorisnici
		private void button1_Click(object sender, EventArgs e)
		{
			showSubMenu(SubMenuPanel1);
		}
		private void button2_Click(object sender, EventArgs e)
		{
			openChildForm(new frmKorisnik());
			hideSubMenu();
		}
		private void button3_Click(object sender, EventArgs e)
		{
			openChildForm(new frmKorisnikDetalji());
			hideSubMenu();
		}
		private Form activeForm = null;
		private void openChildForm(Form childForm)
		{
			if (activeForm != null)
			{
				activeForm.Close();
			}
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			panelChildForm.Controls.Add(childForm);
			panelChildForm.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}
		#endregion SubMenuKorisnici

		#region Pacijenti
		private void button4_Click(object sender, EventArgs e)
		{
			showSubMenu(subMenuPacijenti);
		}
		private void button5_Click(object sender, EventArgs e)
		{
			openChildForm(new frmPacijenti());
			hideSubMenu();
		}
		private void button6_Click(object sender, EventArgs e)
		{
			openChildForm(new frmPacijentDetalji());
			hideSubMenu();
		}
		#endregion Pacijenti

		#region MedKartoni
		private void button7_Click(object sender, EventArgs e)
		{
			showSubMenu(subMenuMedKartoni);
		}

		private void button8_Click(object sender, EventArgs e)
		{
			openChildForm(new frmMedicinskiKartoni());
			hideSubMenu();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			openChildForm(new frmMedicinskiKartonDetalji());
			hideSubMenu();
		}
		#endregion MedKartoni

		#region Rezervacije
		private void button10_Click(object sender, EventArgs e)
		{
			showSubMenu(subMenuRezervacije);
		}
		private void button11_Click(object sender, EventArgs e)
		{
			openChildForm(new frmRezervacije());
			hideSubMenu();
		}
		private void button12_Click(object sender, EventArgs e)
		{
			openChildForm(new frmRezervacijaDetalji());
			hideSubMenu();
		}
		#endregion

		#region Pregledi
		private void button13_Click(object sender, EventArgs e)
		{
			showSubMenu(subMenuPregledi);
		}
		private void button14_Click(object sender, EventArgs e)
		{
			openChildForm(new frmPregledi());
			hideSubMenu();
		}
		private void button15_Click(object sender, EventArgs e)
		{
			openChildForm(new frmPregledDetalji());
			hideSubMenu();
		}
		#endregion

		#region Clanci
		private void button20_Click(object sender, EventArgs e)
		{
			showSubMenu(subMenuClanak);
		}
		private void button21_Click_1(object sender, EventArgs e)
		{
			openChildForm(new frmKategorije());
			hideSubMenu();
		}
		private void button22_Click_1(object sender, EventArgs e)
		{
			openChildForm(new frmListaClanaka());
			hideSubMenu();
		}
		private void button36_Click(object sender, EventArgs e)
		{
			openChildForm(new frmKategorijaDetalji());
			hideSubMenu();
		}
		private void button37_Click(object sender, EventArgs e)
		{
			openChildForm(new frmClanakDetalji());
			hideSubMenu();
		}
		#endregion

		#region Lijekovi
		private void button23_Click(object sender, EventArgs e)
		{
			showSubMenu(subMenuLijekovi);
		}
		private void button25_Click(object sender, EventArgs e)
		{
			openChildForm(new frmLijekovi());
			hideSubMenu();
		}
		private void button24_Click_1(object sender, EventArgs e)
		{
			openChildForm(new frmLijekDetalji());
			hideSubMenu();
		}
		#endregion

		#region Dijagnoza
		private void button17_Click_1(object sender, EventArgs e)
		{
			showSubMenu(subMenuDijagnoze);
		}

		private void button29_Click(object sender, EventArgs e)
		{
			openChildForm(new frmDijagnoze());
			hideSubMenu();
		}

		private void button28_Click(object sender, EventArgs e)
		{
			openChildForm(new frmDijagnozaDetalji());
			hideSubMenu();
		}
		#endregion

		#region Usluge
		private void button18_Click(object sender, EventArgs e)
		{
			showSubMenu(subMenuUsluge);
		}
		private void button26_Click(object sender, EventArgs e)
		{
			openChildForm(new frmUsluge());
			hideSubMenu();
		}
		private void button19_Click(object sender, EventArgs e)
		{
			openChildForm(new frmUslugaDetalji());
			hideSubMenu();
		}
		#endregion

		#region Izvjestaji
		private void button38_Click(object sender, EventArgs e)
		{
			showSubMenu(subMenuIzvjestaji);
		}
		private void button44_Click(object sender, EventArgs e)
		{
			openChildForm(new frmIzvjestajPregledi());
			hideSubMenu();
		}
		private void button43_Click(object sender, EventArgs e)
		{
			openChildForm(new frmRezervacijeIzvjestaj());
			hideSubMenu();
		}
		#endregion

		private void panelSideMenu_Paint(object sender, PaintEventArgs e)
		{
		}
		private void formIndex_Load(object sender, EventArgs e)
		{
		}

		private void panelChildForm_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
