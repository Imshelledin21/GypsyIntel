#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
ENV ASPNETCORE_URLS http://+:80
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["GypsyIntel.Site/GypsyIntel.Site.csproj", "GypsyIntel.Site/"]
RUN dotnet restore "GypsyIntel.Site/GypsyIntel.Site.csproj"
COPY . .
WORKDIR "/src/GypsyIntel.Site"
RUN dotnet build "GypsyIntel.Site.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GypsyIntel.Site.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GypsyIntel.Site.dll"]