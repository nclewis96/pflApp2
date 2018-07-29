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
    //Class will handle both the GET and POST requests 
    public class Requester
    {

        //Log in information for the API
        private static string username = "miniproject";
        private static string password = "Pr!nt123";
        //List of products returned by the GET request
        private static List<ProductsJSON> prodList;

        //Default Constructor that will use the projects default url/user/pass
        public Requester() { }

        //Alternate constructor that will allow a new/different url/user/pass
        public Requester(string newUser, string newPass)
        {
            username = newUser;
            password = newPass;
        }
            

        //Calls a GET HTTP request on the /products/ endpoint, and returns all 
        //of the products gathered through the GET
        public List<ProductsJSON> GetAllProducts()
        {
            
            GetRequest(@"https://testapi.pfl.com/products?apikey=136085");
            return prodList;
        }

        public List<ProductsJSON> GetSingleProduct(int id)
        {
            GetRequest(@"https://testapi.pfl.com/products/" + id + "?apikey=136085");
            return prodList;
        }

        //Handles the HTTP GET request
        public static void GetRequest(string url)
        {
            //Sets up Request, including Auth Header
            string authInfo = username + ":" + password;
            authInfo = Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(authInfo));
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers["Authorization"] = "Basic" + authInfo;
            try
            {
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
            }
            catch (Exception ex)
            {
               Console.WriteLine(ex);
            }
        }//end getRequest

        

        //Handles the HTTP POST request
        async static void PostRequest()
        {

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(@"https://testapi.pfl.com/products?apikey=136085"))
                {
                    using (HttpContent content = response.Content)
                    {


                    }//content is disposed
                }//response is disposed
            }//client is disposed   
        }//end postRequest
    }
}