# .NET Core port notes of NetSerialization
By Joannes Vermorel, August 2016
Updated to .NETCore 1.1, May 2017

## Compile flags

The .NET 3.5/4.0 frameworks and .NET Core have compatibility issues.
Each different supported framework has their own flag:
> NET35
> NET40
> NET45
> NET452
> NET46
> NET462
> NETCOREAPP1_1

## `ISerializable` in .NET Core is in a reference package

In .NET Core, the `ISerializable` interface, as well as the
'SerializableAttribute' is in the `System.Runtime.Serialization.Formatters` package. 

Actually, the need to flag classes with `ISerializable` was questionnable
even in .NET 4.x. Thus, `ISerializable` behavior can now be avoided
through `Settings.SupportISerializable` in .NET 3.5/4.x.

## `(De)SerializationCallback` in .NET Core is in a reference package

In .NET Core, the ISerializable callbacks are in the
`System.Runtime.Serialization.Primitives` package.

## `Encoder.GetByteCount()` and `Encoder.Convert()`

The pointer-based overload of `Encoder.GetByteCount()` and `Encoder.Convert()`
have not been ported yet to .NET Core, but those overloads are already planned
for the version 1.2. For the time being, the .NET Core behavior of NetSerializer
relies on slow non-pointer overload. Once the pointer overloads become available
in .NET Core, this change should be reverted. The .NET 3.5/4.x versions are still using
the fast overloads.

## Debugging Assembly and `AppDomain`

The `AppDomain` are no more in .NET Core (for now), so the compile flag
`GENERATE_DEBUGGING_ASSEMBLY` does not work in .NET Core.
