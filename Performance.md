# Performance

Below is a performance comparison between NetSerializer and protobuf-net.
Protobuf-net is a fast Protocol Buffers compatible serializer, which was the
best serializer I could find out there when I considered the serializer for
my use case.

The tests create an array of N items of particular type, created with random
data. The items are then serialized, and this is repeated M times for the same
dataset. NetSerializer can also serialize types directly, without writing any
meta information or boxing of value types. These tests are marked with
"(direct)".

The table lists the time it takes to run the test, the number of GC collections
(per generation) that happened during the test, and the size of the
serialized data output (when available).

There are three tests:

- MemStream Serialize - serializes an array of objects to a memory stream.

- MemStream Deserialize - deserializes the stream created with the MemStream
  Serialize test.

- NetTest - uses two threads: the first one serializes objects and
  sends them over a local socket, and the second one receives the data and
  deserializes the objects. Note that the size is not available for NetTest, as
  tracking the sent data is not trivial. However, the dataset is the same as
  with MemStream, and so is the size of the data.

The details of the tests can be found from the source code. The tests were run
on an Intel Core i5-2320 @ 3GHz, 8GB RAM, Windows 10 Pro 64-bit.

## Tests
- [NET Framework 3.5](PerfTests/net35.md)
- [NET Framework 4.0](PerfTests/net40.md)
- [NET Framework 4.5](PerfTests/net45.md)
- [NET Framework 4.5.2](PerfTests/net452.md)
- [NET Framework 4.6](PerfTests/net46.md)
- [NET Framework 4.6.2](PerfTests/net462.md)
- [NET Core 1.1](PerfTests/netcoreapp1.1.md)

As can be seen from the tests, NetSerializer is clearly faster and has smaller
memory footprint in about all of the cases. For example, the tests with
ComplexMessages show NetSerializer's MemStream Serialize cause zero garbage
collections, even though more than 20MB of data is being serialized.
