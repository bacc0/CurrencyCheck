using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace ClassLibrary1
{
   public class Program
    {
        static void App()
        {
            var currencyDatas = new List<CurrencyData>();
            var iDs = new List<int>();

            var input = "https://api.coinmarketcap.com/v2/listings/";

            var jsonString = Read.ReadFromWeb(input);

            var jsonObject = JsonConvert.DeserializeObject(jsonString);
///////// PLEASE CHECK THIS
            var jsonToString = jsonObject.ToString();
/////////            
            var splited = jsonToString
                .Split(new[] {"},", "],", "\": ", ","}
                    , StringSplitOptions
                        .RemoveEmptyEntries)
                .Select(s => s.Trim(new char[] { '"', '\\', '\n', ' ', '\"', '}' }))
                .ToArray();

            var iDsPosition = 2;
            var namesPosition = 4;
            var symbolsPosition = 6;
            var websiteSlugsPosition = 8;

            for (int i = 1; i < splited.Length; i++)
            {
                if (iDsPosition + 7 > splited.Length)
                {
                    break;
                }
                
                var id = int.Parse(splited[iDsPosition]);
                if (iDs.Contains(id))
                {
                    Console.WriteLine("List contains duplicate values.");
                }
                
                iDs.Add(id);

                var name = splited[namesPosition];
                var symbol = splited[symbolsPosition];
                var websiteSlug = splited[websiteSlugsPosition];

                iDsPosition += 8;
                namesPosition += 8;
                symbolsPosition += 8;
                websiteSlugsPosition += 8;

                Name.NameTest(name);
                Symbol.SymbolTest(symbol);
                WebsiteSlug.WebsiteSlugTest(websiteSlug);
              
                var currency = new CurrencyData
                {
                    Id = id,
                    Name = name,
                    Symbol = symbol,
                    Website_slug = websiteSlug
                };
                
                currencyDatas.Add(currency);
            }
        }
    }
}
