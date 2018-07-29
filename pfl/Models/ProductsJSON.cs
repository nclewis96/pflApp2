using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

//Class will be used to store and access the data returned from the GET request
namespace pfl.Models
{
        //Entire JSON object returned from the API when a GET is sent
        public class RootObj
        {
            [JsonProperty("results")]
            public Results Results { get; set; }
        }

        //Stores results section of the JSON object, includes all products
        public class Results
        {
            [JsonProperty("data")]
            public List<ProductsJSON> productList { get; set; }
        }

        //Stores each individual product and it's prices 
        public class ProductsJSON
        {
            [JsonProperty("id")]
            public int id { get; set; }

            [JsonProperty("productID")]
            public int productID { get; set; }

            [JsonProperty("sku")]
            public string sku { get; set; }

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

            [JsonProperty("emailTemplateId")]
            public string emailTemplateId { get; set; }

            [JsonProperty("lastUpdated")]
            public string lastUpdated { get; set; }

            [JsonProperty("deliveredPrices")]
            public List<ProductPrice> Prices { get; set; }

            [JsonProperty("productionSpeeds")]
            public ProductSpeed prodSpeed { get; set; }

            [JsonProperty("productFormat")]
            public string prodFormat { get; set; }

            [JsonProperty("productRestrictionType")]
            public string restrictType { get; set; }
        }

        //JSON object that will store the deliveredPrices from the GET request for each product
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

        //JSON object that stores how long a product will take to be produced
        public class ProductSpeed
        {
        [JsonProperty("days")]
        public int days { get; set; }

        [JsonProperty("isDefault")]
        public bool isDefault { get; set; }
        }


}