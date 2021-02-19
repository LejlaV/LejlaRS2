using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MyDentalCare.Model;
using MyDentalCare.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyDentalCare.WebAPI.Services
{
	public class LoginService : ILoginService
	{
		private readonly MyDentalCareContext _context;
		private readonly IMapper _mapper;

		public LoginService(MyDentalCareContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		public KorisnikLogin Authenticiraj(string username, string pass)
		{
			var user = _context.Korisnik.Where(x => x.KorisnickoIme == username).FirstOrDefault();

			if (user != null)
			{
				var listaUloga = _context.KorisnikUloga.Where(x => x.KorisnikId == user.KorisnikId).Include(x => x.Uloga).ToList();
			
			KorisnikLogin userModel = new KorisnikLogin()
			{
				KorisnikUloge = _mapper.Map<ICollection<Model.KorisnikUloge>>(listaUloga),
			    Ime = user.Ime,
				Prezime = user.Prezime,
				KorisnickoIme = user.KorisnickoIme,
				Email = user.Email,
				Telefon = user.BrojTelefona
			};

			var newHash = GenerateHash(user.PasswordSalt, pass);

				if (newHash == user.PasswordHash)
				{
					return userModel;
				}
			}
			return null;
		}

		public KorisnikLogin AuthenticirajPacijenta(string username, string pass)
		{
			var user = _context.Pacijent.Where(x => x.KorisnickoIme == username).FirstOrDefault();

			if (user != null)
			{
				var newHash = GenerateHash(user.PasswordSalt, pass);

				if (newHash == user.PasswordHash)
				{
					return _mapper.Map<Model.KorisnikLogin>(user);
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

			SHA1 algorithm = SHA1.Create("SHA1");
			byte[] inArray = algorithm.ComputeHash(dst);
			return Convert.ToBase64String(inArray);
		}
	}
}
