using System;

static internal class WebsiteSlug
{
    public static string WebsiteSlugTest(string websiteSlug)
    {
        if (websiteSlug == String.Empty)
        {
            throw new ArgumentException($"Symbol can't be Empty String! ");
        }
        return websiteSlug;
    }
}