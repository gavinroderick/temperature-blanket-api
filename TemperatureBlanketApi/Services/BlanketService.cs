using TemperatureBlanketApi.Interfaces;
using TemperatureBlanketApi.Models;

namespace TemperatureBlanketApi.Services;

public class BlanketService : IBlanketService
{
    public Blanket CreateDummyBlanket()
    {
        return new Blanket(Guid.NewGuid(),
            CreateRandomYear(),
            new BlanketOwner(Guid.NewGuid(), "Gavin Roderick", "gavin@gmail.com"),
            new BlanketMetaData(DateTime.UtcNow, "Leith, Edinburgh", "55.9755 N", "3.1665 W")
        );
    }

    private static List<Week> CreateRandomYear()
    {
        var year = new List<Week>(52);
        for (var i = 0; i < 52; i++)
        {
            year.Add(new Week(i + 1, CreateRandomWeek(0, 35)));
        }
        return year;
    }

    private static double[] CreateRandomWeek(int minTemperature, int maxTemperature)
    {
        var week = new double[7];
        for (var i = 0; i < 7; i++)
        {
            var nextDouble = Random.Shared.NextDouble();
            nextDouble *= (maxTemperature - minTemperature) + minTemperature;
            week[i] = Math.Round(nextDouble, 2);
        }
        return week;
    }
}