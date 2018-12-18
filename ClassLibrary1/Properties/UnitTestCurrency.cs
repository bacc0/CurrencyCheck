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
                Assert.That(Name.NameTest("Bitcoin"), !Is.EqualTo(""));
            });
        }
    
        [Test]
        public void SymbolIsNotEmptyString()
        {
            Assert.Multiple(() =>
            {
                Assert.That(Symbol.SymbolTest("BTC"),!Is.EqualTo(""));
//                Assert.That(Symbol.SymbolTest(""),!Is.EqualTo(""));
            });
        } 
    
        [Test]
        public void WebsiteSlugIsNotEmptyString()
        {
            Assert.Multiple(() =>
            {
                Assert.That(WebsiteSlug.WebsiteSlugTest("bitcoin"),!Is.EqualTo(""));
                Assert.That(WebsiteSlug.WebsiteSlugTest("litecoin"),!Is.EqualTo(""));
//                Assert.That(WebsiteSlug.WebsiteSlugTest(""),!Is.EqualTo(""));
            }); 
        } 
    }
}