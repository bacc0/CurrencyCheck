using System.Collections.Generic;


namespace ClassLibrary1
{
    public class CurrencyData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Website_slug { get; set; }
    }

    public class CurrencyDataAndMetadata
    {
        public List<CurrencyData> data { get; set; }
        public object metadata { get; set; }
    }
}