FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TemperatureBlanketApi/TemperatureBlanketApi.csproj", "TemperatureBlanketApi/"]
RUN dotnet restore "TemperatureBlanketApi/TemperatureBlanketApi.csproj"
COPY . .
WORKDIR "/src/TemperatureBlanketApi"
RUN dotnet build "TemperatureBlanketApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TemperatureBlanketApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TemperatureBlanketApi.dll"]
