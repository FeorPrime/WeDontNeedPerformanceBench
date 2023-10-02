FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["WeDontNeedPerfomanceBench/WeDontNeedPerfomanceBench.csproj", "WeDontNeedPerfomanceBench/"]
RUN dotnet restore "WeDontNeedPerfomanceBench/WeDontNeedPerfomanceBench.csproj"
COPY . .
WORKDIR "/src/WeDontNeedPerfomanceBench"
RUN dotnet build "WeDontNeedPerfomanceBench.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WeDontNeedPerfomanceBench.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WeDontNeedPerfomanceBench.dll"]
