namespace TemperatureBlanketApi.Models;

public record BlanketMetaData(DateTime DateCreated, string LocationName, string Latitude, string Longitude, Colors? Colors = null);