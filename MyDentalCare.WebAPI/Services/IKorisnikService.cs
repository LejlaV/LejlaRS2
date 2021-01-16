using MyDentalCare.WebAPI.Database;
using MyDentalCare.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyDentalCare.Model.Requests;

namespace MyDentalCare.WebAPI.Services
{
	public interface IKorisnikService
	{
		List<Model.Korisnik> Get(KorisnikSearchRequest request);
		Model.Korisnik GetById(int Id);
		Model.Korisnik Insert(KorisnikInsertRequest request);
		Model.Korisnik Update(int id, KorisnikInsertRequest request);
		Model.Korisnik Authenticiraj(string username, string pass);
	}
}
