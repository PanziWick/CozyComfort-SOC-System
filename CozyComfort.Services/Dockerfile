# 1. Base runtime image for .NET 8
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# 2. Build image with SDK
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Install EF tools
RUN dotnet tool install --global dotnet-ef
ENV PATH="$PATH:/root/.dotnet/tools"

COPY ["CozyComfort.Services/CozyComfort.Services.csproj", "CozyComfort.Services/"]
RUN dotnet restore "CozyComfort.Services/CozyComfort.Services.csproj"
COPY . .
WORKDIR "/src/CozyComfort.Services"
RUN dotnet build "CozyComfort.Services.csproj" -c Release -o /app/build

# 3. Publish compiled files
FROM build AS publish
RUN dotnet publish "CozyComfort.Services.csproj" -c Release -o /app/publish

# 4. Final runtime container
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CozyComfort.Services.dll", "--environment", "Development"]
