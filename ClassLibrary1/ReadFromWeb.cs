static internal class Read
{
    public static string ReadFromWeb(string input)
    {
        var readFromWeb = new System.Net
                .WebClient()
            .DownloadString(input);
        return readFromWeb;
    }
}