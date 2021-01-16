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
	public class OcjenaService : BaseCRUDService<Model.Ocjena, OcjenaSearchRequest, Database.Ocjena, OcjenaUpsertRequest, OcjenaUpsertRequest>
	{
		public OcjenaService(MyDentalCareContext context, IMapper mapper) : base(context, mapper)
		{
		}

        public override List<Model.Ocjena> Get(OcjenaSearchRequest search)
        {
            var query = _context.Set<Database.Ocjena>().Include(x=> x.Clanak).AsQueryable();

            if (search?.ClanakId.HasValue == true && search?.PacijentId.HasValue == true)
            {
                query = query.Where(s => s.Clanak.ClanakId == search.ClanakId && s.Pacijent.PacijentId == search.PacijentId);
            }

            var list = query.ToList();
            return _mapper.Map<List<Model.Ocjena>>(list);
        }
    }
}
