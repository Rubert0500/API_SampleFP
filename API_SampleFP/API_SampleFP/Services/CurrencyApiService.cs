using API_SampleFP.Models;
using APISample.Services;
using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace API_SampleFP.Services
{
    public class CurrencyApiService : ICurrencyApiService
    {
        IJsonSerializerService serializer = new JsonSerializerService();
        public async Task<List<CurrencyResponse>> GetCurrenciesAsync()
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync($"http://eladio37-001-site1.ftempurl.com/api/Currency");

            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                var currencyResponse = serializer.Deserialize<List<CurrencyResponse>>(responseString);
                return currencyResponse;
            }

            return null;
        }


    }
}
