using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    internal class RonVsKanyeApi
    {
        private readonly HttpClient _client;

        public RonVsKanyeApi()
        {
            _client = new HttpClient();
        }
        public string KayneSpeaks()
        {
            //Build URL for the Kayne API
            var kanyeUrl = "https://api.kanye.rest/";
        
            //Using the HTTPClient instance
            //Send a GET request to the url created above, this going to give us back a string of json
            var kanyeResponseJson = _client.GetStringAsync(kanyeUrl).Result;
        
            //Parse the JSON respone string into JObject
            var kayneQuote = JObject.Parse(kanyeResponseJson)["quote"].ToString();
            
            return kayneQuote;
        }
        
        public string RonSpeaks()
        {
            //Build URL for the Kayne API
            var ronUrl = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
        
            //Using the HTTPClient instance
            //Send a GET request to the url created above, this going to give us back a string of json
            var ronResponseJson = _client.GetStringAsync(ronUrl).Result;
        
            //Parse the JSON respone string into JArray
            var ronQuote = JArray.Parse(ronResponseJson).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
            
            return ronQuote;
        }
    }
}
