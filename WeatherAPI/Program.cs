using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;



class Program
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
            var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={city_name}&units=imperial&appid={api_key}";

            var response = client.GetStringAsync(weatherURL).Result;
            var formattedResponse = JObject.Parse(response).GetValue("main").ToString();
            Console.WriteLine(formattedResponse);
            Console.WriteLine();
            Console.WriteLine("Would you like a different city?");
            var userinput = Console.ReadLine();
            Console.WriteLine();
            
            if (userinput.ToLower() == "no")

            {
                break;
            }



        }
    }
}