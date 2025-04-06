using Net.Tcgdex.Sdk;
using Net.Tcgdex.Sdk.Models;

namespace Net.TcgDex.Sdk.Tests
{
    [TestClass]
    public sealed class CardTest
    {
        [TestMethod]
        [DataRow("it", true)]
        [DataRow("en", true)]
        [DataRow("es", true)]
        [DataRow("fr", true)]
        [DataRow("de", true)]
        [DataRow("ll", false)]
        public async Task FetchCards(string language, bool supported)
        {
            TCGdexClient client = new TCGdexClient(language);

            CardResume[]? sets = await client.FetchCards();

            if(!supported)
            {
                Assert.IsNull(sets);
                return;
            }

            Assert.IsNotNull(sets);

            Assert.IsTrue(sets.Length > 0);
        }

        [TestMethod]
        [DataRow("it", "swsh3-136", "Furret")]
        [DataRow("en", "swsh3-136", "Furret")]
        public async Task FetchCard(string language, string cardId, string name)
        {
            TCGdexClient client = new TCGdexClient(language);
            Card? card = await client.FetchCard(cardId);
            Assert.IsNotNull(card);
            Assert.AreEqual(card.Id, cardId);
            Assert.AreEqual(card.Name, name);
        }

        [TestMethod]
        [DataRow("it", "swsh3", "136", "Furret")]
        [DataRow("en", "swsh3", "136", "Furret")]
        public async Task FetchCardWithSet(string language, string setId, string cardId, string name)
        {
            TCGdexClient client = new TCGdexClient(language);
            Card? card = await client.FetchCard(setId, cardId);
            Assert.IsNotNull(card);
            Assert.AreEqual(card.Set.Id, setId);
            Assert.AreEqual(card.Id, $"{setId}-{cardId}");
            Assert.AreEqual(card.Name, name);
        }
    }
}
