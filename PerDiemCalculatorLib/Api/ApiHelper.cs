using System;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;

namespace PerDiemCalculatorLib.Api
{
    public interface IApiHelper
    {
        HttpClient ApiClient { get; }
    }

    public class ApiHelper : IApiHelper
    {
        private HttpClient _apiClient { get; set; }

        public ApiHelper()
        {
            InitializeClient();
        }

        public HttpClient ApiClient
        {
            get
            {
                return _apiClient;
            }
        }

        private void InitializeClient()
        {
            string apiUrl = ConfigurationManager.AppSettings["apiUrl"];

            _apiClient = new HttpClient();
            _apiClient.BaseAddress = new Uri(apiUrl);
            _apiClient.DefaultRequestHeaders.Accept.Clear();
            _apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}