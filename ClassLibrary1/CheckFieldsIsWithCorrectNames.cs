using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ClassLibrary1
{
    public partial class Program
    {
        public static bool CheckFieldsIsWithCorrectNames(string jsonString)
        {
            var jsonObject2 = JsonConvert.DeserializeObject(jsonString) as JObject;

            var isCorrect = true;

            foreach (var currency in jsonObject2["data"])
            {
                if (!(currency as JObject).ContainsKey("id"))
                {
                    Console.WriteLine("Not Contains Field (ID)");

                    isCorrect = false;
                    break;
                }
                if (!(currency as JObject).ContainsKey("name"))
                {
                    Console.WriteLine("Not Contains Field (NAME)");

                    isCorrect = false;
                    break;
                }
                if (!(currency as JObject).ContainsKey("symbol"))
                {
                    Console.WriteLine("Not Contains Field (SYMBOL)");

                    isCorrect = false;
                    break;
                }
                if (!(currency as JObject).ContainsKey("website_slug"))
                {
                    Console.WriteLine("Not Contains Field (WEBSITE SLUG)");

                    isCorrect = false;
                    break;
                }
            }

            if(isCorrect)
            {

                Console.WriteLine("It's Correct!");
            }
            return isCorrect;
        }
    }
}