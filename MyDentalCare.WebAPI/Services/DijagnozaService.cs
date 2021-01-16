using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MyDentalCare.Model.Requests;
using MyDentalCare.WebAPI.Database;

namespace MyDentalCare.WebAPI.Services
{
	public class DijagnozaService : BaseCRUDService<Model.Dijagnoza, DijagnozaSearchRequest, Database.Dijagnoza, DijagnozaUpsertRequest, DijagnozaUpsertRequest>
	{
		public DijagnozaService(MyDentalCareContext context, IMapper mapper) : base(context, mapper)
		{
		}

		public override List<Model.Dijagnoza> Get(DijagnozaSearchRequest search)
		{
			var query = _context.Dijagnoza.AsQueryable();

			if(!string.IsNullOrWhiteSpace(search.Naziv))
			{
				query = query.Where(x => x.Naziv == search.Naziv);
			}

			var list = query.ToList();
			var result = _mapper.Map<List<Model.Dijagnoza>>(list);
			return result;
		}
	}
}
