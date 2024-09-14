FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim as build
WORKDIR /app
EXPOSE 80
COPY Kurs.Shared/*.csproj Kurs.Shared/
COPY Services/Basket/Kurs.Services.Basket/*.csproj Services/Basket/Kurs.Services.Basket/
RUN dotnet restore Services/Basket/Kurs.Services.Basket/*.csproj
COPY . .
RUN dotnet publish Services/Basket/Kurs.Services.Basket/*.csproj -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet","Kurs.Services.Basket.dll" ]