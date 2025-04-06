using Net.Tcgdex.Sdk;
using Net.Tcgdex.Sdk.Models;

namespace Net.TcgDex.Sdk.Tests
{
    [TestClass]
    public sealed class SerieTest
    {
        [TestMethod]
        public async Task FetchSeries()
        {
            TCGdexClient client = new TCGdexClient("it");

            SerieResume[]? sets = await client.FetchSeries();

            Assert.IsNotNull(sets);

            Assert.IsTrue(sets.Length > 0);
        }

        [TestMethod]
        [DataRow("it", "sv", "Scarlatto e Violetto")]
        [DataRow("en", "sv", "Scarlet & Violet")]
        [DataRow("en", "sv33", null)]
        public async Task FetchSerie(string language, string id, string name)
        {
            TCGdexClient client = new TCGdexClient(language);

            Serie? set = await client.FetchSerie(id);

            if(name is null)
            {
                Assert.IsNull(set);
                return;
            }

            Assert.IsNotNull(set);

            Assert.AreEqual(name, set.Name);
        }

    }
}
