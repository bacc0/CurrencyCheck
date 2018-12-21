using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace ClassLibrary1
{
    public class Program
    {
        static void Main()
        {
//            var allCurrencyData = new List<CurrencyData>();

            var iDs = new List<int>();

            var input = "https://bacc0.github.io/One.html"; 
//                       https://api.coinmarketcap.com/v2/listings/

            var jsonString = Read.ReadFromWeb(input);

                  var jsonObject = JsonConvert.DeserializeObject(jsonString) as JObject;
//      
//                   foreach (var currency in  jsonObject["data"])
//                   {
//                        bool containsname = false;
//      
//                       if ((currency as JObject).ContainsKey("name"))
//                            containsname = true;
//      
//                        bool containsName = false;
//                        if ((currency as JObject).ContainsKey("Name"))
//                            containsName = true;
//      
//                        var id = (int)(currency as JObject)["id"];
//                        var name = (string)(currency as JObject)["name"];
//                        var symbol = (string)(currency as JObject)["symbol"];
//                        var websiteSlug = (string)(currency as JObject)["website_slug"];    

            var jsonObject2 = JsonConvert.DeserializeObject<CurrencyDataAndMetadata>(jsonString);



            foreach (var currency in jsonObject2.data)
            {
                var id = currency.Id;
                var name = currency.Name;
                var symbol = currency.Symbol;
                var websiteSlug = currency.Website_slug;

                if (iDs.Contains(id))
                {
                    throw new ArgumentException(
                        $"\n---------------------------------------------\nList contains duplicate values. " +
                        $"With ID ({id})\n---------------------------------------------");
                }
                iDs.Add(id);

                Name.NameTest(name, id);
                Symbol.SymbolTest(symbol, id);
                WebsiteSlug.WebsiteSlugTest(websiteSlug, id);

            
//                var currencys = new CurrencyData
//                {
//                    Id = id,
//                    Name = name,
//                    Symbol = symbol,
//                    Website_slug = websiteSlug
//                };
//
//                allCurrencyData.Add(currencys);
            }
            Console.WriteLine();

//                  allCurrencyData = jsonObject2.data;

            var num = int.Parse(Console.ReadLine());

            var idDoesExist = true;

            foreach (var currencyData in jsonObject2.data)
            {

                if (currencyData.Id == num)
                {
                    Console.WriteLine("-------------------------------\n" +
                                      currencyData.Name + "\n" +
                                      currencyData.Id + "\n" +
                                      currencyData.Symbol + "\n" +
                                      currencyData.Website_slug + "\n" +
                                      "-------------------------------");
                    idDoesExist = false;
                    break;
                }
            }

            if (idDoesExist)
            {
                Console.WriteLine($"The ID ({num}) does not exist in the current context!\n");
            }

            Console.WriteLine($" Total type of currencys ({allCurrencyData.Count}) \n-------------------------------");
        }
    }
}
