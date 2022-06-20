#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["services/identity/NuGet.Config", "services/identity/"]
COPY ["services/administration/NuGet.Config", "services/administration/"]
COPY ["services/saas/NuGet.Config", "services/saas/"]
COPY ["services/identity/host/QMS.IdentityService.HttpApi.Host/QMS.IdentityService.HttpApi.Host.csproj", "services/identity/host/QMS.IdentityService.HttpApi.Host/"]
COPY ["services/identity/src/QMS.IdentityService.HttpApi/QMS.IdentityService.HttpApi.csproj", "services/identity/src/QMS.IdentityService.HttpApi/"]
COPY ["services/identity/src/QMS.IdentityService.Application.Contracts/QMS.IdentityService.Application.Contracts.csproj", "services/identity/src/QMS.IdentityService.Application.Contracts/"]
COPY ["services/identity/src/QMS.IdentityService.Domain.Shared/QMS.IdentityService.Domain.Shared.csproj", "services/identity/src/QMS.IdentityService.Domain.Shared/"]
COPY ["services/identity/src/QMS.IdentityService.EntityFrameworkCore/QMS.IdentityService.EntityFrameworkCore.csproj", "services/identity/src/QMS.IdentityService.EntityFrameworkCore/"]
COPY ["services/identity/src/QMS.IdentityService.Domain/QMS.IdentityService.Domain.csproj", "services/identity/src/QMS.IdentityService.Domain/"]
COPY ["services/administration/src/QMS.AdministrationService.EntityFrameworkCore/QMS.AdministrationService.EntityFrameworkCore.csproj", "services/administration/src/QMS.AdministrationService.EntityFrameworkCore/"]
COPY ["services/administration/src/QMS.AdministrationService.Domain/QMS.AdministrationService.Domain.csproj", "services/administration/src/QMS.AdministrationService.Domain/"]
COPY ["services/administration/src/QMS.AdministrationService.Domain.Shared/QMS.AdministrationService.Domain.Shared.csproj", "services/administration/src/QMS.AdministrationService.Domain.Shared/"]
COPY ["services/saas/src/QMS.SaaSService.EntityFrameworkCore/QMS.SaaSService.EntityFrameworkCore.csproj", "services/saas/src/QMS.SaaSService.EntityFrameworkCore/"]
COPY ["services/saas/src/QMS.SaaSService.Domain/QMS.SaaSService.Domain.csproj", "services/saas/src/QMS.SaaSService.Domain/"]
COPY ["services/saas/src/QMS.SaaSService.Domain.Shared/QMS.SaaSService.Domain.Shared.csproj", "services/saas/src/QMS.SaaSService.Domain.Shared/"]
COPY ["shared/QMS.Shared.Hosting/QMS.Shared.Hosting.csproj", "shared/QMS.Shared.Hosting/"]
COPY ["services/identity/src/QMS.IdentityService.Application/QMS.IdentityService.Application.csproj", "services/identity/src/QMS.IdentityService.Application/"]
RUN dotnet restore "services/identity/host/QMS.IdentityService.HttpApi.Host/QMS.IdentityService.HttpApi.Host.csproj"
COPY . .
WORKDIR "/src/services/identity/host/QMS.IdentityService.HttpApi.Host"
RUN dotnet build "QMS.IdentityService.HttpApi.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "QMS.IdentityService.HttpApi.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "QMS.IdentityService.HttpApi.Host.dll"]