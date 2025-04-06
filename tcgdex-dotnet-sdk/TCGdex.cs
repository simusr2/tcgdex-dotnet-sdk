using Net.Tcgdex.Sdk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net.Tcgdex.Sdk
{
    public class TCGdexClient
    {
        public string Language { get; set; }
        public string URI { get; set; } = "https://api.tcgdex.net/v2";

        public TCGdexClient(string language)
        {
            Language = language;
        }

        public async Task<T> Fetch<T>(params string[] path)
        {
            string url = $"{URI}/{Language}/" + string.Join("/", path.Select(Uri.EscapeDataString));
            return await Utils.Fetch<T>(this, url);
        }

        public Task<CardResume[]> FetchCards() => Fetch<CardResume[]>("cards");

        public Task<Card> FetchCard(string cardId) => Fetch<Card>("cards", cardId);

        public Task<Card> FetchCard(string setId, string cardId) =>  Fetch<Card>("sets", setId, cardId);

        public Task<SetResume[]> FetchSets() => Fetch<SetResume[]>("sets");

        public Task<Set> FetchSet(string set) =>  Fetch<Set>("sets", set);

        public Task<SerieResume[]> FetchSeries() => Fetch<SerieResume[]>("series");

        public Task<Serie> FetchSerie(string serie) => Fetch<Serie>("series", serie);

        public Task<string[]> FetchVariants() => Fetch<string[]>("variants");

        public Task<StringEndpoint> FetchVariant(string variant) => Fetch<StringEndpoint>("variants", variant);

        public Task<string[]> FetchTrainerTypes() => Fetch<string[]>("trainer-types");

        public Task<StringEndpoint> FetchTrainerType(string type) => Fetch<StringEndpoint>("trainer-types", type);

        public Task<string[]> FetchSuffixes() => Fetch<string[]>("suffixes");

        public Task<StringEndpoint> FetchSuffix(string suffix) => Fetch<StringEndpoint>("suffixes", suffix);

        public Task<string[]> FetchStages() => Fetch<string[]>("stages");

        public Task<StringEndpoint> FetchStage(string stage) => Fetch<StringEndpoint>("stages", stage);

        public Task<string[]> FetchRegulationMarks() => Fetch<string[]>("regulation-marks");

        public Task<StringEndpoint> FetchRegulationMark(string regulationMark) => Fetch<StringEndpoint>("regulation-marks", regulationMark);

        public Task<string[]> FetchEnergyTypes() => Fetch<string[]>("energy-types");

        public Task<StringEndpoint> FetchEnergyType(string energyType) => Fetch<StringEndpoint>("energy-types", energyType);

        public Task<int[]> FetchDexIds() => Fetch<int[]>("dex-ids");

        public Task<StringEndpoint> FetchDexId(int dexId) => Fetch<StringEndpoint>("dex-ids", dexId.ToString());

        public Task<string[]> FetchTypes() => Fetch<string[]>("types");

        public Task<StringEndpoint> FetchType(string type) => Fetch<StringEndpoint>("types", type);

        public Task<string[]> FetchCategories() => Fetch<string[]>("categories");

        public Task<StringEndpoint> FetchCategory(string category) => Fetch<StringEndpoint>("categories", category);

        public Task<int[]> FetchRetreats() => Fetch<int[]>("retreats");

        public Task<StringEndpoint> FetchRetreat(int retreat) => Fetch<StringEndpoint>("retreats", retreat.ToString());

        public Task<string[]> FetchRarities() => Fetch<string[]>("rarities");

        public Task<StringEndpoint> FetchRarity(string rarity) => Fetch<StringEndpoint>("rarities", rarity);

        public Task<string[]> FetchIllustrators() => Fetch<string[]>("illustrators");

        public Task<StringEndpoint> FetchIllustrator(string illustrator) => Fetch<StringEndpoint>("illustrators", illustrator);

        public Task<int[]> FetchHPs() => Fetch<int[]>("hp");

        public Task<StringEndpoint> FetchHP(int hp) => Fetch<StringEndpoint>("hp", hp.ToString());
    }
}
