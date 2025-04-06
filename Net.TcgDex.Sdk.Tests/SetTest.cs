using Net.Tcgdex.Sdk;
using Net.Tcgdex.Sdk.Models;

namespace Net.TcgDex.Sdk.Tests
{
    [TestClass]
    public sealed class SetTest
    {
        [TestMethod]
        public async Task FetchSets()
        {
            TCGdexClient client = new TCGdexClient("it");

            SetResume[]? sets = await client.FetchSets();

            Assert.IsNotNull(sets);

            Assert.IsTrue(sets.Length > 0);
        }

        [TestMethod]
        [DataRow("it", "base1", "Set Base")]
        [DataRow("en", "base1", "Base Set")]
        public async Task FetchSetsWithCheck(string language, string id, string name)
        {
            TCGdexClient client = new TCGdexClient(language);

            SetResume[]? sets = await client.FetchSets();

            Assert.IsNotNull(sets);

            Assert.IsTrue(sets.Length > 0);

            Assert.AreEqual(1, sets.Count(x => x.Id == id && x.Name == name));
        }

        [TestMethod]
        [DataRow("it", "base1", "Set Base")]
        [DataRow("en", "base1", "Base Set")]
        [DataRow("it", "sv01", "Scarlatto e Violetto")]
        public async Task FetchSet(string language, string id, string name)
        {
            TCGdexClient client = new TCGdexClient(language);
            Set? set = await client.FetchSet(id);
            Assert.IsNotNull(set);
            Assert.AreEqual(id, set.Id);
            Assert.AreEqual(name, set.Name);
        }
    }
}
