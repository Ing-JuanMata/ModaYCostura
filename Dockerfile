FROM mcr.microsoft.com/dotnet/sdk:6.0 AS BUILD

COPY . .
RUN dotnet restore
