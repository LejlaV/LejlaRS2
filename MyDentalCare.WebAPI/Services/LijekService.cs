using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MyDentalCare.Model.Requests;
using MyDentalCare.WebAPI.Database;

namespace MyDentalCare.WebAPI.Services
{
	public class LijekService : BaseCRUDService<Model.Lijek, LijekSearchRequest, Database.Lijek, LijekUpsertRequest, LijekUpsertRequest>
	{
		public LijekService(MyDentalCareContext context, IMapper mapper) : base(context, mapper)
		{

		}

		public override List<Model.Lijek> Get(LijekSearchRequest search)
		{
			var query = _context.Lijek.AsQueryable();

			if (!string.IsNullOrWhiteSpace(search.Naziv))
			{
				query = query.Where(x => x.Naziv == search.Naziv);
			}

			var list = query.ToList();
			var result = _mapper.Map<List<Model.Lijek>>(list);
			return result;
		}

		public Model.Lijek GetNajboljiLijek()
		{
			var lijekovi = _context.Lijek.ToList();
			var brojac = 0;
			var noviLijek = new Database.Lijek();
			foreach (var item in lijekovi)
			{
				var pregledilijekovi = _context.Pregled.Count(x => x.LijekId == item.LijekId);
				if (pregledilijekovi > brojac)
				{
					brojac = pregledilijekovi;
					noviLijek = item;
				}
			}
			var temp = _mapper.Map<Model.Lijek>(noviLijek);
			temp.propisanoLijekova = brojac;
			return temp;
		}
	}
}
