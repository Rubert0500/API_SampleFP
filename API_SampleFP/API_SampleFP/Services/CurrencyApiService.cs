using API_SampleFP.Models;
using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace API_SampleFP.Services
{
    public class CurrencyApiService : ICurrencyApiService
    {
        public async Task<HttpResponseMessage> GetCurrenciesAsync()
        {
            return await RestService.For<ICurrencyApi>("http://eladio37-001-site1.ftempurl.com").GetCurrenciesAsync();
        }
              
    }
}
