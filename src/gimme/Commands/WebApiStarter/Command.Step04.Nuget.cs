﻿using gimme.Services.Files;
using gimme.Shell.Services;
using gimme.Utils;
using McMaster.Extensions.CommandLineUtils;
using System;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace gimme.Commands.WebApiStarter
{

    public partial class Command
    {
        private void Step04_ConfigureNugetReference()
        {
            //Web Api
            ConsoleUtil.HiglightedMessage($"Add package reference to {variable.CSPROJ_WebApiProjectFile}");
            Console.WriteLine(shellService.Exec($"dotnet add {variable.CSPROJ_WebApiProjectFile} package AutoMapper"));
            Console.WriteLine(shellService.Exec($"dotnet add {variable.CSPROJ_WebApiProjectFile} package AutoMapper.Extensions.Microsoft.DependencyInjection"));
            Console.WriteLine(shellService.Exec($"dotnet add {variable.CSPROJ_WebApiProjectFile} package FluentValidation.AspNetCore"));
            Console.WriteLine(shellService.Exec($"dotnet add {variable.CSPROJ_WebApiProjectFile} package MediatR"));
            Console.WriteLine(shellService.Exec($"dotnet add {variable.CSPROJ_WebApiProjectFile} package MediatR.Extensions.Microsoft.DependencyInjection"));
            //Console.WriteLine(shellService.Exec($"dotnet add {variable.CSPROJ_WebApiProjectFile} package Microsoft.AspNetCore.Mvc.Api.Analyzers"));
            Console.WriteLine(shellService.Exec($"dotnet add {variable.CSPROJ_WebApiProjectFile} package Microsoft.EntityFrameworkCore.SqlServer"));
            Console.WriteLine(shellService.Exec($"dotnet add {variable.CSPROJ_WebApiProjectFile} package Microsoft.EntityFrameworkCore.Tools"));
            Console.WriteLine(shellService.Exec($"dotnet add {variable.CSPROJ_WebApiProjectFile} package Microsoft.Extensions.Configuration.Json"));
            Console.WriteLine(shellService.Exec($"dotnet add {variable.CSPROJ_WebApiProjectFile} package NSwag.AspNetCore -v 13.0.2"));
            Console.WriteLine(shellService.Exec($"dotnet add {variable.CSPROJ_WebApiProjectFile} package Newtonsoft.Json"));
            Console.WriteLine(shellService.Exec($"dotnet add {variable.CSPROJ_WebApiProjectFile} package Microsoft.AspNetCore.Mvc.NewtonsoftJson"));

            //Application
            ConsoleUtil.HiglightedMessage($"Add package reference to {variable.CSPROJ_ApplicationProjectFile}");
            Console.WriteLine(shellService.Exec($"dotnet add {variable.CSPROJ_ApplicationProjectFile} package AutoMapper"));
            Console.WriteLine(shellService.Exec($"dotnet add {variable.CSPROJ_ApplicationProjectFile} package FluentValidation"));
            Console.WriteLine(shellService.Exec($"dotnet add {variable.CSPROJ_ApplicationProjectFile} package MediatR"));
            Console.WriteLine(shellService.Exec($"dotnet add {variable.CSPROJ_ApplicationProjectFile} package NJsonSchema"));

            //Application Test
            ConsoleUtil.HiglightedMessage($"Add package reference to {variable.CSPROJ_ApplicationUnitTestProjectFile}");
            Console.WriteLine(shellService.Exec($"dotnet add {variable.CSPROJ_ApplicationUnitTestProjectFile} package Microsoft.EntityFrameworkCore.InMemory"));
            Console.WriteLine(shellService.Exec($"dotnet add {variable.CSPROJ_ApplicationUnitTestProjectFile} package Moq"));
            Console.WriteLine(shellService.Exec($"dotnet add {variable.CSPROJ_ApplicationUnitTestProjectFile} package xunit -f netcoreapp3.1"));
            Console.WriteLine(shellService.Exec($"dotnet add {variable.CSPROJ_ApplicationUnitTestProjectFile} package xunit.runner.visualstudio -f netcoreapp3.1"));
            Console.WriteLine(shellService.Exec($"dotnet add {variable.CSPROJ_ApplicationUnitTestProjectFile} package Microsoft.NET.Test.Sdk -f netcoreapp3.1"));
            Console.WriteLine(shellService.Exec($"dotnet add {variable.CSPROJ_ApplicationUnitTestProjectFile} package AutoMapper"));

            //Persistence
            ConsoleUtil.HiglightedMessage($"Add package reference to {variable.CSPROJ_PersistenceProjectFile}");
            Console.WriteLine(shellService.Exec($"dotnet add {variable.CSPROJ_PersistenceProjectFile} package Microsoft.EntityFrameworkCore.SqlServer"));
            Console.WriteLine(shellService.Exec($"dotnet add {variable.CSPROJ_PersistenceProjectFile} package Microsoft.EntityFrameworkCore.Tools"));
            Console.WriteLine(shellService.Exec($"dotnet add {variable.CSPROJ_PersistenceProjectFile} package Microsoft.Extensions.Configuration.Json"));

            //Services
            ConsoleUtil.HiglightedMessage($"Add package reference to {variable.CSPROJ_ServicesProjectFile}");
            Console.WriteLine(shellService.Exec($"dotnet add {variable.CSPROJ_ServicesProjectFile} package RestSharp"));

            //Services Test
            ConsoleUtil.HiglightedMessage($"Add package reference to {variable.CSPROJ_ServicesUnitTestProjectFile}");
            Console.WriteLine(shellService.Exec($"dotnet add {variable.CSPROJ_ServicesUnitTestProjectFile} package Moq"));
            Console.WriteLine(shellService.Exec($"dotnet add {variable.CSPROJ_ServicesUnitTestProjectFile} package xunit -f netcoreapp3.1"));
            Console.WriteLine(shellService.Exec($"dotnet add {variable.CSPROJ_ServicesUnitTestProjectFile} package xunit.runner.visualstudio -f netcoreapp3.1"));
            Console.WriteLine(shellService.Exec($"dotnet add {variable.CSPROJ_ServicesUnitTestProjectFile} package Microsoft.NET.Test.Sdk -f netcoreapp3.1"));
            Console.WriteLine(shellService.Exec($"dotnet add {variable.CSPROJ_ServicesUnitTestProjectFile} package AutoMapper"));

        }
    }
}
