FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Forfeit15.Auth.Api/Forfeit15.Auth.Api.csproj", "Forfeit15.Auth.Api/"]
COPY ["Forfeit15.Auth.Database/Forfeit15.Auth.Database.csproj", "Forfeit15.Auth.Database/"]
COPY ["Forfeit15.Auth.Core/Forfeit15.Auth.Core.csproj", "Forfeit15.Auth.Core/"]
RUN dotnet restore "Forfeit15.Auth.Api/Forfeit15.Auth.Api.csproj"
COPY . .
WORKDIR "/src/Forfeit15.Auth.Api"
RUN dotnet build "Forfeit15.Auth.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Forfeit15.Auth.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Forfeit15.Auth.Api.dll"]
