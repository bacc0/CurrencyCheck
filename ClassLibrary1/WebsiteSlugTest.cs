using System;

static internal class WebsiteSlug
{
    public static Tuple<string, bool> WebsiteSlugTest(string websiteSlug, int id, bool isCorrect)
    {
        if (websiteSlug == String.Empty)
        {
            isCorrect = false;
            throw new ArgumentException($"\n---------------------------------------------\n \"Website Slug\" can't be Empty String! With ID ({id}) \n--------------------------------------------- ");
        }
        return Tuple.Create(websiteSlug, isCorrect);
    }
}
