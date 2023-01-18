#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["AirlineUI/AirlineUI.csproj", "AirlineUI/"]
COPY ["Airline.BLL/Airline.BLL.csproj", "Airline.BLL/"]
COPY ["Airline.DAL/Airline.DAL.csproj", "Airline.DAL/"]
RUN dotnet restore "AirlineUI/AirlineUI.csproj"
COPY . .
WORKDIR "/src/AirlineUI"
RUN dotnet build "AirlineUI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AirlineUI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AirlineUI.dll"]

#FROM mcr.microsoft.com/dotnet/sdk:3.1-focal AS build
#WORKDIR /source
#COPY . .
#RUN dotnet restore "./AirlineUI/AirlineUI.csproj" --disable-parallel
#RUN dotnet publish "./AirlineUI/AirlineUI.csproj" -c release -o /app --no-restore

#FROM mcr.microsoft.com/dotnet/aspnet:3.1-focal
#WORKDIR /app
#COPY --from=build /app ./

#EXPOSE 5000

#ENTRYPOINT ["dotnet", "AirlineUI.dll"]