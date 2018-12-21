using System;


static internal class Symbol
{
    public static string SymbolTest(string symbol, int id)
    {
        if (symbol == String.Empty)
        {
            throw new ArgumentException($"\n---------------------------------------------\n \"Symbol\" can't be Empty String! With ID ({id}) \n---------------------------------------------");
        }
        return symbol ;
    }
}
