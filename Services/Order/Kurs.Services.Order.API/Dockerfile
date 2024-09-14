FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim as build
WORKDIR /app
EXPOSE 80

COPY Kurs.Shared/*.csproj Kurs.Shared/
COPY Services/Order/Kurs.Services.Order.API/*.csproj Services/Order/Kurs.Services.Order.API/
COPY Services/Order/Kurs.Services.Order.Application/*.csproj Services/Order/Kurs.Services.Order.Application/
COPY Services/Order/Kurs.Services.Order.Core/*.csproj Services/Order/Kurs.Services.Order.Core/
COPY Services/Order/Kurs.Services.Order.Domain/*.csproj Services/Order/Kurs.Services.Order.Domain/
COPY Services/Order/Kurs.Services.Order.Instrastructure/*.csproj Services/Order/Kurs.Services.Order.Instrastructure/

RUN dotnet restore Services/Order/Kurs.Services.Order.API/*.csproj
COPY . .
RUN dotnet publish Services/Order/Kurs.Services.Order.API/*.csproj -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet","Kurs.Services.Order.API.dll" ]