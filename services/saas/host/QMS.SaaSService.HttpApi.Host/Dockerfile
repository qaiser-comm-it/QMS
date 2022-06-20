#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["services/saas/NuGet.Config", "services/saas/"]
COPY ["services/administration/NuGet.Config", "services/administration/"]
COPY ["services/saas/host/QMS.SaaSService.HttpApi.Host/QMS.SaaSService.HttpApi.Host.csproj", "services/saas/host/QMS.SaaSService.HttpApi.Host/"]
COPY ["services/administration/src/QMS.AdministrationService.EntityFrameworkCore/QMS.AdministrationService.EntityFrameworkCore.csproj", "services/administration/src/QMS.AdministrationService.EntityFrameworkCore/"]
COPY ["services/administration/src/QMS.AdministrationService.Domain/QMS.AdministrationService.Domain.csproj", "services/administration/src/QMS.AdministrationService.Domain/"]
COPY ["services/administration/src/QMS.AdministrationService.Domain.Shared/QMS.AdministrationService.Domain.Shared.csproj", "services/administration/src/QMS.AdministrationService.Domain.Shared/"]
COPY ["services/saas/src/QMS.SaaSService.Application/QMS.SaaSService.Application.csproj", "services/saas/src/QMS.SaaSService.Application/"]
COPY ["services/saas/src/QMS.SaaSService.Application.Contracts/QMS.SaaSService.Application.Contracts.csproj", "services/saas/src/QMS.SaaSService.Application.Contracts/"]
COPY ["services/saas/src/QMS.SaaSService.Domain.Shared/QMS.SaaSService.Domain.Shared.csproj", "services/saas/src/QMS.SaaSService.Domain.Shared/"]
COPY ["services/saas/src/QMS.SaaSService.Domain/QMS.SaaSService.Domain.csproj", "services/saas/src/QMS.SaaSService.Domain/"]
COPY ["shared/QMS.Shared.Hosting/QMS.Shared.Hosting.csproj", "shared/QMS.Shared.Hosting/"]
COPY ["services/saas/src/QMS.SaaSService.HttpApi/QMS.SaaSService.HttpApi.csproj", "services/saas/src/QMS.SaaSService.HttpApi/"]
COPY ["services/saas/src/QMS.SaaSService.EntityFrameworkCore/QMS.SaaSService.EntityFrameworkCore.csproj", "services/saas/src/QMS.SaaSService.EntityFrameworkCore/"]
RUN dotnet restore "services/saas/host/QMS.SaaSService.HttpApi.Host/QMS.SaaSService.HttpApi.Host.csproj"
COPY . .
WORKDIR "/src/services/saas/host/QMS.SaaSService.HttpApi.Host"
RUN dotnet build "QMS.SaaSService.HttpApi.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "QMS.SaaSService.HttpApi.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "QMS.SaaSService.HttpApi.Host.dll"]