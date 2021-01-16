using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDentalCare.Model;
using MyDentalCare.Model.Requests;
using Syncfusion.Pdf;
using Syncfusion.UI.Xaml.Grid.Converters;
using Syncfusion.UI.Xaml.Grid.Helpers;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace MyDentalCare.WinUI.Izvjestaji
{
	public partial class frmRezervacijeIzvjestaj : Form
	{
		private readonly APIService _rezervacije = new APIService("rezervacija");
		private readonly APIService _usluge= new APIService("usluga");
		public frmRezervacijeIzvjestaj()
		{
			InitializeComponent();
		}
		private void LoadMjesec()
		{
			for (int i = 1; i <= 12; i++)
			{
				cmbMjesec.Items.Add(i);
			}
			cmbMjesec.Text = "--- Odaberite mjesec ---";
		}
		private async Task LoadIzvjestaji(int Mjesec)
		{
			List<IzvjestajRezervacije> izvjestaj = new List<IzvjestajRezervacije>();

			int brojRezervacija = 0;
			decimal? ukupnaZarada = 0;

			var listaRezervacija = await _rezervacije.Get<List<Model.Rezervacija>>(null);

			foreach (var item in listaRezervacija)
			{
				decimal? zarada = 0;

				if (item.DatumVrijeme.Month == Mjesec)
				{
					brojRezervacija++;

					var listaUsluga = await _usluge.Get<List<Model.Usluga>>(null);

					foreach (var usluga in listaUsluga)
					{
						if(usluga.UslugaId==item.UslugaId)
						{
							zarada += usluga.Cijena;
						}
					}
					ukupnaZarada += zarada;
				}
			}

			var usluge = await _usluge.Get<List<Model.Usluga>>(null);
			var brojacUsluga = 0;
			var novaUsluga = new Model.Usluga();

			foreach (var u in usluge)
			{
				var rezervacijeUsluge = await _rezervacije.Get<List<Model.Rezervacija>>(null);
				foreach (var r in rezervacijeUsluge)
				{
					if (r.UslugaId == u.UslugaId && r.DatumVrijeme.Month == Mjesec)
					{
						var brojacRezervacijeUsluge = rezervacijeUsluge.Count();
						if (brojacRezervacijeUsluge > brojacUsluga)
						{
							brojacUsluga = brojacRezervacijeUsluge;
							novaUsluga = u;
						}
					}
				}
			}

			var najcescaUsluga = novaUsluga.Naziv;

			izvjestaj.Add(new IzvjestajRezervacije() { BrojRezervacija = brojRezervacija, UkupnaZarada = ukupnaZarada, NajcescaUsluga = najcescaUsluga }) ;

			dgvIzvjestajRezervacije.AutoGenerateColumns = false;
			dgvIzvjestajRezervacije.DataSource = izvjestaj;
			txtNajcescaUsluga.Text = najcescaUsluga;
		}

		public void exportGridToPdf(DataGridView dgw, string fileName)
		{
			BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
			PdfPTable pdfptable = new PdfPTable(dgw.Columns.Count);

			pdfptable.DefaultCell.Padding = 3;
			pdfptable.WidthPercentage = 100;
			pdfptable.HorizontalAlignment = Element.ALIGN_LEFT;
			pdfptable.DefaultCell.BorderWidth = 1;

			iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);

			//header
			foreach (DataGridViewColumn column in dgw.Columns)
			{
				PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
				cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
				pdfptable.AddCell(cell);
			}

			//datarow
			foreach (DataGridViewRow row in dgw.Rows)
			{
				foreach (DataGridViewCell cell in row.Cells)
				{
					pdfptable.AddCell(new Phrase(cell.Value.ToString(), text));
				}
			}

			var savefiledialoge = new SaveFileDialog();
			savefiledialoge.FileName = fileName;
			savefiledialoge.DefaultExt = ".pdf";
			if (savefiledialoge.ShowDialog() == DialogResult.OK)
			{
				using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
				{
					Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
					PdfWriter.GetInstance(pdfdoc, stream);
					pdfdoc.Open();
					pdfdoc.Add(pdfptable);
					pdfdoc.Close();
					stream.Close();
				}
			}
		}

			private void frmRezervacijeIzvjestaj_Load(object sender, EventArgs e)
		{
			LoadMjesec();

		}
		private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			var idObj = cmbMjesec.SelectedItem;
			if (int.TryParse(idObj.ToString(), out int id))
			{
				await LoadIzvjestaji(id);
			}
		}

		private void btnExportToPdf_Click(object sender, EventArgs e)
		{
			exportGridToPdf(dgvIzvjestajRezervacije, "izvjestajRezervacije");
		}

	}
}
