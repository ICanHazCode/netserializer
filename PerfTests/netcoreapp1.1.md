# NET Core 1.1
Serializer.Initialize() in 25 ms

## 1000 Object x 1000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |          40 |    0   0    0 |        1000 |
|NetSerializer  | MemStream Deserialize  |          21 |    7   0    0 |             |
|NetSerializer  | NetTest                |          66 |    7   0    0 |             |

## 100 LargeStruct x 30000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         526 |   45   0    0 |        1859 |
|NetSerializer  | MemStream Deserialize  |         456 |   45   0    0 |             |
|NetSerializer  | NetTest                |         832 |   91   0    0 |             |
|protobuf-net   | MemStream Serialize    |         987 |  190   0    0 |        2151 |
|protobuf-net   | MemStream Deserialize  |        1929 |   91   0    0 |             |
|protobuf-net   | NetTest                |        2485 |  283   0    0 |             |

## 100 LargeStruct x 30000 (direct) 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         458 |    0   0    0 |        1759 |
|NetSerializer  | MemStream Deserialize  |         431 |    0   0    0 |             |
|NetSerializer  | NetTest                |         723 |    0   0    0 |             |

## 100 Guid x 50000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         784 |   50   0    0 |        1966 |
|NetSerializer  | MemStream Deserialize  |         532 |   50   0    0 |             |
|NetSerializer  | NetTest                |        1313 |  102   0    0 |             |
|protobuf-net   | MemStream Serialize    |        7150 |  445   0    0 |        2100 |
|protobuf-net   | MemStream Deserialize  |        6908 |  139   0    0 |             |
|protobuf-net   | NetTest                |        8102 |  588   0    0 |             |

## 100 Guid x 50000 (direct) 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         659 |    0   0    0 |        1866 |
|NetSerializer  | MemStream Deserialize  |         562 |    0   0    0 |             |
|NetSerializer  | NetTest                |        1137 |    0   0    0 |             |

## 100 Int32 x 100000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         775 |   76   0    0 |         461 |
|NetSerializer  | MemStream Deserialize  |         448 |   76   0    0 |             |
|NetSerializer  | NetTest                |         989 |  153   0    0 |             |
|protobuf-net   | MemStream Serialize    |       14220 |  763   1    0 |         648 |
|protobuf-net   | MemStream Deserialize  |       14386 |  279   6    0 |             |
|protobuf-net   | NetTest                |       15274 | 1050   1    0 |             |

## 100 Int32 x 100000 (direct) 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         562 |    0   0    0 |         361 |
|NetSerializer  | MemStream Deserialize  |         537 |    0   0    0 |             |
|NetSerializer  | NetTest                |         750 |    0   0    0 |             |

## 100 U8Message x 100000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         508 |    0   0    0 |         200 |
|NetSerializer  | MemStream Deserialize  |        1021 |   76   0    0 |             |
|NetSerializer  | NetTest                |        1100 |   76   0    0 |             |
|protobuf-net   | MemStream Serialize    |        3316 |  483   0    0 |         527 |
|protobuf-net   | MemStream Deserialize  |        7206 |   76   0    0 |             |
|protobuf-net   | NetTest                |        8108 |  560   0    0 |             |

## 100 U8Message x 100000 (direct) 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         402 |    0   0    0 |         100 |
|NetSerializer  | MemStream Deserialize  |        1147 |   76   0    0 |             |
|NetSerializer  | NetTest                |        1224 |   76   0    0 |             |

## 100 S16Message x 100000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         620 |    0   0    0 |         341 |
|NetSerializer  | MemStream Deserialize  |        1164 |   76   0    0 |             |
|NetSerializer  | NetTest                |        1290 |   76   0    0 |             |
|protobuf-net   | MemStream Serialize    |        3526 |  483   0    0 |         844 |
|protobuf-net   | MemStream Deserialize  |        7499 |   76   0    0 |             |
|protobuf-net   | NetTest                |        8308 |  560   0    0 |             |

## 100 S32Message x 100000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         695 |    0   0    0 |         461 |
|NetSerializer  | MemStream Deserialize  |        1209 |   76   0    0 |             |
|NetSerializer  | NetTest                |        1383 |   76   0    0 |             |
|protobuf-net   | MemStream Serialize    |        3661 |  483   0    0 |         828 |
|protobuf-net   | MemStream Deserialize  |        7638 |   76   0    0 |             |
|protobuf-net   | NetTest                |        8893 |  560   0    0 |             |

## 100 S64Message x 100000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         777 |    0   0    0 |         542 |
|NetSerializer  | MemStream Deserialize  |        1325 |   76   0    0 |             |
|NetSerializer  | NetTest                |        1513 |   76   0    0 |             |
|protobuf-net   | MemStream Serialize    |        3795 |  483   0    0 |         809 |
|protobuf-net   | MemStream Deserialize  |        8194 |   76   0    0 |             |
|protobuf-net   | NetTest                |        8708 |  560   0    0 |             |

## 100 DecimalMessage x 50000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         730 |   63   0    0 |        1360 |
|NetSerializer  | MemStream Deserialize  |         982 |   50   0    0 |             |
|NetSerializer  | NetTest                |        1228 |  114   0    0 |             |
|protobuf-net   | MemStream Serialize    |        2803 |  305   0    0 |        2022 |
|protobuf-net   | MemStream Deserialize  |        5292 |   50   0    0 |             |
|protobuf-net   | NetTest                |        5741 |  356   0    0 |             |

## 100 NullableDecimalMessage x 100000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         573 |    3   0    0 |         238 |
|NetSerializer  | MemStream Deserialize  |        1120 |  127   0    0 |             |
|NetSerializer  | NetTest                |        1226 |  131   0    0 |             |
|protobuf-net   | MemStream Serialize    |        4441 |  487   0    0 |         353 |
|protobuf-net   | MemStream Deserialize  |        8183 |  127   0    0 |             |
|protobuf-net   | NetTest                |        9080 |  615   0    0 |             |

## 100 PrimitivesMessage x 10000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         720 |   12   0    0 |        5286 |
|NetSerializer  | MemStream Deserialize  |         752 |   38   0    0 |             |
|NetSerializer  | NetTest                |        1014 |   51   0    0 |             |
|protobuf-net   | MemStream Serialize    |         758 |   48   0    0 |        7290 |
|protobuf-net   | MemStream Deserialize  |        1270 |   25   0    0 |             |
|protobuf-net   | NetTest                |        1593 |   74   0    0 |             |

## 10 DictionaryMessage x 1000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |        1592 |  150   0    0 |       86187 |
|NetSerializer  | MemStream Deserialize  |        2089 |  109  54    0 |             |
|NetSerializer  | NetTest                |        2529 |  200 100    0 |             |
|protobuf-net   | MemStream Serialize    |        2122 |  206   0    0 |      142035 |
|protobuf-net   | MemStream Deserialize  |        4611 |  233 116    0 |             |
|protobuf-net   | NetTest                |        5556 |  480 240    0 |             |

## 100 ComplexMessage x 10000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         440 |    0   0    0 |        2838 |
|NetSerializer  | MemStream Deserialize  |         707 |   50   0    0 |             |
|NetSerializer  | NetTest                |         811 |   50   0    0 |             |
|protobuf-net   | MemStream Serialize    |        1014 |   48   0    0 |        5087 |
|protobuf-net   | MemStream Deserialize  |        2348 |   50   0    0 |             |
|protobuf-net   | NetTest                |        2575 |   99   0    0 |             |

## 100 StringMessage x 20000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         733 |  149   0    0 |        4886 |
|NetSerializer  | MemStream Deserialize  |         607 |   91   0    0 |             |
|NetSerializer  | NetTest                |        1297 |  243   0    0 |             |
|protobuf-net   | MemStream Serialize    |        1111 |   96   0    0 |        5085 |
|protobuf-net   | MemStream Deserialize  |        4796 |   91   0    0 |             |
|protobuf-net   | NetTest                |        2950 |  188   0    0 |             |

## 100 StructMessage x 20000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         759 |   54   0    0 |        2455 |
|NetSerializer  | MemStream Deserialize  |         725 |   58   0    0 |             |
|NetSerializer  | NetTest                |        1102 |  113   0    0 |             |
|protobuf-net   | MemStream Serialize    |        1508 |  137   0    0 |        3622 |
|protobuf-net   | MemStream Deserialize  |        5200 |  140   0    0 |             |
|protobuf-net   | NetTest                |        3297 |  278   0    0 |             |

## 100 BoxedPrimitivesMessage x 20000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         812 |    0   0    0 |        1723 |
|NetSerializer  | MemStream Deserialize  |         730 |  111   0    0 |             |
|NetSerializer  | NetTest                |        1026 |  111   0    0 |             |

## 10000 ByteArrayMessage x 1 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         547 |    1   1    1 |   498085311 |
|NetSerializer  | MemStream Deserialize  |         353 |   58  30    1 |             |
|NetSerializer  | NetTest                |        1010 |   57  27    0 |             |
|protobuf-net   | MemStream Serialize    |        1033 |  173   6    3 |   498151945 |
|protobuf-net   | MemStream Deserialize  |         351 |   58  29    1 |             |
|protobuf-net   | NetTest                |        1595 |  171  39    2 |             |

## 1000 IntArrayMessage x 1 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |        1568 |    0   0    0 |   177278871 |
|NetSerializer  | MemStream Deserialize  |        1167 |    2   1    0 |             |
|NetSerializer  | NetTest                |        2096 |    2   0    0 |             |
|protobuf-net   | MemStream Serialize    |        1868 |   39   2    1 |   283510795 |
|protobuf-net   | MemStream Deserialize  |        1714 |   24   3    0 |             |
|protobuf-net   | NetTest                |        2281 |   59   5    2 |             |

## 10 TriDimArrayCustomSerializersMessage x 100 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |        1230 |    0   0    0 |     1601277 |
|NetSerializer  | MemStream Deserialize  |        1181 |   33  31   29 |             |
|NetSerializer  | NetTest                |        2062 |   47  44   43 |             |
