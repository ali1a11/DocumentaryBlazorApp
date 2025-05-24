# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy project files and restore
COPY ["DocumentaryBlazorApp.csproj", "."]
RUN dotnet restore "DocumentaryBlazorApp.csproj"

# Copy everything else and build
COPY . .
RUN dotnet build "DocumentaryBlazorApp.csproj" -c Release -o /app/build

# Publish stage
FROM build AS publish
RUN dotnet publish "DocumentaryBlazorApp.csproj" -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Create Data directory and set permissions
RUN mkdir -p /app/Data && \
    chmod 777 /app/Data

# Copy published app and ensure SQLite DB exists
COPY --from=publish /app/publish .
RUN touch /app/Data/app.db && \
    chmod 666 /app/Data/app.db

# Environment configuration
ENV ASPNETCORE_ENVIRONMENT=Production
ENV ASPNETCORE_URLS=http://+:8080
ENV ConnectionStrings__DefaultConnection="Data Source=/app/Data/app.db"

# Apply EF Core migrations (if needed)
# RUN dotnet ef database update

EXPOSE 8080
ENTRYPOINT ["dotnet", "DocumentaryBlazorApp.dll"]



#
## Use the official .NET SDK image for building
#FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
#WORKDIR /src
#
## Copy project files and restore dependencies
#COPY ["DocumentaryBlazorApp.csproj", "."]
#RUN dotnet restore "DocumentaryBlazorApp.csproj"
#
## Copy all source files and build
#COPY . .
#RUN dotnet build "DocumentaryBlazorApp.csproj" -c Release -o /app/build
#
## Publish the app
#RUN dotnet publish "DocumentaryBlazorApp.csproj" -c Release -o /app/publish
#
## Use the ASP.NET runtime image for the final stage
#FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
#WORKDIR /app
#
## Copy published files from build stage
#COPY --from=build /app/publish .
#
## Expose the port the app runs on (default for Blazor Server is 80)
#EXPOSE 80
#EXPOSE 443
#
## Define the entry point
#ENTRYPOINT ["dotnet", "DocumentaryBlazorApp.dll"]



## Use the official ASP.NET image as a base
#FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
#WORKDIR /app
#EXPOSE 80
#
## Build stage
#FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
#WORKDIR /src
#COPY ["DocumentaryBlazorApp.csproj", "./"]
#RUN dotnet restore "./DocumentaryBlazorApp.csproj"
#COPY . .
#RUN dotnet publish "DocumentaryBlazorApp.csproj" -c Release -o /app/publish
#
## Final stage
#FROM base AS final
#WORKDIR /app
#COPY --from=build /app/publish .
#ENTRYPOINT ["dotnet", "DocumentaryBlazorApp.dll"]
