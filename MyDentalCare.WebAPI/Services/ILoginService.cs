using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyDentalCare.WebAPI.Services
{
	public interface ILoginService
	{
		Model.KorisnikLogin Authenticiraj(string username, string pass);
		Model.KorisnikLogin AuthenticirajPacijenta(string username, string pass);
	}
}
