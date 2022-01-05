# revuo-home-plugin-watch

## Create new project
Just start with creating new project as a razor class library
```
dotnet new razorclasslib --name HelloWorld
```
Add some references abstraction for plugin development
```
dotnet add .\HelloWorld\ package Revuo.Home.Abstractions
```

## Relase
```
git tag v1.0.1
git push --tags
```
