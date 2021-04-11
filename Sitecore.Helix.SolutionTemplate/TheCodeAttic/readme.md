# Getting Started

Giving credit where it is due, this simplified structure is based off the ever popular [HelixBase project](https://github.com/muso31/Helixbase).

I have borrowed some of the basic structure from this project, but wanted a slightly simplier starting point without Glass and other services.

Some key elements:

* Website project is included that leverages [Helix Publishing Pipelines](https://github.com/richardszalay/helix-publishing-pipeline), parameters at creation exist to allow setting the publish target path
* Projects are based on the .NET Core SDK Library style
* Projects use NuGet PackageReferences
* A sample AzureDevops build pipeline YAML is include to help quick-start your CI/CD process

## To Create a New Solution

1. Open a PowerShell prompt
2. Change directory to your base code directory (ie: C:\Code)
3. At the prompt enter

```powershell
dotnet new sc-helixsln -n TheCodeAttic.Adventures --publishpath C:\Code\TheCodeAttic.Adventures\docker\src
```

## Adding Modules

To keep the solution simple and lightweight no Feature Modules have been included. These and additional foundation modules can be added via:

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

## Quick Docker Note

If you plan to leverage docker based containers for you development process checkout the dotnet cli new template [TheCodeAttic.Sitecore.DockerTemplates](https://www.nuget.org/packages/TheCodeAttic.Sitecore.DockerTemplates/).

### To Add Docker Required Files

Following assumes you have already installed the [TheCodeAttic.Sitecore.DockerTemplates](https://www.nuget.org/packages/TheCodeAttic.Sitecore.DockerTemplates/) template module.

1. Open a PowerShell prompt
2. Change directory to the project folder (ie: C:\Code\TheCodeAttic.Adventures), you want to be at the same level as _src_.
3. At the prompt enter

```powershell
docker new sc-dockerrun -n docker
```
