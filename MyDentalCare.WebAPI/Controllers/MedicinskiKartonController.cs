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
using Microsoft.AspNetCore.Authorization;

namespace MyDentalCare.WebAPI.Controllers
{
    public class MedicinskiKartonController : BaseCRUDController<Model.MedicinskiKarton, MedicinskiKartonSearchRequest, MedicinskiKartonUpsertRequest, MedicinskiKartonUpsertRequest>
    {
        public MedicinskiKartonController(ICRUDService<Model.MedicinskiKarton, MedicinskiKartonSearchRequest, MedicinskiKartonUpsertRequest, MedicinskiKartonUpsertRequest> service) : base(service)
        {
        }
    }
}
