using System;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace ClassLibrary1
{
    public class Program
    {
        static void Main()
        {
            var iDs = new List<int>();

            var input = "https://bacc0.github.io/One.html"; //     https://api.coinmarketcap.com/v2/listings/

            var jsonString = Read.ReadFromWeb(input);

            var jsonObject = JsonConvert.DeserializeObject<CurrencyDataAndMetadata>(jsonString);

            foreach (var currency in jsonObject.data)
            {
                var id = currency.Id;

                Ids.IdsTest(iDs, id);
                Name.NameTest(currency.Name, id);
                Symbol.SymbolTest(currency.Symbol, id);
                WebsiteSlug.WebsiteSlugTest(currency.Website_slug, id);
            }

            var num = int.Parse(Console.ReadLine());

            var idDoesExist = true;

            foreach (var currencyData in jsonObject.data)
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
            Console.WriteLine($" Total type of currencys ({jsonObject.data.Count}) \n-------------------------------");
        }
    }
}
