using AutoMapper;
using MyDentalCare.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MyDentalCare.Model.Requests;
using MyDentalCare.WebAPI.Exceptions;

namespace MyDentalCare.WebAPI.Services
{
	public class PacijentService : IPacijentService
	{
		private readonly MyDentalCareContext _context;
		private readonly IMapper _mapper;
		public PacijentService(MyDentalCareContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

        public Model.Pacijent AuthenticirajPacijenta(string username, string pass)
        {
            var user = _context.Pacijent.Where(x => x.KorisnickoIme == username).FirstOrDefault();

            if (user != null)
            {
                var newHash = GenerateHash(user.PasswordSalt, pass);

                if (newHash == user.PasswordHash)
                {
                    return _mapper.Map<Model.Pacijent>(user);
                }
            }
            return null;
        }

		public static string GenerateSalt()
		{
			var buf = new byte[16];
			(new RNGCryptoServiceProvider()).GetBytes(buf);
			return Convert.ToBase64String(buf);
		}

		public static string GenerateHash(string salt, string password)
		{
			byte[] src = Convert.FromBase64String(salt);
			byte[] bytes = Encoding.Unicode.GetBytes(password);
			byte[] dst = new byte[src.Length + bytes.Length];

			System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
			System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

			HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
			byte[] inArray = algorithm.ComputeHash(dst);
			return Convert.ToBase64String(inArray);
		}

		public List<Model.Pacijent> Get(PacijentSearchRequest request)
		{
			var query = _context.Pacijent.AsQueryable();

			if (!string.IsNullOrWhiteSpace(request?.Ime))
			{
				query = query.Where(x => x.Ime.StartsWith(request.Ime));
			}
			if (!string.IsNullOrWhiteSpace(request?.Prezime))
			{
				query = query.Where(x => x.Prezime.StartsWith(request.Prezime));
			}

			var list = query.ToList();
			return _mapper.Map<List<Model.Pacijent>>(list);
		}

		public Model.Pacijent GetById(int Id)
        {
            var entity = _context.Pacijent.Find(Id);
            return _mapper.Map<Model.Pacijent>(entity);
        }

		public Model.Pacijent Insert(PacijentUpsertRequest request)
		{
			var entity = _mapper.Map<Database.Pacijent>(request);

			if (request.Password != request.PasswordConfirmation)
			{
				throw new UserException("Lozinke se ne podudaraju!");
			}

			entity.PasswordSalt = GenerateSalt();
			entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);

			_context.Pacijent.Add(entity);
			_context.SaveChanges();

            var pacijent = new Model.Pacijent()
            {
                Ime = request.Ime,
                Prezime = request.Prezime,
                KorisnickoIme = request.KorisnickoIme,
                Email = request.Email,
                BrojTelefona = request.BrojTelefona,
                DatumRegistracije = request.DatumRegistracije
            };
            _context.SaveChanges();

            return _mapper.Map<Model.Pacijent>(entity);
		}

		public Model.Pacijent Update(int id, PacijentUpsertRequest request)
		{
			var entity = _context.Pacijent.Find(id);
			_context.Pacijent.Attach(entity);
			_context.Pacijent.Update(entity);

			if (!string.IsNullOrWhiteSpace(request.Password))
			{
				if (request.Password != request.PasswordConfirmation)
				{
					throw new Exception("Lozinke se ne podudaraju!");
				}

				entity.PasswordSalt = GenerateSalt();
				entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);
			}

			_mapper.Map(request, entity);

			_context.SaveChanges();

			return _mapper.Map<Model.Pacijent>(entity);
		}
	}
}
