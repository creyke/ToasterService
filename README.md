# ToasterService
An example of embedding an Orleans silo in the same process an ASP.NET Web API

## Please note
1. This project uses a pre-release build of Orleans for .NET Core, so you will need to add the following to your NuGet feeds list:
`https://dotnet.myget.org/F/orleans-prerelease/api/v3/index.json`

2. The solution is configured to build and debug in Docker, but if you don't have Docker installed you can just right click on the `ToasterService.Api` project and select `Debug`.
