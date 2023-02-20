
using System.Text.Json;
using RestSharp;

namespace ConsoleApp1
{
    class App

    {
        public static void Main(string[] args)
        {
            Console.WriteLine(PrettyJson(ExecuteRequest().Result));
        }

        private static string PrettyJson(string unPrettyJson)
        {
            var options = new JsonSerializerOptions(){
                WriteIndented = true
            };

            var jsonElement = JsonSerializer.Deserialize<JsonElement>(unPrettyJson);

            return JsonSerializer.Serialize(jsonElement, options);
        }

        private static async Task<string> ExecuteRequest()
        {
            //paste your code under this line
            
            
            return response.Content;
        }
    }
}