using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace OpenWeatherMapAPI;



class program
{
    private static void Main(string[] args)
    {
        var client = new HttpClient();
        Console.WriteLine("Please enter your API Keys");
        var api_key = Console.ReadLine();

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Please enter the city name: ");
            var city_name = Console.ReadLine();
            var weatherURL = $"http://api.openweathermap.org/data/2.5/weather?q={{city_name}}&appid={{api_key}}";

            var response = client.GetStringAsync(weatherURL).Result;
            Console.WriteLine(response);
            Console.WriteLine();



        }



    }










}























