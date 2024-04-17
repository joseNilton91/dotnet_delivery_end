# Imagen base para ejecutar la aplicación
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Imagen SDK para compilar el proyecto
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["LibraryDigital.webapi.csproj", "./"]
RUN dotnet restore "LibraryDigital.webapi.csproj"
COPY . .
RUN dotnet build "LibraryDigital.webapi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LibraryDigital.webapi.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Imagen final que ejecutará la aplicación
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LibraryDigital.webapi.dll"]
