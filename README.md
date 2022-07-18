# Minimal-API
REST API

## Technology used
* .NET 6
* APS.NET Core
* Entity Framework Core
* Swagger
* HTTPRepl
* SQLite

## Prerequirements
* Visual Studio Code or Visual Studio 2017 or higher
* .NET Core SDK
* Terminal or Console

## Commands for installing NuGet Packages
* ``` dotnet add package Microsoft.EntityFrameworkCore ```
* ``` dotnet add package Microsoft.EntityFrameworkCore.Sqlite ```
* ``` dotnet add package Swashbuckle.AspNetCore ```
* ``` dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer ```
* ``` dotnet add package Microsoft.IdentityModel.Tokens ```
* ``` dotnet add package System.IdentityModel.Tokens.Jwt ```

## Command for installing HTTPRepl Tool
``` dotnet tool install -g Microsoft.dotnet-httprepl ```

## To run HTTPRepl 
after running program copy and paste your localhost address to command below without quotes
``` httprepl "LOCALHOST" ```

### To gain access for method, which is Authorized, you need to have request 
```get login?username="admin"&password="admin"``` and after that you will take a token, which you need to copy and paste to command with quotes
```HTTP Method --header "Authorization: Bearer TOKEN"```
### In example:  
```get hotels/1 --header "Authorization: Bearer eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoibWFudWNobyIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL25hbWVpZGVudGlmaWVyIjoiMjU5NjM3ODItNTJlNy00ZDlhLTkwMzktM2NmZDBkM2ExMjAxIiwiZXhwIjoxNjU4MTc4MjgwLCJpc3MiOiJ1enp6YWtvdiIsImF1ZCI6InV6enpha292In0.L_hYrGaXfwNCESwy-UhVPCDPe4I2ZY9cbeMdwm8sV0A"```
