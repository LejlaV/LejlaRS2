﻿using Flurl.Http;
using MyDentalCare.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyDentalCare.Mobile
{
	public class APIService
	{
		public static string Username { get; set; }
		public static string Password { get; set; }

		//public string _route = null;
		private readonly string _route;

#if DEBUG
		private string _apiURL = "http://localhost:44369/api";
#endif
#if RELEASE
		private string apiURL = "http://MyDentalCare.com/api/";
#endif
		public APIService(string route)
		{
			_route = route;
		}

		public async Task<T> Get<T>(object search)
		{
			var url = $"{_apiURL}/{_route}";

			try
			{
				if (search != null)
			{
				url += "?";
				url += await search.ToQueryString();
			}
			return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
			}
			catch (FlurlHttpException ex)
			{
				if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
				{
					await Application.Current.MainPage.DisplayAlert("Greška", "Niste autentificirani", "OK");
				}
				throw;
			}
		}
		public async Task<T> GetById<T>(object Id)
		{
			var url = $"{_apiURL}/{_route}/{Id}";

			return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
		}
		public async Task<T> Insert<T>(object request)
		{
			var url = $"{_apiURL}/{_route}";

			try
			{
				return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
			}
			catch (FlurlHttpException ex)
			{
				var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

				var stringBuilder = new StringBuilder();
				foreach (var error in errors)
				{
					stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
				}

				await Application.Current.MainPage.DisplayAlert("Greška", stringBuilder.ToString(), "OK");
				return default(T);
			}

		}
		public async Task<T> Update<T>(int? id, object request)
		{
			try
			{
				var url = $"{_apiURL}/{_route}/{id}";

			return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
			}
			catch (FlurlHttpException ex)
			{
				var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

				var stringBuilder = new StringBuilder();
				foreach (var error in errors)
				{
					stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
				}

				await Application.Current.MainPage.DisplayAlert("Greška", stringBuilder.ToString(), "OK");
				return default(T);
			}
		}

		public async Task<T> Delete<T>(int id)
		{
			try
			{
				var url = $"{_apiURL}/{_route}/{id}";

			return await url.WithBasicAuth(Username, Password).DeleteAsync().ReceiveJson<T>();
			}
			catch (FlurlHttpException ex)
			{
				var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

				var stringBuilder = new StringBuilder();
				foreach (var error in errors)
				{
					stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
				}

				await Application.Current.MainPage.DisplayAlert("Greska", stringBuilder.ToString(), "OK");
				return default(T);
			}
		}

		public async Task<T> GetPublic<T>(object search)
		{
			var url = $"{_apiURL}/{_route}";

			try
			{
				if (search != null)
				{
					url += "?";
					url += await search.ToQueryString();
				}
				return await url.GetJsonAsync<T>();
			}
			catch (FlurlHttpException ex)
			{
				if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
				{
					await Application.Current.MainPage.DisplayAlert("Greška", "Niste autentificirani", "OK");
				}
				throw;
			}
		}
	}
}
