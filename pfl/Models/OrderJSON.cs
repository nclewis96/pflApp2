using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace pfl.Models
{
    
    public class OrderJSON
    {
        [JsonProperty("partnerOderReference")]
        public int PartnerOderReference { get; set; }

        [JsonProperty("orderCustomer")]
        public CustomerInfo OrderCustomer { get; set; }

        [JsonProperty("items")]
        public List<OrderItem> Items { get; set; }

        [JsonProperty("shipments")]
        public List<ShipmentInfo> Shipments { get; set; }

        [JsonProperty("payments")]
        public List<PaymentInfo> Payments { get; set; }

        [JsonProperty("itemShipments")]
        public List<ItemShipmentInfo> ItemShipments { get; set; }

        [JsonProperty("webhooks")]
        public List<WebhookInfo> Webhooks { get; set; }

        [JsonProperty("billingVariables")]
        public List<billingVar> BillingVariables { get; set; }

    }

    public class CustomerInfo
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public int Phone { get; set; }
    }

    public class OrderItem
    {
        [JsonProperty("itemSequenceNumber")]
        public int ItemSequenceNumber { get; set; }

        [JsonProperty("productID")]
        public int ProductId { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("productionDays")]
        public int ProductionDays { get; set; }

        [JsonProperty("partnerItemReference")]
        public string PartnerItemReference { get; set; }

        [JsonProperty("itemFile")]
        public string ItemFile { get; set; }
    }

    public class ShipmentInfo
    {
        [JsonProperty("shipmentSequenceNumber")]
        public int ShipmentSequenceNumber { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("phone")]
        public int Phone { get; set; }

        [JsonProperty("shippingMethod")]
        public string ShippingMethod { get; set; }

        [JsonProperty("IMBSerialNumber")]
        public string IMBSerialNumber { get; set; }
    }

    public class PaymentInfo
    {
        [JsonProperty("paymentMethod")]
        public string PaymentMethod { get; set; }

        [JsonProperty("paymentID")]
        public string PaymentId { get; set; }

        [JsonProperty("paymentAmount")]
        public decimal paymentAmount { get; set; }
    }

    public class ItemShipmentInfo
    {
        [JsonProperty("itemSequenceNumber")]
        public int ItemSequenceNumber { get; set; }

        [JsonProperty("shipmentSequenceNumber")]
        public int ShipmentSequenceNumber { get; set; }
    }

    public class WebhookInfo
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("callbackUri")]
        public string CallBackUri { get; set; }

        //Not sure how this is structured in practice
        [JsonProperty("callbackHeaders")]
        public string CallBackHeader { get; set; }

    }


    public class billingVar
    {
        [JsonProperty("key")]
        public string Key { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}