FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim as build
WORKDIR /app
EXPOSE 80
COPY Kurs.Shared/*.csproj Kurs.Shared/
COPY Frontends/Kurs.Web/*.csproj Frontends/Kurs.Web/
RUN dotnet restore Frontends/Kurs.Web/*.csproj
COPY . .
RUN dotnet publish Frontends/Kurs.Web/*.csproj -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet","Kurs.Web.dll" ]