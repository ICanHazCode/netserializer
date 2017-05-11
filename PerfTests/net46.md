# NET Framework 4.6
Serializer.Initialize() in 21 ms

## 1000 Object x 1000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |          45 |    0   0    0 |        1000 |
|NetSerializer  | MemStream Deserialize  |          23 |    7   0    0 |             |
|NetSerializer  | NetTest                |          56 |    7   0    0 |             |

## 100 LargeStruct x 30000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         783 |   45   0    0 |        1859 |
|NetSerializer  | MemStream Deserialize  |         418 |   45   0    0 |             |
|NetSerializer  | NetTest                |         967 |   91   0    0 |             |
|protobuf-net   | MemStream Serialize    |        1008 |  190   0    0 |        2151 |
|protobuf-net   | MemStream Deserialize  |        1609 |   91   0    0 |             |
|protobuf-net   | NetTest                |        2050 |  283   0    0 |             |

## 100 LargeStruct x 30000 (direct) 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         527 |    0   0    0 |        1759 |
|NetSerializer  | MemStream Deserialize  |         422 |    0   0    0 |             |
|NetSerializer  | NetTest                |         690 |    0   0    0 |             |

## 100 Guid x 50000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |        1192 |   50   0    0 |        1968 |
|NetSerializer  | MemStream Deserialize  |         538 |   50   0    0 |             |
|NetSerializer  | NetTest                |        1466 |  102   0    0 |             |
|protobuf-net   | MemStream Serialize    |        5094 |  445   0    0 |        2100 |
|protobuf-net   | MemStream Deserialize  |        5069 |  139   0    0 |             |
|protobuf-net   | NetTest                |        6399 |  588   0    0 |             |

## 100 Guid x 50000 (direct) 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         738 |    0   0    0 |        1874 |
|NetSerializer  | MemStream Deserialize  |         589 |    0   0    0 |             |
|NetSerializer  | NetTest                |         914 |    0   0    0 |             |

## 100 Int32 x 100000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |        1482 |   76   0    0 |         461 |
|NetSerializer  | MemStream Deserialize  |         448 |   76   0    0 |             |
|NetSerializer  | NetTest                |        1653 |  153   0    0 |             |
|protobuf-net   | MemStream Serialize    |        9885 |  763   0    0 |         648 |
|protobuf-net   | MemStream Deserialize  |       10092 |  279   6    0 |             |
|protobuf-net   | NetTest                |       11422 | 1049   1    0 |             |

## 100 Int32 x 100000 (direct) 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         627 |    0   0    0 |         361 |
|NetSerializer  | MemStream Deserialize  |         575 |    0   0    0 |             |
|NetSerializer  | NetTest                |         679 |    0   0    0 |             |

## 100 U8Message x 100000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |        1198 |    0   0    0 |         200 |
|NetSerializer  | MemStream Deserialize  |        1126 |   76   0    0 |             |
|NetSerializer  | NetTest                |        1291 |   76   0    0 |             |
|protobuf-net   | MemStream Serialize    |        3377 |  483   0    0 |         527 |
|protobuf-net   | MemStream Deserialize  |        5806 |   76   0    0 |             |
|protobuf-net   | NetTest                |        6886 |  560   0    0 |             |

## 100 U8Message x 100000 (direct) 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         424 |    0   0    0 |         100 |
|NetSerializer  | MemStream Deserialize  |        1247 |   76   0    0 |             |
|NetSerializer  | NetTest                |        1328 |   76   0    0 |             |

## 100 S16Message x 100000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         666 |    0   0    0 |         341 |
|NetSerializer  | MemStream Deserialize  |        1284 |   76   0    0 |             |
|NetSerializer  | NetTest                |        1456 |   76   0    0 |             |
|protobuf-net   | MemStream Serialize    |        3601 |  483   0    0 |         844 |
|protobuf-net   | MemStream Deserialize  |        6068 |   76   0    0 |             |
|protobuf-net   | NetTest                |        7283 |  560   0    0 |             |

## 100 S32Message x 100000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         745 |    0   0    0 |         461 |
|NetSerializer  | MemStream Deserialize  |        1402 |   76   0    0 |             |
|NetSerializer  | NetTest                |        1572 |   76   0    0 |             |
|protobuf-net   | MemStream Serialize    |        3775 |  483   0    0 |         828 |
|protobuf-net   | MemStream Deserialize  |        6243 |   76   0    0 |             |
|protobuf-net   | NetTest                |        7455 |  560   0    0 |             |

## 100 S64Message x 100000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         821 |    0   0    0 |         542 |
|NetSerializer  | MemStream Deserialize  |        1425 |   76   0    0 |             |
|NetSerializer  | NetTest                |        1699 |   76   0    0 |             |
|protobuf-net   | MemStream Serialize    |        3919 |  483   0    0 |         809 |
|protobuf-net   | MemStream Deserialize  |        6479 |   76   0    0 |             |
|protobuf-net   | NetTest                |        7586 |  560   0    0 |             |

## 100 DecimalMessage x 50000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         718 |   63   0    0 |        1360 |
|NetSerializer  | MemStream Deserialize  |        1046 |   50   0    0 |             |
|NetSerializer  | NetTest                |        1403 |  114   0    0 |             |
|protobuf-net   | MemStream Serialize    |        3044 |  305   0    0 |        2022 |
|protobuf-net   | MemStream Deserialize  |        4415 |   50   0    0 |             |
|protobuf-net   | NetTest                |        5173 |  356   0    0 |             |

## 100 NullableDecimalMessage x 100000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         610 |    3   0    0 |         238 |
|NetSerializer  | MemStream Deserialize  |        1285 |  127   0    0 |             |
|NetSerializer  | NetTest                |        1412 |  131   0    0 |             |
|protobuf-net   | MemStream Serialize    |        4856 |  487   0    0 |         353 |
|protobuf-net   | MemStream Deserialize  |        7062 |  127   0    0 |             |
|protobuf-net   | NetTest                |        8146 |  615   0    0 |             |

## 100 PrimitivesMessage x 10000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         747 |   12   0    0 |        5286 |
|NetSerializer  | MemStream Deserialize  |         843 |   38   0    0 |             |
|NetSerializer  | NetTest                |        1111 |   51   0    0 |             |
|protobuf-net   | MemStream Serialize    |         801 |   48   0    0 |        7290 |
|protobuf-net   | MemStream Deserialize  |        1145 |   25   0    0 |             |
|protobuf-net   | NetTest                |        1448 |   74   0    0 |             |

## 10 DictionaryMessage x 1000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |        1415 |   37   0    0 |       86187 |
|NetSerializer  | MemStream Deserialize  |        1946 |  109  54    0 |             |
|NetSerializer  | NetTest                |        2366 |  133  66    0 |             |
|protobuf-net   | MemStream Serialize    |        2112 |  206   0    0 |      142035 |
|protobuf-net   | MemStream Deserialize  |        3886 |  233 116    0 |             |
|protobuf-net   | NetTest                |        4720 |  449 224    0 |             |

## 100 ComplexMessage x 10000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         469 |    0   0    0 |        2838 |
|NetSerializer  | MemStream Deserialize  |         756 |   50   0    0 |             |
|NetSerializer  | NetTest                |         895 |   50   0    0 |             |
|protobuf-net   | MemStream Serialize    |        1047 |   48   0    0 |        5087 |
|protobuf-net   | MemStream Deserialize  |        1954 |   50   0    0 |             |
|protobuf-net   | NetTest                |        2199 |   99   0    0 |             |

## 100 StringMessage x 20000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         442 |    0   0    0 |        4886 |
|NetSerializer  | MemStream Deserialize  |         615 |   91   0    0 |             |
|NetSerializer  | NetTest                |        1042 |   91   0    0 |             |
|protobuf-net   | MemStream Serialize    |        1145 |   96   0    0 |        5085 |
|protobuf-net   | MemStream Deserialize  |        4452 |   91   0    0 |             |
|protobuf-net   | NetTest                |        2688 |  188   0    0 |             |

## 100 StructMessage x 20000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         546 |    0   0    0 |        2455 |
|NetSerializer  | MemStream Deserialize  |         679 |   58   0    0 |             |
|NetSerializer  | NetTest                |         876 |   58   0    0 |             |
|protobuf-net   | MemStream Serialize    |        1563 |  137   0    0 |        3622 |
|protobuf-net   | MemStream Deserialize  |        4865 |  140   0    0 |             |
|protobuf-net   | NetTest                |        3018 |  278   0    0 |             |

## 100 BoxedPrimitivesMessage x 20000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         954 |    0   0    0 |        1723 |
|NetSerializer  | MemStream Deserialize  |         755 |  111   0    0 |             |
|NetSerializer  | NetTest                |        1078 |  111   0    0 |             |

## 10000 ByteArrayMessage x 1 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         547 |    1   1    1 |   498085311 |
|NetSerializer  | MemStream Deserialize  |         266 |   58  30    1 |             |
|NetSerializer  | NetTest                |         987 |   56  26    0 |             |
|protobuf-net   | MemStream Serialize    |        1048 |  173   6    3 |   498151945 |
|protobuf-net   | MemStream Deserialize  |         360 |   58  29    1 |             |
|protobuf-net   | NetTest                |        1576 |  176  40    2 |             |

## 1000 IntArrayMessage x 1 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |        1606 |    0   0    0 |   177278871 |
|NetSerializer  | MemStream Deserialize  |        1181 |    2   1    0 |             |
|NetSerializer  | NetTest                |        1611 |    1   0    0 |             |
|protobuf-net   | MemStream Serialize    |        1888 |   39   2    1 |   283510795 |
|protobuf-net   | MemStream Deserialize  |        1708 |   24   3    0 |             |
|protobuf-net   | NetTest                |        2259 |   59   5    2 |             |

## 10 TriDimArrayCustomSerializersMessage x 100 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |        1293 |    0   0    0 |     1601277 |
|NetSerializer  | MemStream Deserialize  |        1171 |   33  31   29 |             |
|NetSerializer  | NetTest                |        1854 |   47  44   43 |             |
