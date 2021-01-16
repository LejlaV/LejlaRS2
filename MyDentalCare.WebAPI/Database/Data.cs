using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyDentalCare.WebAPI.Database
{
    public class Data
    {
        public static void Seed(MyDentalCareContext context)
        {
            context.Database.Migrate();
        }
    }
}
