using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {
        public static void GetTemp()
        {
            Console.Write("Enter your zipcode: ");
            var zip = Console.ReadLine();

            var client = new HttpClient();

            var apiKeyObj = File.ReadAllText("appsettings.json");
            var apiKey = JObject.Parse(apiKeyObj).GetValue("apikey");

            var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?zip={zip}&appid={apiKey}&units=imperial";
            var weatherResponse = client.GetStringAsync(weatherURL).Result;
            var weatherTemp = JObject.Parse(weatherResponse);

            Console.WriteLine($"The temperature is : {weatherTemp["main"]["temp"]}");
        }
    }
}
