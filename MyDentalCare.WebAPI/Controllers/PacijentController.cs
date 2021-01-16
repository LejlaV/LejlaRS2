using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;
using MyDentalCare.WebAPI.Database;
using MyDentalCare.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyDentalCare.Model.Requests;
using AutoMapper;
using MyDentalCare.Model;

namespace MyDentalCare.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacijentController : ControllerBase
    {
        private readonly IPacijentService _service;

        public PacijentController(IPacijentService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Model.Pacijent>> Get([FromQuery]PacijentSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{Id}")]
        public ActionResult<Model.Pacijent> GetById(int Id)
        {
            return _service.GetById(Id);
        }

        [HttpPost]
        public Model.Pacijent Insert(PacijentUpsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public Model.Pacijent Update(int id, [FromBody]PacijentUpsertRequest request)
        {
            return _service.Update(id, request);
        }
    }
}
