﻿using Newtonsoft.Json;

namespace Stubsharp.Models
{
    public class Currency
    {
        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("currency")]
        public string CurrencyCode { get; set; }
    }
}