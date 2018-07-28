using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.IO;
using System.Net;
using System.Net.Http;

namespace pfl.Models
{
    public class requester
    {
        private static string url = @"https://testapi.pfl.com/products?apikey=136085";
        private static string username = "miniproject";
        private static string password = "Pr!nt123";
        private static List<ProductsJSON> prodList;

        //Calls the  GET HTTP request, and returns all 
        //of the products gathered through the GET
        public List<ProductsJSON> GetProducts()
        {
            GetRequest();
            return prodList;
        }

        //Handles the HTTP GET request
        public static void GetRequest()
        {
            //Sets up Request, including Auth Header
            string authInfo = username + ":" + password;
            authInfo = Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(authInfo));
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers["Authorization"] = "Basic" + authInfo;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (var resStream = new StreamReader(response.GetResponseStream()))
                {
                    JavaScriptSerializer js = new JavaScriptSerializer();
                    var objText = resStream.ReadToEnd();
                    RootObj obj = (RootObj)js.Deserialize(objText, typeof(RootObj));
                    foreach (ProductsJSON pj in obj.Results.productList)
                    {
                        prodList.Add(pj);
                    }//Ends the For Each, all of the JSON objects should be added to the Prod List
                }//dispose of resStream
            }//dispose of response
        }//end getRequest

        //Handles the HTTP POST request
        async static void PostRequest()
        {

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(url))
                {
                    using (HttpContent content = response.Content)
                    {


                    }//content is disposed
                }//response is disposed
            }//client is disposed   
        }//end postRequest
    }
}