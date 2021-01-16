using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;
using MyDentalCare.WebAPI.Services;
using MyDentalCare.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using MyDentalCare.WebAPI.Filters;
using MyDentalCare.Model.Requests;
using Microsoft.AspNetCore.Authentication;
using MyDentalCare.WebAPI.Security;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.Swagger;

namespace MyDentalCare.WebAPI
{
	//public class BasicAuthDocumentFilter : IDocumentFilter
	//{
	//	public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
	//	{
	//		var securityRequirements = new Dictionary<string, IEnumerable<string>>()
	//	{
	//		{ "basic", new string[] { } }  // in swagger you specify empty list unless using OAuth2 scopes
 //         };

	//		swaggerDoc.Security = new[] { securityRequirements };
	//	}
	//}
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc(x => x.Filters.Add<ErrorFilter>());
			services.AddControllers();
			services.AddAutoMapper(typeof(Startup));
			services.AddSwaggerGen(c=>
			{
				c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "My API", Version = "v1" });
				c.AddSecurityDefinition("basicAuth", new OpenApiSecurityScheme
				{
					Type = SecuritySchemeType.Http,
					Scheme = "basic"
				});
				// AddSecurityRequirement
				c.AddSecurityRequirement(new OpenApiSecurityRequirement
				{
					{
						new OpenApiSecurityScheme
						{
							Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme , Id = "basicAuth"}
						},
						new string[]{ }
					}
				});
				//c.DocumentFilter<BasicAuthDocumentFilter>();
			});
			
			services.AddAuthentication("BasicAuthentication")
			   .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

			services.AddScoped<IKorisnikService, KorisnikService>();
			services.AddScoped<IPacijentService, PacijentService>();
			services.AddScoped<IPreporukaService, PreporukaService>();

			services.AddScoped<IService<Model.Drzava, object>, BaseService<Model.Drzava, object, Drzava>>();
			services.AddScoped<IService<Model.Pacijent, object>, BaseService<Model.Pacijent, object, Pacijent>>();
			services.AddScoped<IService<Model.Uloga, object>, BaseService<Model.Uloga, object, Uloga>>();

			services.AddScoped<ICRUDService<Model.Grad, GradSearchRequest, GradUpsertRequest, GradUpsertRequest>, GradService>();
			services.AddScoped<ICRUDService<Model.Adresa, AdresaSearchRequest, AdresaUpsertRequest, AdresaUpsertRequest>, AdresaService>();
			services.AddScoped<ICRUDService<Model.StomatoloskaOrdinacija, StomatoloskaOrdinacijaSearchRequest, StomatoloskaOrdinacijaUpsertRequest, StomatoloskaOrdinacijaUpsertRequest>, StomatoloskaOrdinacijaService>();
			services.AddScoped<ICRUDService<Model.Usluga, UslugaSearchRequest, UslugaUpsertRequest, UslugaUpsertRequest>, UslugaService>();
			services.AddScoped<ICRUDService<Model.Lijek, LijekSearchRequest, LijekUpsertRequest, LijekUpsertRequest>, LijekService>();
			services.AddScoped<ICRUDService<Model.Dijagnoza, DijagnozaSearchRequest, DijagnozaUpsertRequest, DijagnozaUpsertRequest>, DijagnozaService>();
			services.AddScoped<ICRUDService<Model.Kategorija, KategorijaSearchRequest, KategorijaUpsertRequest, KategorijaUpsertRequest>, KategorijaService>();
			services.AddScoped<ICRUDService<Model.Clanak, ClanakSearchRequest, ClanakUpsertRequest, ClanakUpsertRequest>, ClanakService>();
			services.AddScoped<ICRUDService<Model.Rezervacija, RezervacijaSearchRequest, RezervacijaUpsertRequest, RezervacijaUpsertRequest>, RezervacijaService>();
			services.AddScoped<ICRUDService<Model.Pregled, PregledSearchRequest, PregledUpsertRequest, PregledUpsertRequest>, PregledService>();
			services.AddScoped<ICRUDService<Model.MedicinskiKarton, MedicinskiKartonSearchRequest, MedicinskiKartonUpsertRequest, MedicinskiKartonUpsertRequest>, MedicinskiKartonService>();
			services.AddScoped<ICRUDService<Model.Ocjena, OcjenaSearchRequest, OcjenaUpsertRequest, OcjenaUpsertRequest>, OcjenaService>();

			//var connection = @"Server=localhost;Database=MyDentalCare;Trusted_Connection=True;";
			var connection = Configuration.GetConnectionString("MyDentalCare");
			services.AddDbContext<MyDentalCareContext>(options => options.UseSqlServer(connection));
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			// app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});

			// Enable middleware to serve generated Swagger as a JSON endpoint.
			app.UseSwagger();

			// Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
			// specifying the Swagger JSON endpoint.
			app.UseSwaggerUI(c =>
			{
				c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
			});

			app.UseAuthentication();
		}
	}
}
