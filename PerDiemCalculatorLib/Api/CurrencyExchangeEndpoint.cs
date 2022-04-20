using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;
using PerDiemCalculatorLib.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PerDiemCalculatorLib.Api
{
    public interface ICurrencyExchangeEndpoint
    {
        Task<decimal> GetExchangeRate(string currency);
    }

    public class CurrencyExchangeEndpoint : ICurrencyExchangeEndpoint
    {
        private IApiHelper _apiHelper;

        public CurrencyExchangeEndpoint()
        {
            _apiHelper = new ApiHelper();
        }

        public CurrencyExchangeEndpoint(IApiHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }

        public async Task<decimal> GetExchangeRate(string currency)
        {
            if (currency.Length != 3)
            {
                throw new ArgumentException("Invalid currency");
            }

            var query = new Dictionary<string, string>
            {
                ["apiKey"] = ConfigurationManager.AppSettings["apiKey"],
                ["compact"] = "ultra",
                ["q"] = $"{ currency }_{ ConfigurationManager.AppSettings["currency"] }",
            };

            using (HttpResponseMessage response = await _apiHelper.ApiClient.GetAsync(QueryHelpers.AddQueryString("/api/v7/convert/", query)))
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                var dictResponse = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonResponse);

                if (response.IsSuccessStatusCode)
                {
                    var exchangeRatio = decimal.Parse(dictResponse.First().Value);
                    return exchangeRatio;
                }
                else
                {
                    var errorMessage = new ErrorMessageModel()
                    {
                        Caption = response.StatusCode.ToString(),
                        Text = dictResponse["error"],
                    };

                    var message = JsonConvert.SerializeObject(errorMessage);
                    throw new Exception(message);
                }
            }
        }
    }
}