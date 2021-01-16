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
    public class PregledController : BaseCRUDController<Model.Pregled, PregledSearchRequest, PregledUpsertRequest, PregledUpsertRequest>
    {
        public PregledController(ICRUDService<Model.Pregled, PregledSearchRequest, PregledUpsertRequest, PregledUpsertRequest> service) : base(service)
        {
        }
    }
}
