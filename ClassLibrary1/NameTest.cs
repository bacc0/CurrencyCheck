using System;

static internal class Name
{
    public static Tuple<string, bool> NameTest(string name, int id, bool isCorrect)
    {
        if (name == String.Empty)
        {
            isCorrect = false;
            throw new ArgumentException($"\n---------------------------------------------\n \"Name\" can't be Empty String! With ID ({id}) \n---------------------------------------------");
        }
        return Tuple.Create(name, isCorrect);
    }
}
