using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MyDentalCare.Model.Requests;
using MyDentalCare.WebAPI.Database;

namespace MyDentalCare.WebAPI.Services
{
	public class MedicinskiKartonService : BaseCRUDService<Model.MedicinskiKarton, MedicinskiKartonSearchRequest, Database.MedicinskiKarton, MedicinskiKartonUpsertRequest, MedicinskiKartonUpsertRequest>
	{
		public MedicinskiKartonService(MyDentalCareContext context, IMapper mapper) : base(context, mapper)
		{
		}

		public override List<Model.MedicinskiKarton> Get(MedicinskiKartonSearchRequest search)
		{
			var query = _context.Set<Database.MedicinskiKarton>().Include(x=> x.Pacijent).AsQueryable();

			if (search?.PacijentId.HasValue == true)
			{
				query = query.Where(x => x.PacijentId == search.PacijentId);
			}
			
			var list = query.ToList();

			return _mapper.Map<List<Model.MedicinskiKarton>>(list);
		}
	}
}
