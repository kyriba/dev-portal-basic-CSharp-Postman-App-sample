using System;
using RestSharp;
using System.Text.Json;

namespace basic_CSharp_Postman_App
{
    class App

    {
        static void Main(string[] args)
        {
            //paste your code under this line


            
            Console.WriteLine(PrettyJson(response.Content));
        }

        public static string PrettyJson(string unPrettyJson)
        {
            var options = new JsonSerializerOptions(){
            WriteIndented = true
            };

            var jsonElement = JsonSerializer.Deserialize<JsonElement>(unPrettyJson);

            return JsonSerializer.Serialize(jsonElement, options);
        }
    }
}
