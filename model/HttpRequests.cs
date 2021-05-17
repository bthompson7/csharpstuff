using System;
using System.Net;
using System.Net.Http;

namespace csharp
{
    public class HttpRequests
    {
        private string baseURL = "https://api.genderize.io/?name=";

        public HttpRequests(){

        }


        public void makeGetRequest(string name){
            if(string.IsNullOrEmpty(name)){
                throw new Exception("The string you enterted is null or empty, please enter a valid string and try again.");
            }

            string fullURL = baseURL + name;
            
            Console.WriteLine("Making API Call for " + fullURL);
            using (var client = new HttpClient(new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate }))
            {
                client.BaseAddress = new Uri(fullURL);
                HttpResponseMessage response = client.GetAsync(fullURL).Result;
                string result = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine("Result: " + result + "\nHttp Status: " + response.StatusCode);
            }
            
        }

    }
}