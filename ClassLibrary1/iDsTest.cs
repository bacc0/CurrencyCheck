using System;
using System.Collections.Generic;


static internal class Ids
{
    public static List<int> IdsTest(List<int> iDs, int id)
    {
        if (iDs.Contains(id))
        {
            throw new ArgumentException(
                "\n---------------------------------------------\nList contains duplicate values. " +
                $"With ID ({id})\n---------------------------------------------");
        }

        iDs.Add(id);

        return iDs;
    }
}
