# C# Inventory
![text](/icon.svg)
## A simple Godot 4.2.2 inventory/item system.
### [MIT License](/addons/cs_inventory/LICENSE.md), Copyright 2024 Chase Carlson
---
Usage:

## This addon is NativeAOT publishing compatible!!!
With Godot 4.2+, the .NET runtime dependency can be a thing of the past! No more stinky virtual machine bytecode JIT voodoo.

To publish your Godot 4.2+ project fully compiled, add the following lines to your `[GodotGameProjectName].csproj` file...

* `<TargetFramework>net8.0</TargetFramework>` // this defaults to 6.0
* `<PublishAot>true</PublishAot>`
* `<IsAotCompatible>true</IsAotCompatible>`
* `<TrimmerRootAssembly Include="GodotSharp" />` // add to \<ItemGroup>
* `<TrimmerRootAssembly Include="$(TargetName)" />` // also add to \<ItemGroup>

*example .csproj file...*
```xml
<Project Sdk="Godot.NET.Sdk/4.2.2">
  <PropertyGroup>
	<TargetFramework>net8.0</TargetFramework>
	<EnableDynamicLoading>true</EnableDynamicLoading>
	<RootNamespace>CInventory</RootNamespace>
	<PublishAot>true</PublishAot>
	<IsAotCompatible>true</IsAotCompatible>
	<OptimizationPreference>Speed</OptimizationPreference>
  </PropertyGroup>
  <ItemGroup>
	<!-- Root the assemblies to avoid trimming. -->
	<TrimmerRootAssembly Include="GodotSharp" />
	<TrimmerRootAssembly Include="$(TargetName)" />
  </ItemGroup>
</Project>
```
