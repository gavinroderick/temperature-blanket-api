using TemperatureBlanketApi.Interfaces;
using TemperatureBlanketApi.Models;

namespace TemperatureBlanketApi.Services;

public class BlanketService : IBlanketService
{
    public string GetDummyBlanket()
    {
        return data;
    }

    //TODO - this is awful, read it from a json file like a normal person
    private const string data = @"{
                            ""blankets"": {
                                ""d244a1d5-8b03-4db7-81b2-2e5065319bc2"": {
                                    ""blanketOwner"": {
                                        ""id"": ""d244a1d5-8b03-4db7-81b2-2e5065319bc2"",
                                        ""name"": ""Gavin"",
                                        ""emailAddress"": ""gavin @gmail.com""
                                    },
                                    ""dateCreated"": ""2022-07-11 16:46:00Z"",
                                    ""blanketName"": ""Gavin's Temp Blanket"",
                                    ""locationName"": ""Leith, Edinburgh"",
                                    ""lattitude"": ""55.9755 N"",
                                    ""longitude"": ""3.1665 W"",
                                    ""colors"": {
                                        ""#ffffff"": {
                                            ""name"": ""my white colour"",
                                            ""min"": 0,
                                            ""max"": 10
                                        }
                                    },
                                    ""weeks"": {
                                        ""1"": [1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7]
                                    }
                                }
                            }
                           }";
}