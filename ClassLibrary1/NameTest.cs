using System;

static internal class Name
{
    public static string NameTest(string name)
    {
        if (name == String.Empty)
        {
            throw new ArgumentException($"Name can't be Empty String! ");
        }
        return name ;
    }
}