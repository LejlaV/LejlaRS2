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
	public class AdresaService : BaseCRUDService<Model.Adresa, AdresaSearchRequest, Database.Adresa, AdresaUpsertRequest, AdresaUpsertRequest>
	{
		public AdresaService(MyDentalCareContext context, IMapper mapper) : base(context, mapper)
		{
		}

		public override List<Model.Adresa> Get(AdresaSearchRequest search)
		{
			var query = _context.Adresa.Include(x => x.Grad).AsQueryable();

			if(search?.GradId != 0)
			{
				query = query.Where(x => x.Grad.GradId == search.GradId);
			}
			if (!string.IsNullOrWhiteSpace(search?.Naziv))
			{
				query = query.Where(x => x.Naziv == search.Naziv);
			}

			var list = query.ToList();
			var result = _mapper.Map<List<Model.Adresa>>(list);
			return result;
		}
	}
}
