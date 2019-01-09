using NUnit.Framework;


namespace ClassLibrary1.Properties
{
    [TestFixture]
    public class TestCurrency
    {
        [Test]
        public void DownloadedIsNotEmptyString()
        {
            var input = "https://bacc0.github.io/One.html";    //     https://api.coinmarketcap.com/v2/listings/

            Assert.That(Read.ReadFromWeb(input), !Is.EqualTo(string.Empty));
        }

        [Test]
        public void CheckFieldsIsEmptyStrings_Or_DuplicateIds()
        {
            var input = "https://bacc0.github.io/One.html";    //     https://api.coinmarketcap.com/v2/listings/
            var jsonString = Read.ReadFromWeb(input);

            Assert.That(Program.CheckFieldsIsEmptyStrings_Or_DuplicateIds(jsonString), Is.EqualTo((true)));
        }

        [Test]
        public void CheckFieldsIsWithCorrectNames()
        {
            var input = "https://bacc0.github.io/One.html";    //     https://api.coinmarketcap.com/v2/listings/
            var jsonString = Read.ReadFromWeb(input);

            Assert.That(Program.CheckFieldsIsWithCorrectNames(jsonString) , Is.EqualTo((true)));
        }
    }
}
