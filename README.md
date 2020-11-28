# Bannerlord Module Template
<p align="center">
   <a href="https://www.nuget.org/packages/Bannerlord.Templates" alt="NuGet Bannerlord.MCM">
   <img src="https://img.shields.io/nuget/v/Bannerlord.Templates.svg?label=NuGet%20Bannerlord.Templates&colorB=blue" /></a>
</p>
<p>
   <img src="https://cdn.discordapp.com/attachments/555699650452258816/782380466727944192/unknown.png" width="800">
</p>

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
<p>
   <img src="https://devblogs.microsoft.com/dotnet/wp-content/uploads/sites/10/2020/09/clitemplates-option-enable.png" width="600">
</p>

## FAQ
### What 'Target Framework' should I chose?
If you plan on using Harmony or WinForms, use `.NET Framework 4.7.2`. If not, you can chose `.NET Standard 2.0`.  
### What are the differenced between 'soft-dependency' and 'hard-dependency?
**Hard dependency** means that an entry will be added to `SubModules.xml`. Your Module will not include the dependency inside it's `/bin` folder (the .dll). It won't allow the game to run your mod without the dependency installed as a separate Module. This is an important feature to prevent having multiple versions of the same dependency running within the game.  
**Soft dependency** means that nothing will be added to `SubModules.xml`. Your Module will include the dependency inside it's `/bin` folder (the .dll).
### What is this variable 'Bannerlord Game Folder Location'?
`$(BANNERLORD_GAME_DIR)` is an environment variable. We think that it would be best to set it once on the system instead of hardcoding the game path in the project.  
Feel free to replace it with a full folder path like `C:\Program Files (x86)\Steam\steamapps\common\Mount & Blade II Bannerlord` if you don't want to use the environment variable.  
### What is this variable 'Module Name'?
`$(MSBuildProjectName)` is a MSBuild built-in variable that return the file name of the project file without the file name extension; for example, `Bannerlord.Module1`.  
If you don't plan on keeping the Module folder name the same as the project that is being created, override it.  
### What is this variable 'Language Version'?
The version of C# that is used. By default, the value is `9.0`, which is the latest currently.  
### Should I set 'Use Nullable Feature'?
Read the [docs](https://docs.microsoft.com/en-us/dotnet/csharp/nullable-references) on Nullable reference types to decide if you need this feature!  
