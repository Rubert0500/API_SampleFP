using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Collections;

namespace API_SampleFP.Models
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class CurrencyResponse
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("purchase")]
        public double Purchase { get; set; }

        [JsonPropertyName("sale")]
        public double Sale { get; set; }
    }


}
