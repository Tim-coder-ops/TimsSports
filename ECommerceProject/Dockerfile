﻿FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
FROM mcr.microsoft.com/dotnet/core/sdk:3.1
COPY /bin/Release/netcoreapp3.1/publish/ TimsStore/
ENV ASPNETCORE_ENVIRONMENT Production
EXPOSE 5000
WORKDIR /TimsStore
ENTRYPOINT ["dotnet", "SportsStore.dll", "--urls=http://0.0.0.0:5000"]