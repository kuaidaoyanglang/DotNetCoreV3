FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["Piano.NetCoreV3.Project/Piano.NetCoreV3.Project.csproj", "Piano.NetCoreV3.Project/"]
RUN dotnet restore "Piano.NetCoreV3.Project/Piano.NetCoreV3.Project.csproj"
COPY . .
WORKDIR "/src/Piano.NetCoreV3.Project"
RUN dotnet build "Piano.NetCoreV3.Project.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Piano.NetCoreV3.Project.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Piano.NetCoreV3.Project.dll"]