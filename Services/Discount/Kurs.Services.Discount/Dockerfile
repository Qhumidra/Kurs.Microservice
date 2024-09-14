FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim as build
WORKDIR /app
EXPOSE 80
COPY Kurs.Shared/*.csproj Kurs.Shared/
COPY Services/Discount/Kurs.Services.Discount/*.csproj Services/Discount/Kurs.Services.Discount/
RUN dotnet restore Services/Discount/Kurs.Services.Discount/*.csproj
COPY . .
RUN dotnet publish Services/Discount/Kurs.Services.Discount/*.csproj -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet","Kurs.Services.Discount.dll" ]