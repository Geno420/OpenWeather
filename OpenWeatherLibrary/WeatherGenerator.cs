using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using OpenWeatherLibrary;
using System.Linq;
using static OpenWeatherLibrary.WeatherData;

namespace OpenWeatherLibrary
{
    public class WeatherGenerator
    {
        public static async Task<string> GetWeatherDataAsync()
        {
            HttpClient httpClient = new HttpClient();

            string dj = await httpClient.GetStringAsync("http://api.openweathermap.org/data/2.5/weather?q=Cape%20Town&APPID=cfabe0e4e34a2060a19f2daea46f0fb4");

            WeatherDate weatherDate = JsonConvert.DeserializeObject<WeatherDate>(dj);

            string returnString = string.Empty;

            for (int index = 0; index < weatherDate.weather.Count; index++)
            {
                returnString = weatherDate.weather[index].main;
            }


            return returnString;


        }
    }
}