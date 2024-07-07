FROM mcr.microsoft.com/dotnet/sdk:6.0 AS BUILD
WORKDIR /myc

COPY . ./
RUN dotnet restore
RUN dotnet publish -c Release -o dist

FROM mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /myc

COPY --from=BUILD /myc/dist .
ENTRYPOINT ["dotnet", "ModaYCostura.API.dll", "--urls", "http://*:5000"]