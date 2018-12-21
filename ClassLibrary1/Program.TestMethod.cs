using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public partial class Program
    {
        public static void TestMethod(List<CurrencyData> jsonObject)
        {
            var num = int.Parse(Console.ReadLine());

            var idDoesExist = true;

            foreach (var currencyData in jsonObject)
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

            Console.WriteLine($" Total type of currencys ({jsonObject.Count}) \n-------------------------------");
        }
    }
}