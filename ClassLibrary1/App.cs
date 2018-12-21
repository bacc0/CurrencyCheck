using System;

namespace ClassLibrary1
{
    public partial class Program
    {
        static void Main()
        {
            var input = "https://bacc0.github.io/One.html"; //     https://api.coinmarketcap.com/v2/listings/

            var jsonString = Read.ReadFromWeb(input);

            Console.WriteLine("Please choose option! " +
                              "\n To check Fields is EMPTY STRINGS or have a duplicate IDs, press (1) " +
                              "\n To check Fields is with Correct Names, press (2)" +
                              "\n For EXIT, press (3)");
            var option = 0;

            while (option != 3)
            {
                option = int.Parse(Console.ReadLine());

                if (option == 1)
                    CheckFieldsIsEmptyStrings_Or_DuplicateIds(jsonString);

                if (option == 2)
                    CheckFieldsIsWithCorrectNames(jsonString);
            }
                //TestMethod(jsonObject.data); 
        }
    }
}