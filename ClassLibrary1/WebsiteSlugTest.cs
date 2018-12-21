using System;



static internal class WebsiteSlug
{
    public static string WebsiteSlugTest(string websiteSlug, int id)
    {
        if (websiteSlug == String.Empty)
        {
            throw new ArgumentException($"\n---------------------------------------------\n \"Website Slug\" can't be Empty String! With ID ({id}) \n--------------------------------------------- ");
        }
        return websiteSlug;
    }
}
