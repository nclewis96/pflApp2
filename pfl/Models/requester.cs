using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace pfl.Models
{
    //Class will handle both the GET and POST requests 
    public class Requester
    {

        //Log in information for the API
        private static string username = "miniproject";
        private static string password = "Pr!nt123";
        private static string uri = "https://testapi.pfl.com";
        private static HttpClient client = new HttpClient();
        //List of products returned by the GET request
        private static List<ProductsJSON> prodList;

        //Default Constructor that will use the projects default url/user/pass
        public Requester()
        {
            //Sets up Request, including Auth Header
            client.BaseAddress = new Uri(uri);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            string auth = username + ":" + password;
            //Converts the Authorization to base64, and attatches
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                System.Convert.ToBase64String(
                    System.Text.ASCIIEncoding.ASCII.GetBytes(auth)));
        }

        //Alternate constructor that will allow a new/different uri/user/pass
        public Requester(string newUser, string newPass, string uri)
        {
            //Sets up Request, including Auth Header
            client.BaseAddress = new Uri(uri);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            string auth = newUser + ":" + newPass;
            //Converts the Authorization to base64, and attatches
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                System.Convert.ToBase64String(
                    System.Text.ASCIIEncoding.ASCII.GetBytes(auth)));
        }
            

        //Calls a GET HTTP request on the /products/ endpoint, and returns all 
        //of the products gathered through the GET
        public static async Task<RootObj> GetAllProducts()
        {
            return await GetRequest("/products?apikey=136085");
        }

        public static async Task<RootObj> GetSingleProduct(int id)
        {
            return await GetRequest("/products/" + id + "?apikey=136085");
        }

        //Handles the HTTP GET request
        private static async Task<RootObj> GetRequest(string path)
        {
            RootObj products = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                products = await response.Content.ReadAsAsync<RootObj>();
            }
            return products;
        }//end getRequest



        //Handles the HTTP POST request
        //TODO: Change return to Order Number in Response
        static async Task<HttpStatusCode> PostRequest(OrderJSON order)
        {
            //Sends a Post to the order endpoint in the PFL API

            HttpResponseMessage response =
                await client.PostAsJsonAsync($"/orders?apikey=136085", order);
            return response.StatusCode;

        }//end postRequest
    }
}