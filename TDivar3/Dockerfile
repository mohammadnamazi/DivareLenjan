#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-nanoserver-1903 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-nanoserver-1903 AS build
WORKDIR /src
COPY ["TDivar3/TDivar3.csproj", "TDivar3/"]
RUN dotnet restore "TDivar3/TDivar3.csproj"
COPY . .
WORKDIR "/src/TDivar3"
RUN dotnet build "TDivar3.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TDivar3.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TDivar3.dll"]