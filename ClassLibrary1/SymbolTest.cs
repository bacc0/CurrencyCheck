using System;

static internal class Symbol
{
    public static string SymbolTest(string symbol)
    {
        if (symbol == String.Empty)
        {
            throw new ArgumentException($"Symbol can't be Empty String! ");
        }
        return symbol ;
    }
}