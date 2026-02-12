# LogicBuilder.DataContracts

A .NET Standard 2.0 library that defines data transfer objects (DTOs) for real-time deployment of business rules during development from the [Logic Builder Client](https://github.com/BpsLogicBuilder/LogicBuilder) to Web API endpoints.

## Purpose

This library provides the contract definitions used for communication between the Logic Builder design-time client and runtime Web API services. It enables developers to deploy and manage business rules dynamically without recompiling the target application.

## Data Contracts

### ModuleData
Represents a deployable module containing compiled business rules and associated resources.

- `RulesStream` - Binary stream of compiled rules
- `ResourcesStream` - Binary stream of module resources
- `ModuleName` - Identifier for the module
- `Application` - Target application name
- `UserData` - Custom metadata
- `UploadedBy` - User who deployed the module
- `UploadedTime` - Deployment timestamp

### DeleteRulesData
Represents a request to delete specific rule files from the target application.

- `Files` - Array of file paths to delete
- `Application` - Target application name
- `UserData` - Custom metadata
- `DeletedBy` - User who initiated the deletion
- `DeleteTime` - Deletion timestamp

### DeleteAllRulesData ⚠️ Obsolete
> **Note:** This class is obsolete. To delete all rules, select the top node in the treeview, which will select all nodes and use the `DeleteRulesData` class for each instance.

### VariableMetaData ⚠️ Obsolete
> **Note:** This class is obsolete since LogicBuilder v2.0.0. It was used for standard forms which have been removed.

## Installation
`dotnet add package LogicBuilder.DataContracts`

## Usage

These DTOs are typically serialized as JSON or XML when transmitted between the Logic Builder client and your Web API. Implement endpoints in your API that accept these contracts to enable dynamic rule deployment.

## Target Framework

- .NET Standard 2.0 (compatible with .NET Framework 4.6.1+ and .NET Core 2.0+)

## Links

- [Logic Builder Client](https://github.com/BlaiseD/LogicBuilder)
- [Repository](https://github.com/BpsLogicBuilder/LogicBuilder.DataContracts)
- [NuGet Package](https://www.nuget.org/packages/LogicBuilder.DataContracts/)

## License

MIT License - Copyright © BPS 2017

