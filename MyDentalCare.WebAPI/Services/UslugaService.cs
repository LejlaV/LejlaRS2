using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MyDentalCare.Model.Requests;
using MyDentalCare.WebAPI.Database;

namespace MyDentalCare.WebAPI.Services
{
	public class UslugaService : BaseCRUDService<Model.Usluga, UslugaSearchRequest, Database.Usluga, UslugaUpsertRequest, UslugaUpsertRequest>
	{
		public UslugaService(MyDentalCareContext context, IMapper mapper) : base(context, mapper)
		{
		}

		public override List<Model.Usluga> Get(UslugaSearchRequest search)
		{
			var query = _context.Usluga.AsQueryable();

			if(!string.IsNullOrWhiteSpace(search.Naziv))
			{
				query = query.Where(x => x.Naziv == search.Naziv);
			}

			var list = query.ToList();
			var result = _mapper.Map<List<Model.Usluga>>(list);
			return result;
		}
	}
}
