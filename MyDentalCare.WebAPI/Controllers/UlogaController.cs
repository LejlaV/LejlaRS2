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
    public class UlogaController : BaseController<Model.Uloga, object>
    {
        public UlogaController(IService<Model.Uloga, object> service) : base(service)
        {
        }
    }
}
