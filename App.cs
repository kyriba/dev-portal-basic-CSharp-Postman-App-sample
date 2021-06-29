using System;
using RestSharp;
using System.Text.Json;

namespace dev_portal_basic_CSharp_Java_Postman_App_sample
{
    class App

    {
        static void Main(string[] args)
        {
            //paste your code under this line
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
