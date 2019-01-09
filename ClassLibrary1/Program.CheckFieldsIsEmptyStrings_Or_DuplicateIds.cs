using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ClassLibrary1
{
    public partial class Program
    {
        public static bool CheckFieldsIsEmptyStrings_Or_DuplicateIds(string jsonString)
        {
            var jsonObject = JsonConvert.DeserializeObject<CurrencyDataAndMetadata>(jsonString);

            var isCorrect = true;

            var iDs = new List<int>();

            foreach (var currency in jsonObject.data)
            {
                var id = currency.Id;

                Ids.IdsTest(iDs, id, isCorrect);
                Name.NameTest(currency.Name, id, isCorrect);
                Symbol.SymbolTest(currency.Symbol, id, isCorrect);
                WebsiteSlug.WebsiteSlugTest(currency.Website_slug, id, isCorrect);
            }
            Console.WriteLine("It's Correct!");

            return isCorrect;
        }
    }
}