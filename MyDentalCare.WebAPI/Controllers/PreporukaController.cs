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
    public class PreporukaController : ControllerBase
    {
        private readonly IPreporukaService _service;

        public PreporukaController(IPreporukaService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public List<Model.Clanak> Get(int id)
        {
            return _service.GetPreporuka(id);
        }
    }
}
