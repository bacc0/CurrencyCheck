using NUnit.Framework;

namespace ClassLibrary1.Properties
{
    [TestFixture]
    public class TestCurrency
    {
        [Test]
        public void DownloadedIsNotEmptyString()
        { 
            Assert.That(Read.ReadFromWeb("https://bacc0.github.io/One.html"), !Is.EqualTo(string.Empty));   // https://api.coinmarketcap.com/v2/listings/
        }

        [Test]
        public void NameIsNotEmptyString()
        {
            Assert.Multiple(() =>
            {
                Assert.That(Name.NameTest("Bitcoin", 1), !Is.EqualTo(""));
            });
        }


        [Test]
        public void SymbolIsNotEmptyString()
        {
            Assert.Multiple(() =>
            {
                Assert.That(Symbol.SymbolTest("BTC", 1),!Is.EqualTo(""));
            //                Assert.That(Symbol.SymbolTest("", 2)),!Is.EqualTo(""));
        });
        } 
    
        [Test]
        public void WebsiteSlugIsNotEmptyString()
        {
            Assert.Multiple(() =>
            {
                Assert.That(WebsiteSlug.WebsiteSlugTest("bitcoin", 1),!Is.EqualTo(""));
//                Assert.That(WebsiteSlug.WebsiteSlugTest("", 3),!Is.EqualTo(""));
            }); 
        } 
    }
}