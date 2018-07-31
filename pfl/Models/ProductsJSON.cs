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
            public List<ProductsJSON> ProductList { get; set; }
        }

        //Stores each individual product and it's prices 
        public class ProductsJSON
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("productID")]
            public int ProductID { get; set; }

            [JsonProperty("sku")]
            public string Sku { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("imageURL")]
            public string ImageURL { get; set; }

            [JsonProperty("hasTemplate")]
            public bool HasTemplate { get; set; }

            [JsonProperty("quantityDefault")]
            public int QuantityDefault { get; set; }

            [JsonProperty("quantityIncrement")]
            public int? QuantityIncrement { get; set; }

            [JsonProperty("quantityMaximum")]
            public int? QuantityMaximum { get; set; }

            [JsonProperty("quantityMinimum")]
            public int? QuantityMinimum { get; set; }

            [JsonProperty("shippingMethodDefault")]
            public string ShippingMethodDefault { get; set; }

            [JsonProperty("emailTemplateId")]
            public string EmailTemplateId { get; set; }

            [JsonProperty("lastUpdated")]
            public string LastUpdated { get; set; }

            [JsonProperty("deliveredPrices")]
            public List<ProductPrice> Prices { get; set; }

            [JsonProperty("productionSpeeds")]
            public List<ProductSpeed> ProdSpeeds { get; set; }

            [JsonProperty("productFormat")]
            public string ProdFormat { get; set; }

            [JsonProperty("productRestrictionType")]
            public string RestrictType { get; set; }
        }

        //JSON object that will store the deliveredPrices from the GET request for each product
        public class ProductPrice
        {
            [JsonProperty("deliveryMethodCode")]
            public string DeliveryMethodCode { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("isDefault")]
            public bool IsDefault { get; set; }

            [JsonProperty("locationType")]
            public string LocationType { get; set; }

            [JsonProperty("price")]
            public float Price { get; set; }

            [JsonProperty("country")]
            public string Country { get; set; }

            [JsonProperty("countryCode")]
            public string CountryCode { get; set; }

            [JsonProperty("created")]
            public string Created { get; set; }
        }

        //JSON object that stores how long a product will take to be produced
        public class ProductSpeed
        {
        [JsonProperty("days")]
        public int Days { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }
        }


}