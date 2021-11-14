using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace API_SampleFP.Services
{
    public interface ICurrencyApi
    {
        [Get("/api/Currency")]
        Task<HttpResponseMessage> GetCurrenciesAsync();
    }
}
