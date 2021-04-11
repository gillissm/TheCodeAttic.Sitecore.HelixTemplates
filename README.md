# TheCodeAttic.Sitecore.HelixTemplates

This repository supports two dotnet CLI new templates which are packaged into a single NuGet install.

## Sitecore.Helix.SolutionTemplate

This creates a simplified Visual Studio solution that is based off the ever popular [HelixBase project](https://github.com/muso31/Helixbase).

I have borrowed some of the basic structure from this project, but wanted a slightly simplier starting point without Glass and other services.

Some key elements:

* Website project is included that leverages [Helix Publishing Pipelines](https://github.com/richardszalay/helix-publishing-pipeline), parameters at creation exist to allow setting the publish target path
* Projects are based on the .NET Core SDK Library style
* Projects use NuGet PackageReferences
* A sample AzureDevops build pipeline YAML is include to help quick-start your CI/CD process

See the full [readme in the source code](/Sitecore.Helix.SolutionTemplate/TheCodeAttic/readme.md)

### To Create a New Solution

1. Open a PowerShell prompt
2. Change directory to your base code directory (ie: C:\Code)
3. At the prompt enter

```powershell
dotnet new sc-helixsln -n TheCodeAttic.Adventures --publishpath C:\Code\TheCodeAttic.Adventures\docker\src
```

## Sitecore.Helix.ModuleTemplate

To keep the solution simple and lightweight no Feature Modules have been included. These and additional foundation modules can be added by using the Sitecore.Helix.ModuleTemplate.

### Add a Module to the Solution

1. Open a PowerShell prompt
2. Change directory to the module layer folder (ie: C:\Code\TheCodeAttic.Adventures\src\Feature)
3. At the prompt enter

```powershell
dotnet new sc-helixmodule --projectname TheCodeAttic.Adventures --layer [Feature, Foundation, Project]  --modulename HeroImageDisplay
```

These parameters align to creating the namespace of the project and related setup classes, thus you can think of the paramaters as follows: "projectname.layer.modulename".

4. After running the new template command, you can return to Visual Studio.
5. Create a solution folder within the appropriate layer
6. Use the solution explorer context menu to add an existing project and select the one created in step 3.
