using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MyDentalCare.Model.Requests;
using MyDentalCare.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyDentalCare.WebAPI.Services
{
    public class GradService : BaseCRUDService<Model.Grad, GradSearchRequest, Database.Grad, GradUpsertRequest, GradUpsertRequest>
    {

        public GradService(MyDentalCareContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Grad> Get(GradSearchRequest search)
        {
            var query = _context.Grad.Include(i => i.Drzava).AsQueryable();

            if (search?.DrzavaId != 0)
            {
                query = query.Where(x => x.Drzava.DrzavaId == search.DrzavaId);
            }
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                query = query.Where(x => x.Naziv == search.Naziv);
            }
            if (!string.IsNullOrWhiteSpace(search?.PostanskiBroj))
            {
                query = query.Where(x => x.PostanskiBroj == search.PostanskiBroj);
            }
            var list = query.ToList();
            var result = _mapper.Map<List<Model.Grad>>(list);
            return result;
        }
    }
}
