# .NET Core port notes of NetSerialization
By Joannes Vermorel, August 2016
Updated to .NETCore 1.1, May 2017

## The `NETCOREAPP1_1` compile flag

.NET Core is not fully backward compatible with .NET 4.x. Thus,
the compile flage `NETCOREAPP1_1` has been introduce in the solution
to adjust the code to make it compatible with .NET Core.

## `ISerializable` in .NET Core is in a reference package

In .NET Core, the `ISerializable` interface, as well as the
'SerializableAttribute' is in the System.Runtime.Serialization.Formatters package. 

Actually, the need to flag classes with `ISerializable` was questionnable
even in .NET 4.x. Thus, `ISerializable` behavior can now be avoided
through `Settings.SupportISerializable` in .NET 4.x.

## '(De)SerializationCallback' in .NET Core is in a reference package

In .NET Core, the ISerializable callbacks are in the
System.Runtime.Serialization.Primitives package.

## `Encoder.GetByteCount()` and `Encoder.Convert()`

The pointer-based overload of `Encoder.GetByteCount()` and `Encoder.Convert()`
have not been ported yet to .NET Core, but those overloads are already planned
for the version 1.2. For the time being, the .NET Core behavior of NetSerializer
relies on slow non-pointer overload. Once the pointer overloads become available
in .NET Core, this change should be reverted. The .NET 4.x version is still using
the fast overloads.

## Debugging Assembly and `AppDomain`

The `AppDomain` are no more in .NET Core (for now), so the compile flag
`GENERATE_DEBUGGING_ASSEMBLY` does not work in .NET Core.
