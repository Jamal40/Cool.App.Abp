#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["NuGet.Config", "."]
COPY ["src/Cool.App.HttpApi.Host/Cool.App.HttpApi.Host.csproj", "src/Cool.App.HttpApi.Host/"]
COPY ["src/Cool.App.Application/Cool.App.Application.csproj", "src/Cool.App.Application/"]
COPY ["src/Cool.App.Domain/Cool.App.Domain.csproj", "src/Cool.App.Domain/"]
COPY ["src/Cool.App.Domain.Shared/Cool.App.Domain.Shared.csproj", "src/Cool.App.Domain.Shared/"]
COPY ["src/Cool.App.Application.Contracts/Cool.App.Application.Contracts.csproj", "src/Cool.App.Application.Contracts/"]
COPY ["src/Cool.App.EntityFrameworkCore/Cool.App.EntityFrameworkCore.csproj", "src/Cool.App.EntityFrameworkCore/"]
COPY ["src/Cool.App.HttpApi/Cool.App.HttpApi.csproj", "src/Cool.App.HttpApi/"]
RUN dotnet restore "./src/Cool.App.HttpApi.Host/./Cool.App.HttpApi.Host.csproj"
COPY . .

# Added commands to create .dotnet folder and set permissions


WORKDIR "/src/src/Cool.App.HttpApi.Host"
RUN dotnet build "./Cool.App.HttpApi.Host.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Cool.App.HttpApi.Host.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
EXPOSE 8082
ENV ASPNETCORE_URLS=http://*:8082
WORKDIR /app
RUN mkdir /.dotnet
RUN chgrp -R 0 /.dotnet && \
    chmod -R g=u /.dotnet 
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cool.App.HttpApi.Host.dll"]
