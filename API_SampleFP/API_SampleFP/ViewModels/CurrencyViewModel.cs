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
using System.Net.Http;
using System.Text.Json;

namespace API_SampleFP.ViewModels
{
    public class CurrencyViewModel : BaseViewModel
    {
        
        ICurrencyApiService _currencyApiService;
        public string Loading { get; set; }
        public ObservableCollection<CurrencyResponse> CurrenciesList { get; set; } = new ObservableCollection<CurrencyResponse>() { };
        public CurrencyViewModel(ICurrencyApiService currencyApiService)
        {
            _currencyApiService = currencyApiService;
            Loading = "Loading...";
            Task.Run(async () => {
                await LoadCurrenciesAsync();
                Loading = "";
            });
           
        }

        private async Task LoadCurrenciesAsync()
        {
            var currencyResponse = await _currencyApiService.GetCurrenciesAsync();
            if (currencyResponse != null)
            {
                var responseString = await currencyResponse.Content.ReadAsStringAsync();
                var currencyList = JsonSerializer.Deserialize<List<CurrencyResponse>>(responseString, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

               
                foreach (var currency in currencyList)
                {
                    CurrenciesList.Add(new CurrencyResponse()
                    {
                        Name = currency.Name,
                        Purchase = Convert.ToDouble(currency.Purchase),
                        Sale = Convert.ToDouble(currency.Sale)
                    });
                   
                }
            }
        }
    }
}
