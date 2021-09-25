using API_SampleFP.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace API_SampleFP.Services
{
    public interface ICurrencyApiService
    {
        Task<List<CurrencyResponse>> GetCurrenciesAsync();
    }
}
