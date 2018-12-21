using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ClassLibrary1
{
    public partial class Program
    {
        private static void CheckFieldsIsEmptyStrings_Or_DuplicateIds(string jsonString)
        {
            var jsonObject = JsonConvert.DeserializeObject<CurrencyDataAndMetadata>(jsonString);

            var iDs = new List<int>();

            foreach (var currency in jsonObject.data)
            {
                var id = currency.Id;

                Ids.IdsTest(iDs, id);
                Name.NameTest(currency.Name, id);
                Symbol.SymbolTest(currency.Symbol, id);
                WebsiteSlug.WebsiteSlugTest(currency.Website_slug, id);
            }

            Console.WriteLine("It's Correct!");
        }
    }
}