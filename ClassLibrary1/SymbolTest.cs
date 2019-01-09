using System;

static internal class Symbol
{
    public static Tuple<string, bool> SymbolTest(string symbol, int id, bool isCorrect)
    {
        if (symbol == String.Empty)
        {
            isCorrect = false;
            throw new ArgumentException($"\n---------------------------------------------\n \"Symbol\" can't be Empty String! With ID ({id}) \n---------------------------------------------");
        }
        return Tuple.Create(symbol, isCorrect);
    }
}
