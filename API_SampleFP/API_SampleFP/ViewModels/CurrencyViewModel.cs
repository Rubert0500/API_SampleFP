using API_SampleFP.Services;
using API_SampleFP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using System.Linq;
using Refit;
using APISample.Services;
using System.Net.Http;

namespace API_SampleFP.ViewModels
{
    public class CurrencyViewModel : BaseViewModel
    {
        IJsonSerializerService serializer = new JsonSerializerService();
        ICurrencyApiService _currencyApiService;
        public List<CurrencyResponse> CurrenciesList { get; set; } = new List<CurrencyResponse>();
        public CurrencyViewModel(ICurrencyApiService currencyApiService)
        {
            _currencyApiService = currencyApiService;
            GetCurrencies();
        }

        private async void GetCurrencies()
        {
            var currencyResponse = await _currencyApiService.GetCurrenciesAsync();
            if (currencyResponse != null)
            {
                CurrenciesList = currencyResponse;
            }
        }
    }
}
