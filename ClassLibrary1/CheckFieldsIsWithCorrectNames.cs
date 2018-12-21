using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ClassLibrary1
{
    public partial class Program
    {
        public static void CheckFieldsIsWithCorrectNames(string jsonString)
        {
            var jsonObject2 = JsonConvert.DeserializeObject(jsonString) as JObject;

            foreach (var currency in jsonObject2["data"])
            {
                if (!(currency as JObject).ContainsKey("id"))
                    Console.WriteLine("Not Contains Field (ID)");

                if (!(currency as JObject).ContainsKey("name"))
                    Console.WriteLine("Not Contains Field (NAME)");

                if (!(currency as JObject).ContainsKey("symbol"))
                    Console.WriteLine("Not Contains Field (SYMBOL)");

                if (!(currency as JObject).ContainsKey("website_slug"))
                    Console.WriteLine("Not Contains Field (WEBSITE SLUG)");
            }
            Console.WriteLine("It's Correct!");
        }
    }
}