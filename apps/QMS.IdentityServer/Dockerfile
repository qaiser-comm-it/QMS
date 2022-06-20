#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["services/identity/NuGet.Config", "services/identity/"]
COPY ["services/saas/NuGet.Config", "services/saas/"]
COPY ["services/administration/NuGet.Config", "services/administration/"]
COPY ["apps/QMS.IdentityServer/QMS.IdentityServer.csproj", "apps/QMS.IdentityServer/"]
COPY ["services/identity/src/QMS.IdentityService.EntityFrameworkCore/QMS.IdentityService.EntityFrameworkCore.csproj", "services/identity/src/QMS.IdentityService.EntityFrameworkCore/"]
COPY ["services/identity/src/QMS.IdentityService.Domain/QMS.IdentityService.Domain.csproj", "services/identity/src/QMS.IdentityService.Domain/"]
COPY ["services/identity/src/QMS.IdentityService.Domain.Shared/QMS.IdentityService.Domain.Shared.csproj", "services/identity/src/QMS.IdentityService.Domain.Shared/"]
COPY ["services/saas/src/QMS.SaaSService.EntityFrameworkCore/QMS.SaaSService.EntityFrameworkCore.csproj", "services/saas/src/QMS.SaaSService.EntityFrameworkCore/"]
COPY ["services/saas/src/QMS.SaaSService.Domain/QMS.SaaSService.Domain.csproj", "services/saas/src/QMS.SaaSService.Domain/"]
COPY ["services/saas/src/QMS.SaaSService.Domain.Shared/QMS.SaaSService.Domain.Shared.csproj", "services/saas/src/QMS.SaaSService.Domain.Shared/"]
COPY ["shared/QMS.Shared.Hosting/QMS.Shared.Hosting.csproj", "shared/QMS.Shared.Hosting/"]
COPY ["services/administration/src/QMS.AdministrationService.EntityFrameworkCore/QMS.AdministrationService.EntityFrameworkCore.csproj", "services/administration/src/QMS.AdministrationService.EntityFrameworkCore/"]
COPY ["services/administration/src/QMS.AdministrationService.Domain/QMS.AdministrationService.Domain.csproj", "services/administration/src/QMS.AdministrationService.Domain/"]
COPY ["services/administration/src/QMS.AdministrationService.Domain.Shared/QMS.AdministrationService.Domain.Shared.csproj", "services/administration/src/QMS.AdministrationService.Domain.Shared/"]
RUN dotnet restore "apps/QMS.IdentityServer/QMS.IdentityServer.csproj"
COPY . .
WORKDIR "/src/apps/QMS.IdentityServer"
RUN dotnet build "QMS.IdentityServer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "QMS.IdentityServer.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "QMS.IdentityServer.dll"]