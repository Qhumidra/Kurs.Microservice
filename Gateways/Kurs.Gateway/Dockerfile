FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim as build
WORKDIR /app
EXPOSE 80
COPY Gateways/Kurs.Gateway/*.csproj Gateways/Kurs.Gateway/
RUN dotnet restore Gateways/Kurs.Gateway/*.csproj
COPY . .
RUN dotnet publish Gateways/Kurs.Gateway/*.csproj -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet","Kurs.Gateway.dll" ]