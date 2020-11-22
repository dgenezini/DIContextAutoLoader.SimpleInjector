# DIContextAutoLoader.SimpleInjector

[![NuGet version (DIContextAutoLoader.SimpleInjector)](https://img.shields.io/nuget/v/DIContextAutoLoader.SimpleInjector.svg?style=flat-square)](https://www.nuget.org/packages/DIContextAutoLoader.SimpleInjector/)

Extension of [DIContextAutoLoader](https://github.com/dgenezini/DIContextAutoLoader) to use with Ninject.

# Package

```
    Install-Package DIContextAutoLoader.SimpleInjector
```

# Usage

```csharp
private static void RegisterServices(Container container)
{
    container.AutoLoadServices(typeof(SomeTypeInAssembly).Assembly);

    ...
}
```
