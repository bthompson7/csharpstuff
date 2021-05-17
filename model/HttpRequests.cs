using System;
using System.Net;
using System.Net.Http;

namespace csharp
{
    public class HttpRequests
    {
        private string url = "https://api.genderize.io/?name=";

        public HttpRequests(){

        }


        public void setURL(string url){
            this.url = url;
        }
        public string getURL(){
            return url;
        }

        public void makeGetRequest(string name){
            if(string.IsNullOrEmpty(name)){
                throw new Exception("The string you enterted is null or empty, please enter a valid string and try again.");
            }

            string fullURL = url + name;
            
            Console.WriteLine("Making API Call using the url " + fullURL);
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