#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["gdcp.App/gdcp.App.csproj", "gdcp.App/"]
RUN dotnet restore "gdcp.App/gdcp.App.csproj"
COPY . .
WORKDIR "/src/gdcp.App"
RUN dotnet build "gdcp.App.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "gdcp.App.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "gdcp.App.dll"]