FROM mcr.microsoft.com/dotnet/sdk:3.1 as build
WORKDIR /app
EXPOSE 80
COPY Kurs.Shared/*.csproj Kurs.Shared/
COPY IdentityServer/Kurs.IdentityServer/*.csproj IdentityServer/Kurs.IdentityServer/
RUN dotnet restore IdentityServer/Kurs.IdentityServer/*.csproj
COPY . .
RUN dotnet publish IdentityServer/Kurs.IdentityServer/*.csproj -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:3.1 as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet","Kurs.IdentityServer.dll" ]