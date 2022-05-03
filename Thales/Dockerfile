FROM mcr.microsoft.com/dotnet/sdk:6.0 AS backend-build
COPY Thales/Thales.csproj Thales/Thales.csproj
RUN dotnet restore Thales/Thales.csproj
COPY Thales Thales
RUN dotnet publish Thales/Thales.csproj -c Release -o /app

FROM node:16 AS frontend-build
COPY frontend/package.json frontend/package.json
COPY frontend/package-lock.json frontend/package-lock.json
WORKDIR /frontend
RUN npm install
COPY /frontend .
RUN npm run build

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=frontend-build /frontend/dist wwwroot/
COPY --from=backend-build /app .
ENTRYPOINT dotnet Thales.dll