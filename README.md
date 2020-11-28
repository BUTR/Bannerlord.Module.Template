# Bannerlord Module Template

 [![Bannerlord.Templates NuGet Package](https://img.shields.io/nuget/v/Bannerlord.Templates.svg)](https://www.nuget.org/packages/Bannerlord.Templates/)

## Installation
1. Install the latest [.NET Core SDK](https://dot.net).
2. Run `dotnet new --install Bannerlord.Templates` to install the project templates.

## Creating a new Module

### Creating from command line:
1. Choose a project template i.e. `blmodfx`.
2. Run `dotnet new blmodfx --help` to see how to select the feature of the project.
3. Run `dotnet new blmodfx --name "Bannerlord.MyModule"` along with any other custom options to create a project from the template.

### Creating via Visual Studio
You need to have at least an 16.8.x version create the template!  
You also need to use the new template feature:  
![Image](https://devblogs.microsoft.com/dotnet/wp-content/uploads/sites/10/2020/09/clitemplates-option-enable.png)
