using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace pfl.Models
{
    
        public class RootObj
        {
            [JsonProperty("results")]
            public Results Results { get; set; }
        }

        public class Results
        {
            [JsonProperty("data")]
            public List<ProductsJSON> productList { get; set; }
        }

        public class ProductsJSON
        {
            [JsonProperty("id")]
            public int id { get; set; }

            [JsonProperty("productID")]
            public int productID { get; set; }

            [JsonProperty("name")]
            public string name { get; set; }

            [JsonProperty("description")]
            public string description { get; set; }

            [JsonProperty("imageURL")]
            public string imageURL { get; set; }

            [JsonProperty("hasTemplate")]
            public bool hasTemplate { get; set; }

            [JsonProperty("quantityDefault")]
            public int quantityDefault { get; set; }

            [JsonProperty("quantityIncrement")]
            public int quantityIncrement { get; set; }

            [JsonProperty("quantityMaximum")]
            public int quantityMaximum { get; set; }

            [JsonProperty("quantityMinimum")]
            public int quantityMinimum { get; set; }

            [JsonProperty("shippingMethodDefault")]
            public string shippingMethodDefault { get; set; }

            [JsonProperty("deliveredPrices")]
            public List<ProductPrice> Prices { get; set; }
        }

        public class ProductPrice
        {
            [JsonProperty("deliveryMethodCode")]
            public string deliveryMethodCode { get; set; }

            [JsonProperty("description")]
            public string description { get; set; }

            [JsonProperty("isDefault")]
            public bool isDefault { get; set; }

            [JsonProperty("locationType")]
            public string locationType { get; set; }

            [JsonProperty("price")]
            public float price { get; set; }

            [JsonProperty("country")]
            public string country { get; set; }

            [JsonProperty("countryCode")]
            public int countryCode { get; set; }

            [JsonProperty("created")]
            public string created { get; set; }
        }
  
}