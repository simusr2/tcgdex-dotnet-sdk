<p align="center">
	<a href="https://www.tcgdex.dev">
		<img src="https://tcgdex.dev/assets/logo-light.CMAueqIm.svg" width="90%" alt="TCGdex Main Image" style="background-color: white; padding: 5px; border-radius: 10px;">
	</a>
</p>
<p align="center">
</p>

# TCGdex .NET SDK

The .NET SDK provides a convenient access with the Open Source TCGdex API.

The SDK is available for:
- .NET 9.0
- .NET 8.0
- .NET Standard 2.1
- .NET Standard 2.0

## Documentation

_The full API/SDK documentation in progress at [API Documentation - TCGdex](https://www.tcgdex.dev)_

### Getting Started

#### How To install

**NuGet**

NuGet package will b available soon.

#### Usage

_Note: a complete documentation is available at [TCGdex.dev](https://www.tcgdex.dev)_

##### Kotlin

**Example: Fetch a Card**

```c#
// Import the SDK
using Net.Tcgdex.Sdk;

// Init the library with the language code (see the API REST documentation for the list)
var api = new TCGdexClient("en");

// returns you a Card Class with every informations filled!
var card = await api.FetchCard("swsh1-1");

// or without async
var card2 = api.FetchCard("swsh1-1").Result;
```

**Other Functions**

```c#

api.FetchCard("swsh3-136");
api.FetchCard("swsh3", "136");
api.FetchSet("swsh3");
api.FetchSets();
api.FetchSerie("swsh");
api.FetchSeries();
api.FetchTypes();
api.FetchType("Colorless");
api.FetchRetreats();
api.FetchRetreat(1);
api.FetchRarities();
api.FetchRarity("Uncommon");
api.FetchIllustrators();
api.FetchIllustrator("tetsuya koizumi");
api.FetchHPs();
api.FetchHP(110);
api.FetchCategories();
api.FetchCategory("Pokemon");
api.FetchDexIds();
api.FetchDexId(162);
api.FetchEnergyTypes();
api.FetchEnergyType("Special");
api.FetchRegulationMarks();
api.FetchRegulationMark("D");
api.FetchStages();
api.FetchStage("Basic");
api.FetchSuffixes();
api.FetchSuffix("EX");
api.FetchTrainerTypes();
api.FetchTrainerType("Tool");
api.FetchVariants();
api.FetchVariant("holo");
```

## Contributing

See [CONTRIBUTING.md](https://github.com/tcgdex/javascript-sdk/blob/master/CONTRIBUTING.md)

TL::DR

- Fork

- Commit your changes

- Pull Request on this Repository

## License

This project is licensed under the MIT License. A copy of the license is available at [LICENSE.md](https://github.com/tcgdex/javascript-sdk/blob/master/LICENSE.md)

This is based on the [Maxopoly](https://github.com/Maxopoly) TCGdex Java SDK using [TCGdex Java sdk repo](https://github.com/tcgdex/java-sdk)
