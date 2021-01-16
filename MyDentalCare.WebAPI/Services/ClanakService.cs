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
	public class ClanakService : BaseCRUDService<Model.Clanak, ClanakSearchRequest, Database.Clanak, ClanakUpsertRequest, ClanakUpsertRequest>
	{
		public ClanakService(MyDentalCareContext context, IMapper mapper) : base(context, mapper)
		{
		}

		public override List<Model.Clanak> Get(ClanakSearchRequest search)
		{
			var query = _context.Set<Clanak>().Include(i => i.Kategorija).AsQueryable();

			if (search?.KategorijaId.HasValue == true)
			{
				query = query.Where(x => x.KategorijaId == search.KategorijaId);
			}

			query = query.OrderBy(x => x.Naslov);

			var list = query.ToList();

			var listaOcjena = _context.Ocjena.ToList();
			var newList = _mapper.Map<List<Model.Clanak>>(list);
			foreach (var item in newList)
			{
				foreach (var ocjena in listaOcjena)
				{
					if(ocjena.ClanakId==item.ClanakId && ocjena.Ocjena1!=0)
					{
						item.ProsjecnaOcjena = Math.Round(_context.Ocjena.Where(x => x.ClanakId == item.ClanakId)
						.Average(x => (decimal?)x.Ocjena1) ?? new decimal(0), 2);
					}
				}
					//item.ProsjecnaOcjena = Math.Round(_context.Ocjena.Where(x => x.ClanakId == item.ClanakId)
					//.Average(x => (decimal?)x.Ocjena1) ?? new decimal(0), 2);
			}
			return newList;
			//return _mapper.Map<List<Model.Clanak>>(list);
		}
	}
}
