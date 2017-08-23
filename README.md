# SelfHostedWebApi

This is a simple demo application to show how ASP.NET Web API can be self-hosted without the need for IIS.

* SelfHostedWebApi.Simple is a self-hosted web API inside a plain console application.
    - HttpSelfHostServer in this application is an implementation of an HttpServer which is the server we use to self host the Web API and we can use it to do the part of IIS for all hosting related configuration.

* SelfHostedWebApi.Owin is a self-hosted web API inside a console application using OWIN.
    - WebApp is the class to use in this application to start a web app using given settings.

* SelfHostedWebApi.Client is a console application that consumes the web APIs.


** Note: ** NuGet packages 'Microsoft.AspNet.WebApi.SelfHost', 'Microsoft.AspNet.WebApi.OwinSelfHost' and 'Microsoft.AspNet.WebApi.Client' must be installed on the projects SelfHostedWebApi.Simple, SelfHostedWebApi.Owin and SelftHostedWebApi.Client respectively. 