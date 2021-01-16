using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MyDentalCare.Model;

namespace MyDentalCare.WinUI.Izvjestaji
{
	public partial class frmIzvjestajPregledi : Form
	{
		private readonly APIService _pregledi = new APIService("pregled");
		private readonly APIService _dijagnoze = new APIService("dijagnoza");
		private readonly APIService _lijekovi = new APIService("lijek");
		public frmIzvjestajPregledi()
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
		private async Task LoadIzvjestaj(int Mjesec)
		{
			List<IzvjestajPregledi> izvjestaj = new List<IzvjestajPregledi>();

			int brojPregleda = 0;
			int brojacDijagnoza = 0;

			var listaPregleda = await _pregledi.Get<List<Model.Pregled>>(null);

			foreach (var item in listaPregleda)
			{
				if (item.DatumVrijeme.Month == Mjesec)
				{
					brojPregleda++;

					var listaDijagnoza = await _dijagnoze.Get<List<Model.Dijagnoza>>(null);

					foreach (var d in listaDijagnoza)
					{
						if (d.DijagnozaId == item.DijagnozaId)
						{
							brojacDijagnoza++;
						}
					}
				}
			}
			
			var dijagnoze = await _dijagnoze.Get<List<Model.Dijagnoza>>(null);
			var brojac = 0;
			var novaDijagnoza = new Model.Dijagnoza();

			foreach (var d in dijagnoze)
			{
				var preglediDijagnoze = await _pregledi.Get<List<Model.Pregled>>(null);

				foreach (var p in preglediDijagnoze)
				{
					if (d.DijagnozaId == p.DijagnozaId && p.DatumVrijeme.Month == Mjesec)
					{
						var brojacpreglediDijagnoze = preglediDijagnoze.Count();
						if (brojacpreglediDijagnoze >= brojac)
						{
							brojac = brojacpreglediDijagnoze;
							novaDijagnoza = d;
						}
					}
				}
			}

			var najcescaDijagnoza = novaDijagnoza.Naziv;

			var lijekovi = await _lijekovi.Get<List<Model.Lijek>>(null);
			var brojacL = 0;
			var noviLijek = new Model.Lijek();

			foreach (var l in lijekovi)
			{
				var preglediLijekovi = await _pregledi.Get<List<Model.Pregled>>(null);

				foreach (var p in preglediLijekovi)
				{
					if (l.LijekId == p.LijekId && p.DatumVrijeme.Month == Mjesec) 
					{
						var brojacpreglediLijekovi = preglediLijekovi.Count();
						if (brojacpreglediLijekovi >= brojacL)
						{
							brojacL = brojacpreglediLijekovi;
							noviLijek = l;
						}
					}
				}
			}

			var najcesciLijek = noviLijek.Naziv;

			izvjestaj.Add(new IzvjestajPregledi() { brojObavljenihPregleda = brojPregleda, brojDijagnoza = brojacDijagnoza, NajcescaDijagnoza= najcescaDijagnoza, NajcesciLijek=najcesciLijek });

			dgvIzvjestajPregledi.AutoGenerateColumns = false;
			dgvIzvjestajPregledi.DataSource = izvjestaj;
			txtNajcescaDijagnoza.Text = najcescaDijagnoza;
			txtNajcesciLijek.Text = najcesciLijek;
		}
		private async void frmIzvjestajPregledi_Load(object sender, EventArgs e)
		{
			LoadMjesec();	
		}

		private async void cmbMjesec_SelectedIndexChanged(object sender, EventArgs e)
		{
			var idObj = cmbMjesec.SelectedItem;
			if (int.TryParse(idObj.ToString(), out int id))
			{
				await LoadIzvjestaj(id);
			}
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
		private void btnExportToPdf_Click(object sender, EventArgs e)
		{
			exportGridToPdf(dgvIzvjestajPregledi, "izvjestajRezervacije");
		}
	}
}
