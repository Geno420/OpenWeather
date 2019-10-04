using System;
using System.Threading.Tasks;
using OpenWeatherLibrary;

namespace OpenWeatherLibrary
{
    class Program
    {
       
        
            

            
            static async Task Main(string[] args)
            { 
                string weatherString = await WeatherGenerator.GetWeatherDataAsync();
                Console.WriteLine(weatherString);


            }

        }

    }

