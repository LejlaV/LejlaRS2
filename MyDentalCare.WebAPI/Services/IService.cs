using MyDentalCare.WebAPI.Database;
using MyDentalCare.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyDentalCare.Model.Requests;
namespace MyDentalCare.WebAPI.Services
{
    public interface IService<T, TSearch>
    {
        List<T> Get(TSearch search);
        T GetById(int id);
    }
}
