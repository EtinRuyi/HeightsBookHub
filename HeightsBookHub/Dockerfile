#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["HeightsBookHub/HeightsBookHub.csproj", "HeightsBookHub/"]
COPY ["HeightsBookHub.Application/HeightsBookHub.Application.csproj", "HeightsBookHub.Application/"]
COPY ["HeightsBookHub.Common/HeightsBookHub.Common.csproj", "HeightsBookHub.Common/"]
COPY ["HeightsBookHub.Domain/HeightsBookHub.Domain.csproj", "HeightsBookHub.Domain/"]
COPY ["HeightsBookHub.Persistence/HeightsBookHub.Persistence.csproj", "HeightsBookHub.Persistence/"]
RUN dotnet restore "HeightsBookHub/HeightsBookHub.csproj"
COPY . .
WORKDIR "/src/HeightsBookHub"
RUN dotnet build "HeightsBookHub.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "HeightsBookHub.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HeightsBookHub.dll"]