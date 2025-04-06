using Net.Tcgdex.Sdk;
using Net.Tcgdex.Sdk.Models;

namespace Net.TcgDex.Sdk.Tests
{
    [TestClass]
    public sealed class OtherTest
    {

        [TestMethod]
        [DataRow("it", true)]
        [DataRow("en", true)]
        [DataRow("es", true)]
        [DataRow("fr", true)]
        [DataRow("de", true)]
        [DataRow("ll", false)]
        public async Task FetchVariants(string language, bool supported)
        {
            return;  // TODO: Temporary problems that slows down the tests
            TCGdexClient client = new TCGdexClient(language);
            string[]? variants = await client.FetchVariants();
            if (!supported)
            {
                Assert.IsNull(variants);
                return;
            }
            Assert.IsNotNull(variants);
            Assert.IsTrue(variants.Length > 0);
        }


        [TestMethod]
        [DataRow("it", "ex", "ex")]
        [DataRow("it", "v", "v")]
        [DataRow("en", "ex", "ex")]
        public async Task FetchVariant(string language, string id, string name)
        {
            TCGdexClient client = new TCGdexClient(language);
            StringEndpoint? variant = await client.FetchVariant(id);
            Assert.IsNotNull(variant);
            Assert.AreEqual(name, variant.Name);
        }

        [TestMethod]
        [DataRow("en")]
        [DataRow("it")]
        [DataRow("fr")]
        [DataRow("de")]
        public async Task FetchTrainerTypes(string language)
        {
            TCGdexClient client = new TCGdexClient(language);
            string[]? types = await client.FetchTrainerTypes();
            Assert.IsNotNull(types);
            Assert.IsTrue(types.Length > 0);
        }
    
        [TestMethod]
        [DataRow("it", "Aiuto")]
        [DataRow("en", "Tool")]
        [DataRow("fr", "Outil")]
        [DataRow("de", "Stadionkarte")]
        public async Task FetchTrainerType(string language, string name)
        {
            TCGdexClient client = new TCGdexClient(language);
            StringEndpoint? type = await client.FetchTrainerType(name);
            Assert.IsNotNull(type);
            Assert.AreEqual(name.ToLower(), type.Name.ToLower());
        }

        [TestMethod]
        [DataRow("en")]
        [DataRow("it")]
        [DataRow("fr")]
        [DataRow("de")]
        public async Task FetchSuffixes(string language)
        {
            TCGdexClient client = new TCGdexClient(language);
            string[]? suffixes = await client.FetchSuffixes();
            Assert.IsNotNull(suffixes);
            Assert.IsTrue(suffixes.Length > 0);
        }

        [TestMethod]
        [DataRow("it", "LEGENDE")]
        [DataRow("en", "Legend")]
        [DataRow("fr", "LÉGENDE")]
        [DataRow("de", "TAG TEAM-GX")]
        public async Task FetchSuffix(string language, string name)
        {
            TCGdexClient client = new TCGdexClient(language);
            StringEndpoint? suffix = await client.FetchSuffix(name);
            Assert.IsNotNull(suffix);
            Assert.AreEqual(name.ToLower(), suffix.Name.ToLower());
        }

        [TestMethod]
        [DataRow("en")]
        [DataRow("it")]
        [DataRow("fr")]
        [DataRow("de")]
        public async Task FetchStages(string language)
        {
            TCGdexClient client = new TCGdexClient(language);
            string[]? stages = await client.FetchStages();
            Assert.IsNotNull(stages);
            Assert.IsTrue(stages.Length > 0);
        }

        [TestMethod]
        [DataRow("it", "Livello 1")]
        [DataRow("en", "Stage 2")]
        [DataRow("fr", "Niveau 1")]
        [DataRow("de", "Rang 2")]
        public async Task FetchStage(string language, string name)
        {
            TCGdexClient client = new TCGdexClient(language);
            StringEndpoint? stage = await client.FetchStage(name);
            Assert.IsNotNull(stage);
            Assert.AreEqual(name.ToLower(), stage.Name.ToLower());
        }

        [TestMethod]
        [DataRow("en")]
        [DataRow("it")]
        [DataRow("fr")]
        [DataRow("de")]
        public async Task FetchRegulationMarks(string language)
        {
            TCGdexClient client = new TCGdexClient(language);
            string[]? regulationMarks = await client.FetchRegulationMarks();
            Assert.IsNotNull(regulationMarks);
            Assert.IsTrue(regulationMarks.Length > 0);
        }

        [TestMethod]
        [DataRow("it", "F")]
        [DataRow("en", "G")]
        [DataRow("fr", "H")]
        [DataRow("de", "I")]
        public async Task FetchRegulationMark(string language, string name)
        {
            TCGdexClient client = new TCGdexClient(language);
            StringEndpoint? regulationMark = await client.FetchRegulationMark(name);
            Assert.IsNotNull(regulationMark);
            Assert.AreEqual(name.ToLower(), regulationMark.Name.ToLower());
        }

        [TestMethod]
        [DataRow("en")]
        [DataRow("it")]
        [DataRow("fr")]
        [DataRow("de")]
        public async Task FetchEnergyTypes(string language)
        {
            TCGdexClient client = new TCGdexClient(language);
            string[]? energyTypes = await client.FetchEnergyTypes();
            Assert.IsNotNull(energyTypes);
            Assert.IsTrue(energyTypes.Length > 0);
        }

        [TestMethod]
        [DataRow("it", "Erba")]
        [DataRow("en", "Grass")]
        [DataRow("fr", "Feu")]
        [DataRow("de", "Elektro")]
        public async Task FetchEnergyType(string language, string name)
        {
            TCGdexClient client = new TCGdexClient(language);
            StringEndpoint? energyType = await client.FetchEnergyType(name);
            Assert.IsNotNull(energyType);
            Assert.AreEqual(name.ToLower(), energyType.Name.ToLower());
        }

        [TestMethod]
        [DataRow("en")]
        [DataRow("it")]
        [DataRow("fr")]
        [DataRow("de")]
        public async Task FetchDexIds(string language)
        {
            TCGdexClient client = new TCGdexClient(language);
            int[]? dexIds = await client.FetchDexIds();
            Assert.IsNotNull(dexIds);
            Assert.IsTrue(dexIds.Length > 0);
        }

        [TestMethod]
        [DataRow("it", 1)]
        [DataRow("it", 2)]
        public async Task FetchDexId(string language, int name)
        {
            TCGdexClient client = new TCGdexClient(language);
            StringEndpoint? dexId = await client.FetchDexId(name);
            Assert.IsNotNull(dexId);
            Assert.AreEqual(name.ToString(), dexId.Name);
        }

        [TestMethod]
        [DataRow("en")]
        [DataRow("it")]
        [DataRow("fr")]
        [DataRow("de")]
        public async Task FetchTypes(string language)
        {
            TCGdexClient client = new TCGdexClient(language);
            string[]? types = await client.FetchTypes();
            Assert.IsNotNull(types);
            Assert.IsTrue(types.Length > 0);
        }

        [TestMethod]
        [DataRow("it", "Incolore")]
        [DataRow("en", "Darkness")]
        [DataRow("fr", "Feu")]
        [DataRow("de", "Elektro")]
        public async Task FetchType(string language, string name)
        {
            TCGdexClient client = new TCGdexClient(language);
            StringEndpoint? type = await client.FetchType(name);
            Assert.IsNotNull(type);
            Assert.AreEqual(name.ToLower(), type.Name.ToLower());
        }

        [TestMethod]
        [DataRow("it")]
        [DataRow("en")]
        [DataRow("fr")]
        [DataRow("de")]
        public async Task FetchCategories(string language)
        {
            TCGdexClient client = new TCGdexClient(language);
            string[]? categories = await client.FetchCategories();
            Assert.IsNotNull(categories);
            Assert.IsTrue(categories.Length > 0);
        }

        [TestMethod]
        [DataRow("it", "Allenatore")]
        [DataRow("en", "Energy")]
        [DataRow("fr", "Dresseur")]
        [DataRow("de", "Trainer")]
        public async Task FetchCategory(string language, string category)
        {
            TCGdexClient client = new TCGdexClient(language);
            StringEndpoint? categoryObject = await client.FetchCategory(category);
            Assert.IsNotNull(categoryObject);
            Assert.AreEqual(category.ToLower(), categoryObject.Name.ToLower());
        }

        [TestMethod]
        [DataRow("it")]
        [DataRow("en")]
        [DataRow("fr")]
        [DataRow("de")]
        public async Task FetchRetreats(string language)
        {
            TCGdexClient client = new TCGdexClient(language);
            int[]? retreats = await client.FetchRetreats();
            Assert.IsNotNull(retreats);
            Assert.IsTrue(retreats.Length > 0);
        }

        [TestMethod]
        [DataRow("en", 1)]
        [DataRow("it", 2)]
        public async Task FetchRetreat(string language, int retreat)
        {
            TCGdexClient client = new TCGdexClient(language);
            StringEndpoint? retreatObject = await client.FetchRetreat(retreat);
            Assert.IsNotNull(retreatObject);
            Assert.AreEqual(retreat.ToString(), retreatObject.Name);
        }

        [TestMethod]
        [DataRow("it")]
        [DataRow("en")]
        [DataRow("fr")]
        [DataRow("de")]
        public async Task FetchRarities(string language)
        {
            TCGdexClient client = new TCGdexClient(language);        
            string[]? rarities = await client.FetchRarities();
            Assert.IsNotNull(rarities);
            Assert.IsTrue(rarities.Length > 0);
        }

        [TestMethod]
        [DataRow("en", "Rare")]
        [DataRow("it", "Rara")]
        public async Task FetchRarity(string language, string name)
        {
            TCGdexClient client = new TCGdexClient(language);
            StringEndpoint? rarity = await client.FetchRarity(name);
            Assert.IsNotNull(rarity);
            Assert.AreEqual(name.ToLower(), rarity.Name.ToLower());
        }

        [TestMethod]
        [DataRow("it")]
        [DataRow("en")]
        public async Task FetchIllustrators(string language)
        {
            TCGdexClient client = new TCGdexClient(language);
            string[]? illustrators = await client.FetchIllustrators();
            Assert.IsNotNull(illustrators);
            Assert.IsTrue(illustrators.Length > 0);
        }

        [TestMethod]
        [DataRow("it", "Junsei Kuninobu")]
        [DataRow("en", "Junsei Kuninobu")]
        public async Task FetchIllustrator(string language, string name)
        {
            TCGdexClient client = new TCGdexClient(language);
            StringEndpoint? illustrator = await client.FetchIllustrator(name);
            Assert.IsNotNull(illustrator);
            Assert.AreEqual(name.ToLower(), illustrator.Name.ToLower());
        }

        [TestMethod]
        [DataRow("it")]
        [DataRow("en")]
        [DataRow("fr")]
        [DataRow("de")]
        public async Task FetchHPs(string language)
        {
            TCGdexClient client = new TCGdexClient(language);
            int[]? hpList = await client.FetchHPs();
            Assert.IsNotNull(hpList);
            Assert.IsTrue(hpList.Length > 0);
        }

        [TestMethod]
        [DataRow("en", 30)]
        [DataRow("en", 40)]
        public async Task FetchHP(string language, int hp)
        {
            TCGdexClient client = new TCGdexClient(language);
            StringEndpoint? hpObject = await client.FetchHP(hp);
            Assert.IsNotNull(hp);
            Assert.AreEqual(hp.ToString(), hpObject!.Name);
        }
    }
}
