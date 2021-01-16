using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyDentalCare.WebAPI.Database;
using Microsoft.EntityFrameworkCore;

namespace MyDentalCare.WebAPI.Services
{
	public class PacijentKategorijaViewModel
	{
		public int KategorijaId { get; set; }
		public decimal ProsjecnaOcjenaKategorije { get; set; }
	}
	public class PreporukaService : IPreporukaService
	{
		private readonly MyDentalCareContext _context;
		private readonly IMapper _mapper;

		public int BrojPreporuka = 5;
		public PreporukaService(MyDentalCareContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		public List<Model.Clanak> GetPreporuka(int id)
		{
			var ocjene = _context.Ocjena.Include(x=> x.Clanak).Where(x => x.PacijentId == id).ToList();

			// u slucaju da pacijent nije dao niti jednu ocjenu na clanak, 
			// preporucuje mu se top 5 najbolje ocjenjenih clanaka
			
			List<Clanak> listaSvihClanaka = _context.Clanak
					.Include(x => x.Kategorija)
					.Include(x => x.Ocjena)
				.OrderByDescending(x => _context.Ocjena
				.Where(o => o.ClanakId == x.ClanakId && o.Ocjena1 != 0)
				.Average(a => Math.Round((decimal?)a.Ocjena1 ?? new decimal(0), 2))).ToList();
			
			if (ocjene.Count() == 0) 
			{
				return _mapper.Map<List<Model.Clanak>>(listaSvihClanaka.Take(BrojPreporuka));
			}
			
				var kategorije = _context.Kategorija.ToList();

				List<PacijentKategorijaViewModel> pacijentoveKategorije = new List<PacijentKategorijaViewModel>();

				// kreiranje liste sa prosjecnom ocjenom pacijenta na odredjenu kategoriju 
				foreach (var item in kategorije)
				{
					if (ocjene.Any(x => x.Clanak.KategorijaId == item.KategorijaId))
					{
						decimal prosjecnaOcjena = Math.Round(ocjene
							.Where(x => x.Clanak.KategorijaId == item.KategorijaId && x.Ocjena1 != 0)
							.Average(x => (decimal?)x.Ocjena1) ?? new decimal(0), 2);

						pacijentoveKategorije.Add(new PacijentKategorijaViewModel
						{
							KategorijaId = item.KategorijaId,
							ProsjecnaOcjenaKategorije = prosjecnaOcjena
						});
					}
				}

				pacijentoveKategorije = pacijentoveKategorije.OrderBy(x => x.ProsjecnaOcjenaKategorije).ToList();

				var listaReferentnihOcjena = pacijentoveKategorije.Select(x => x.ProsjecnaOcjenaKategorije).ToList();

				List<Clanak> listaPreporucenih = new List<Clanak>();

				foreach (var referentnaOcjena in listaReferentnihOcjena)
				{
					foreach (var item in pacijentoveKategorije)
					{
						var ocjeneClanka = _context.Ocjena.Where(x => x.PacijentId == id).ToList();

						List<Clanak> listaClanaka = _context.Clanak.Include(x=> x.Ocjena)
							.Where(x => x.KategorijaId == item.KategorijaId).ToList();

						foreach (var clanak in listaClanaka)
						{
							if(ocjene.Any(o=> o.ClanakId == clanak.ClanakId) == false)
							{
								decimal prosjecnaOcjena = Math.Round(_context.Ocjena.Where(x => x.ClanakId == clanak.ClanakId)
																	.Average(x => (decimal?)x.Ocjena1) ?? new decimal(0), 2);

								if (prosjecnaOcjena >= referentnaOcjena && !listaPreporucenih.Any(x => x.ClanakId == clanak.ClanakId))
								{
									listaPreporucenih.Add(clanak);
								}
							}
						}
					}
				}
			if (listaPreporucenih.Count() < 5) 
			{
				foreach (var item in listaSvihClanaka)
				{
					if (!listaPreporucenih.Any(x => x.ClanakId == item.ClanakId) && !ocjene.Any(x => x.ClanakId == item.ClanakId)) 
					{
						listaPreporucenih.Add(item);
					}
				}
			}
			return _mapper.Map<List<Model.Clanak>>(listaPreporucenih.Take(BrojPreporuka));
		}
	}
}
