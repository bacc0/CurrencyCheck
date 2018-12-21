using System;


static internal class Name
{
    public static string NameTest(string name, int id)
    {
        if (name == String.Empty)
        {
            throw new ArgumentException($"\n---------------------------------------------\n \"Name\" can't be Empty String! With ID ({id}) \n---------------------------------------------");
        }
        return name ;
    }
}
