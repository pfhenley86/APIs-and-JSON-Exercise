using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    internal class OpenWeatherMapAPI
    {
        private readonly HttpClient _client;
        
        public OpenWeatherMapAPI()
        {
            _client = new HttpClient();
        }
        
        public string ReturnWeather()
        {
            //grab the appsettings.json file and read the text it containa
            var appsettingsText = File.ReadAllText("appsettings.json");
        
            //Parse the JSON into an object so we can grab the value of "key"
            var apiKey = JObject.Parse(appsettingsText)["key"].ToString();
        
            //Prompt the user for their zip code
            Console.WriteLine("Please enter your Zip Code: ");
        
            //Store the Zip Code
            var zipCode = Console.ReadLine();

            //Build a URL from where the API call comes from
            var weatherUrl =
                $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&appid={apiKey}&units=imperial";

        
            //Using the HTTP Client, send a GET request to the URL created above
            var weatherResponseJson = _client.GetStringAsync(weatherUrl).Result;
        
            //Get Weather
            var weatherDataTemp = JObject.Parse(weatherResponseJson)["main"]["temp"].ToString();
            var weatherDataCity = JObject.Parse(weatherResponseJson)["name"].ToString();
            var weatherDataCountry = JObject.Parse(weatherResponseJson)["sys"]["country"].ToString();
        
           var currentWeather = $"The Temperature is: {weatherDataTemp} degrees outside in {weatherDataCity}, {weatherDataCountry}";

           return currentWeather;
        }
        
    }
}
