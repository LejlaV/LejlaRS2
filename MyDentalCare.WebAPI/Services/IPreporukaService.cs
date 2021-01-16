using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyDentalCare.Model;

namespace MyDentalCare.WebAPI.Services
{
	public interface IPreporukaService
	{
		List<Clanak> GetPreporuka(int id);
	}
}
