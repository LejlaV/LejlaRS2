using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyDentalCare.Model.Requests;

namespace MyDentalCare.WebAPI.Mappers
{
	public class Mapper : Profile
	{
		public Mapper()
		{
			CreateMap<Database.Korisnik, Model.Korisnik>();
			CreateMap<Database.Korisnik, KorisnikInsertRequest>().ReverseMap();

			CreateMap<Database.Pacijent, Model.Pacijent>();
			CreateMap<Database.Pacijent, PacijentUpsertRequest>().ReverseMap();
			
			CreateMap<Database.Korisnik, Model.KorisnikLogin>();
			CreateMap<Database.Pacijent, Model.KorisnikLogin>();

			CreateMap<Database.Uloga, Model.Uloga>();

			CreateMap<Database.KorisnikUloga, Model.KorisnikUloge>().ReverseMap();
			CreateMap<List<Database.KorisnikUloga>, List<Model.KorisnikUloge>>().ReverseMap();

			CreateMap<ICollection<Database.KorisnikUloga>, List<Model.KorisnikUloge>>().ReverseMap();
			CreateMap<List<Model.KorisnikUloge>, ICollection<Database.KorisnikUloga>>().ReverseMap();

			CreateMap<Database.Usluga, Model.Usluga>();
			CreateMap<UslugaUpsertRequest, Database.Usluga>();

			CreateMap<Database.Lijek, Model.Lijek>();
			CreateMap<LijekUpsertRequest, Database.Lijek>();

			CreateMap<Database.Dijagnoza, Model.Dijagnoza>();
			CreateMap<DijagnozaUpsertRequest, Database.Dijagnoza>();

			CreateMap<Database.Kategorija, Model.Kategorija>();
			CreateMap<KategorijaUpsertRequest, Database.Kategorija>();

			CreateMap<Database.Clanak, Model.Clanak>();
			CreateMap<ClanakUpsertRequest, Database.Clanak>();

			CreateMap<Database.Rezervacija, Model.Rezervacija>();
			CreateMap<RezervacijaUpsertRequest, Database.Rezervacija>();

			CreateMap<Database.Pregled, Model.Pregled>();
			CreateMap<PregledUpsertRequest, Database.Pregled>();

			CreateMap<Database.MedicinskiKarton, Model.MedicinskiKarton>();
			CreateMap<MedicinskiKartonUpsertRequest, Database.MedicinskiKarton>();

			CreateMap<Database.Ocjena, Model.Ocjena>();
			CreateMap<OcjenaUpsertRequest, Database.Ocjena>();
		}
	}
}
