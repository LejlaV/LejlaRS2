using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyDentalCare.Model.Requests;

namespace MyDentalCare.WebAPI.Services
{
	public interface IPacijentService
	{
		List<Model.Pacijent> Get(PacijentSearchRequest request);
		Model.Pacijent GetById(int Id);
		Model.Pacijent Insert(PacijentUpsertRequest request);
		Model.Pacijent Update(int id, PacijentUpsertRequest request);
		Model.Pacijent AuthenticirajPacijenta(string username, string pass);
	}
}
