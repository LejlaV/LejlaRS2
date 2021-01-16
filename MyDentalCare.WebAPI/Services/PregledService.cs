using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyDentalCare.Model.Requests;
using MyDentalCare.Model;
using MyDentalCare.WebAPI.Database;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace MyDentalCare.WebAPI.Services
{
	public class PregledService : BaseCRUDService<Model.Pregled, PregledSearchRequest, Database.Pregled, PregledUpsertRequest, PregledUpsertRequest>
	{
		public PregledService(MyDentalCareContext context, IMapper mapper) : base(context, mapper)
		{
		}

		public override List<Model.Pregled> Get(PregledSearchRequest search)
		{
			var query = _context.Set<Database.Pregled>().Include(x => x.Lijek).Include(x => x.Dijagnoza).AsQueryable();
			//var query = _context.Pregled.Include(x => x.Lijek).Include(x => x.Dijagnoza).AsQueryable();

			if (search?.MedicinskiKartonId.HasValue == true)
			{
				query = query.Where(x => x.MedicinskiKartonId == search.MedicinskiKartonId);
			}
			
			var list = query.ToList();

			return _mapper.Map<List<Model.Pregled>>(list);
		}
	}
}

