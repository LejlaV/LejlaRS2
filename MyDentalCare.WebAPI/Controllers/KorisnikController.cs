using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;
using MyDentalCare.WebAPI.Database;
using MyDentalCare.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyDentalCare.Model.Requests;
using Microsoft.AspNetCore.Authorization;

namespace MyDentalCare.WebAPI.Controllers
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class KorisnikController : ControllerBase
	{
		private readonly IKorisnikService _service;
		public KorisnikController(IKorisnikService service)
		{
			_service = service;
		}
		[HttpGet]
		public ActionResult<List<Model.Korisnik>> Get([FromQuery]KorisnikSearchRequest request)
		{
			return _service.Get(request);
		}
		[HttpGet("{Id}")]
		public ActionResult<Model.Korisnik> GetById(int Id)
		{
			return _service.GetById(Id);
		}
		[Authorize(Roles = "administrator")]
		[HttpPost]
		public Model.Korisnik Insert(KorisnikInsertRequest request)
		{
			return _service.Insert(request);
		}

		[Authorize(Roles = "administrator")]
		[HttpPut("{id}")]
		public Model.Korisnik Update(int id, KorisnikInsertRequest request)
		{
			return _service.Update(id, request);
		}
	}
}
