# ToasterService
An example of embedding an Orleans silo in the same process as an ASP.NET Web API

## Please note
1. This project uses a pre-release build of Orleans for .NET Core, so you will need to add the following to your NuGet feeds list:
`https://dotnet.myget.org/F/orleans-prerelease/api/v3/index.json`

2. The solution is configured to build and debug in Docker, but if you don't have Docker installed you can just right click on the `ToasterService.Api` project and select `Debug`.

## Value
1. Durable, distributed state
2. Durable scheduling
3. Streaming of data from and to the Web API, and across a Web API cluster
4. SignalR backplane implementation similar to [OrleansR](https://github.com/OrleansContrib/OrleansR) possible
5. Easier introduction to Orleans for traditional Web API developers
6. No need to deploy and debug a separate actor hosting process.
