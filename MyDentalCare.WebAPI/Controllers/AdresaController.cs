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
    public class AdresaController : BaseCRUDController<Model.Adresa, AdresaSearchRequest, AdresaUpsertRequest, AdresaUpsertRequest>
    {
        public AdresaController(ICRUDService<Model.Adresa, AdresaSearchRequest, AdresaUpsertRequest, AdresaUpsertRequest> service) : base(service)
        {
        }
    }
}
