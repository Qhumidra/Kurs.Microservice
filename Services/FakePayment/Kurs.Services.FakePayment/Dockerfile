FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim as build
WORKDIR /app
EXPOSE 80
COPY Kurs.Shared/*.csproj Kurs.Shared/
COPY Services/FakePayment/Kurs.Services.FakePayment/*.csproj Services/FakePayment/Kurs.Services.FakePayment/
RUN dotnet restore Services/FakePayment/Kurs.Services.FakePayment/*.csproj
COPY . .
RUN dotnet publish Services/FakePayment/Kurs.Services.FakePayment/*.csproj -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet","Kurs.Services.FakePayment.dll" ]