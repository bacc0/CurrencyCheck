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

            var jsonObject2 = JsonConvert.DeserializeObject<CurrencyDataAndMetadata>(jsonString);

            foreach (var currency in jsonObject2.data)
            {
                var id = currency.Id;

                if (iDs.Contains(id))
                {
                    throw new ArgumentException(
                        $"\n---------------------------------------------\nList contains duplicate values. " +
                        $"With ID ({id})\n---------------------------------------------");
                }

                iDs.Add(id);

                Name.NameTest(currency.Name, id);
                Symbol.SymbolTest(currency.Symbol, id);
                WebsiteSlug.WebsiteSlugTest(currency.Website_slug, id);
            }
        }
    }
}
