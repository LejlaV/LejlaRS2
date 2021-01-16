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
	public class StomatoloskaOrdinacijaService : BaseCRUDService<Model.StomatoloskaOrdinacija, StomatoloskaOrdinacijaSearchRequest, Database.StomatoloskaOrdinacija, StomatoloskaOrdinacijaUpsertRequest, StomatoloskaOrdinacijaUpsertRequest>
	{
		public StomatoloskaOrdinacijaService(MyDentalCareContext context, IMapper mapper) : base(context, mapper)
		{
		}

		public override List<Model.StomatoloskaOrdinacija> Get(StomatoloskaOrdinacijaSearchRequest search)
		{
			var query = _context.StomatoloskaOrdinacija.Include(x => x.Adresa).AsQueryable();

			if(search?.AdresaId != 0)
			{
				query = query.Where(x => x.Adresa.AdresaId == search.AdresaId);
			}
			if(!string.IsNullOrWhiteSpace(search.Naziv))
			{
				query = query.Where(x => x.Naziv == search.Naziv);
			}

			var list = query.ToList();
			var result = _mapper.Map<List<Model.StomatoloskaOrdinacija>>(list);
			return result;
		}
	}
}
