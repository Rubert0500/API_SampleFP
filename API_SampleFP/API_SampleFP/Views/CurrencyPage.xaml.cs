using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using API_SampleFP.Services;
using API_SampleFP.ViewModels;

namespace API_SampleFP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CurrencyPage : ContentPage
    {
        public CurrencyPage()
        {
            InitializeComponent();
            BindingContext = new CurrencyViewModel(new CurrencyApiService());
        }
    }
}