using API_SampleFP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace API_SampleFP.Services
{
    public interface ICurrencyApiService
    {
        Task<HttpResponseMessage> GetCurrenciesAsync();
    }
}
