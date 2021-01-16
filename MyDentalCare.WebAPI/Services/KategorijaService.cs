using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MyDentalCare.Model.Requests;
using MyDentalCare.WebAPI.Database;

namespace MyDentalCare.WebAPI.Services
{
	public class KategorijaService : BaseCRUDService<Model.Kategorija, KategorijaSearchRequest, Database.Kategorija, KategorijaUpsertRequest, KategorijaUpsertRequest>
	{
		public KategorijaService(MyDentalCareContext context, IMapper mapper) : base(context, mapper)
		{
		}

		public override List<Model.Kategorija> Get(KategorijaSearchRequest search)
		{
			var query = _context.Kategorija.AsQueryable();

			if(!string.IsNullOrWhiteSpace(search.Naziv))
			{
				query = query.Where(x => x.Naziv == search.Naziv);
			}

			var list = query.ToList();
			var result = _mapper.Map<List<Model.Kategorija>>(list);
			return result;
		}
	}
}
