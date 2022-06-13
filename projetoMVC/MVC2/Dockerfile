FROM mcr.microsoft.com/dotnet/aspnet:6.0
LABEL version="2.0.1" description="Aplicação Aspnet Core MVC"
COPY dist /app
WORKDIR /app
EXPOSE 80/tcp
ENTRYPOINT ["dotnet","MVC2.dll"]