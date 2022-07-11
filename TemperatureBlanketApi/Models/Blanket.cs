namespace TemperatureBlanketApi.Models;

public record Blanket(Guid Id, List<Week> Weeks, BlanketOwner? Owner, BlanketMetaData? MetaData);