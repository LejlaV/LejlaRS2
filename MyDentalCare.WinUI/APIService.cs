using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDentalCare.Model;
using MyDentalCare.Model.Requests;
using System.Windows.Forms;

namespace MyDentalCare.WinUI
{
	public class APIService
	{
		public static string Username { get; set; }
		public static string Password { get; set; }

		public string _route = null;
		public APIService(string route)
		{
			_route = route;
		}

		public async Task<T> Get<T>(object search)
		{
			var url =  $"{Properties.Settings.Default.APIUrl}/{_route}";
			try
			{
				if (search != null)
				{
					url += "?";
					url += await search.ToQueryString();
				}
			}
			catch(FlurlHttpException ex)
			{
				if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
				{
					MessageBox.Show("Niste authentificirani");
				}
				throw;
			}
			var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
			return result;
		}

		public async Task<T> GetById<T>(object Id)
		{
			var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{Id}";

			var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
			return result;
		}

		public async Task<T> Insert<T>(object request)
		{
			var url = $"{Properties.Settings.Default.APIUrl}/{_route}";

			var result = await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
			return result;
		}

		public async Task<T> Update<T>(int? id, object request)
		{
			var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

			var result = await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
			return result;
		}
	}
}
