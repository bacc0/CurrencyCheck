using System;
using System.Collections.Generic;


static internal class Ids
{
    public static Tuple<List<int>, bool> IdsTest(List<int> iDs, int id, bool isCorrect)
    {
        if (iDs.Contains(id))
        {
            isCorrect = false;
            throw new ArgumentException(
                "\n---------------------------------------------\nList contains duplicate values. " +
                $"With ID ({id})\n---------------------------------------------");
        }
        iDs.Add(id);

        return Tuple.Create(iDs, isCorrect);
    }
}
