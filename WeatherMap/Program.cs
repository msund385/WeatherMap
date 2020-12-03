using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace WeatherMap
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = File.ReadAllText("appsettings.json");
            string APIkey = JObject.Parse(key).GetValue("DefaultKey").ToString();
            Console.WriteLine("Please enter your zipcode:");
            string zipCode = Console.ReadLine();
            Console.Write("Please enter your country code:");
            string countryCode = Console.ReadLine().ToLower();
            string apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode},{countryCode}&appid={APIkey}";
            WeatherMap.GetTemp(apiCall);
            Console.WriteLine(WeatherMap.GetTemp(apiCall));
        }
    }
    
}
