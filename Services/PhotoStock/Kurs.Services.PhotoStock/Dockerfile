FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim as build
WORKDIR /app
EXPOSE 80
COPY Kurs.Shared/*.csproj Kurs.Shared/
COPY Services/PhotoStock/Kurs.Services.PhotoStock/*.csproj Services/PhotoStock/Kurs.Services.PhotoStock/
RUN dotnet restore Services/PhotoStock/Kurs.Services.PhotoStock/*.csproj
COPY . .
RUN dotnet publish Services/PhotoStock/Kurs.Services.PhotoStock/*.csproj -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet","Kurs.Services.PhotoStock.dll" ]