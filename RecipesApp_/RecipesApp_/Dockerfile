#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["RecipesApp_/RecipesApp.API.csproj", "RecipesApp_/"]
COPY ["RecipesApp_Database/RecipesApp.Database.csproj", "RecipesApp_Database/"]
COPY ["RecipesApp.Core/RecipesApp.Core.csproj", "RecipesApp.Core/"]
COPY ["RecipesApp.Common/RecipesApp.Common.csproj", "RecipesApp.Common/"]
COPY ["RecipesApp.Services/RecipesApp.Services.csproj", "RecipesApp.Services/"]
COPY ["RecipesApp.Mapper/RecipesApp.Mapper.csproj", "RecipesApp.Mapper/"]
COPY ["RecipesApp.LoggerDatabase/RecipesApp.LoggerDatabase.csproj", "RecipesApp.LoggerDatabase/"]
RUN dotnet restore "RecipesApp_/RecipesApp.API.csproj"
COPY . .
WORKDIR "/src/RecipesApp_"
RUN dotnet build "RecipesApp.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RecipesApp.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RecipesApp.API.dll"]
