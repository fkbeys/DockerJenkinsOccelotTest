#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app 

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Services/Reservation/Reservation.Api/Reservation.Api.csproj", "Services/Reservation/Reservation.Api/"]
COPY ["Services/Reservation/Reservation.Infrastructure/Reservation.Infrastructure.csproj", "Services/Reservation/Reservation.Infrastructure/"]
COPY ["Services/Reservation/Reservation.Models/Reservation.Models.csproj", "Services/Reservation/Reservation.Models/"]
COPY ["Services/Reservation/Reservation.Services/Reservation.Services.csproj", "Services/Reservation/Reservation.Services/"]
RUN dotnet restore "Services/Reservation/Reservation.Api/Reservation.Api.csproj"
COPY . .
WORKDIR "/src/Services/Reservation/Reservation.Api"
RUN dotnet build "Reservation.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Reservation.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Reservation.Api.dll"]