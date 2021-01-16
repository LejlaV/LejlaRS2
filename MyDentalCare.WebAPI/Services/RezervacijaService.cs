using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MyDentalCare.Model;
using MyDentalCare.Model.Requests;
using MyDentalCare.WebAPI.Database;

namespace MyDentalCare.WebAPI.Services
{
	public class RezervacijaService : BaseCRUDService<Model.Rezervacija, RezervacijaSearchRequest, Database.Rezervacija, RezervacijaUpsertRequest, RezervacijaUpsertRequest>
	{
		public RezervacijaService(MyDentalCareContext context, IMapper mapper) : base(context, mapper)
		{
		}

		public override List<Model.Rezervacija> Get(RezervacijaSearchRequest search)
		{
			var query = _context.Set<Database.Rezervacija>().Include(x=> x.Pacijent).Include(x=> x.Usluga).AsQueryable();

			if (search?.PacijentId.HasValue == true)
			{
				query = query.Where(x => x.PacijentId == search.PacijentId);
			}
			if (search?.Mjesec.HasValue == true)
			{
				query = query.Where(x => x.DatumVrijeme.Month == search.Mjesec);

			}
			var list = query.ToList();

			return _mapper.Map<List<Model.Rezervacija>>(list);
		}

		public override Model.Rezervacija Delete(int id)
		{
			var entity = _context.Rezervacija.Find(id);

			_context.Rezervacija.Remove(entity);
			_context.SaveChanges();
			return _mapper.Map<Model.Rezervacija>(entity);
		}
	}
}
