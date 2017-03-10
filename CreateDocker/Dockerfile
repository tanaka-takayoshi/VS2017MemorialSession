FROM microsoft/dotnet:1.0-runtime
MAINTAINER tanaka733

RUN mkdir /app

COPY bin/Release/netcoreapp1.0/publish /app/
WORKDIR /app
ENV ASPNETCORE_URLS http://0.0.0.0:8080
EXPOSE 8080

ENTRYPOINT ["dotnet", "CreateDocker.dll"]
