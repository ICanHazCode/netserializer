# NET Framework 4.0
Serializer.Initialize() in 23 ms

## 1000 Object x 1000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |          52 |    0   0    0 |        1000 |
|NetSerializer  | MemStream Deserialize  |          26 |    7   0    0 |             |
|NetSerializer  | NetTest                |          57 |    7   0    0 |             |

## 100 LargeStruct x 30000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         595 |   45   0    0 |        1859 |
|NetSerializer  | MemStream Deserialize  |         441 |   45   0    0 |             |
|NetSerializer  | NetTest                |         774 |   91   0    0 |             |
|protobuf-net   | MemStream Serialize    |        1048 |  190   0    0 |        2151 |
|protobuf-net   | MemStream Deserialize  |        1579 |   91   0    0 |             |
|protobuf-net   | NetTest                |        2401 |  283   0    0 |             |

## 100 LargeStruct x 30000 (direct) 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         537 |    0   0    0 |        1759 |
|NetSerializer  | MemStream Deserialize  |         458 |    0   0    0 |             |
|NetSerializer  | NetTest                |         719 |    0   0    0 |             |

## 100 Guid x 50000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         867 |   50   0    0 |        1968 |
|NetSerializer  | MemStream Deserialize  |         538 |   50   0    0 |             |
|NetSerializer  | NetTest                |        1147 |  102   0    0 |             |
|protobuf-net   | MemStream Serialize    |        5319 |  445   0    0 |        2100 |
|protobuf-net   | MemStream Deserialize  |        5315 |  139   0    0 |             |
|protobuf-net   | NetTest                |        6754 |  588   0    0 |             |

## 100 Guid x 50000 (direct) 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         794 |    0   0    0 |        1872 |
|NetSerializer  | MemStream Deserialize  |         624 |    0   0    0 |             |
|NetSerializer  | NetTest                |         965 |    0   0    0 |             |

## 100 Int32 x 100000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         861 |   76   0    0 |         461 |
|NetSerializer  | MemStream Deserialize  |         450 |   76   0    0 |             |
|NetSerializer  | NetTest                |         989 |  153   0    0 |             |
|protobuf-net   | MemStream Serialize    |       10085 |  763   1    0 |         648 |
|protobuf-net   | MemStream Deserialize  |       10296 |  279   6    0 |             |
|protobuf-net   | NetTest                |       12153 | 1050   1    0 |             |

## 100 Int32 x 100000 (direct) 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         650 |    0   0    0 |         361 |
|NetSerializer  | MemStream Deserialize  |         624 |    0   0    0 |             |
|NetSerializer  | NetTest                |         978 |    0   0    0 |             |

## 100 U8Message x 100000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         604 |    0   0    0 |         200 |
|NetSerializer  | MemStream Deserialize  |        1120 |   76   0    0 |             |
|NetSerializer  | NetTest                |        1248 |   76   0    0 |             |
|protobuf-net   | MemStream Serialize    |        3226 |  483   0    0 |         527 |
|protobuf-net   | MemStream Deserialize  |        5758 |   76   0    0 |             |
|protobuf-net   | NetTest                |        6622 |  560   0    0 |             |

## 100 U8Message x 100000 (direct) 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         473 |    0   0    0 |         100 |
|NetSerializer  | MemStream Deserialize  |        1307 |   76   0    0 |             |
|NetSerializer  | NetTest                |        1391 |   76   0    0 |             |

## 100 S16Message x 100000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         725 |    0   0    0 |         341 |
|NetSerializer  | MemStream Deserialize  |        1261 |   76   0    0 |             |
|NetSerializer  | NetTest                |        1472 |   76   0    0 |             |
|protobuf-net   | MemStream Serialize    |        3528 |  483   0    0 |         844 |
|protobuf-net   | MemStream Deserialize  |        5934 |   76   0    0 |             |
|protobuf-net   | NetTest                |        7005 |  560   0    0 |             |

## 100 S32Message x 100000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         802 |    0   0    0 |         461 |
|NetSerializer  | MemStream Deserialize  |        1316 |   76   0    0 |             |
|NetSerializer  | NetTest                |        1606 |   76   0    0 |             |
|protobuf-net   | MemStream Serialize    |        3615 |  483   0    0 |         828 |
|protobuf-net   | MemStream Deserialize  |        6073 |   76   0    0 |             |
|protobuf-net   | NetTest                |        7144 |  560   0    0 |             |

## 100 S64Message x 100000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         880 |    0   0    0 |         542 |
|NetSerializer  | MemStream Deserialize  |        1410 |   76   0    0 |             |
|NetSerializer  | NetTest                |        1694 |   76   0    0 |             |
|protobuf-net   | MemStream Serialize    |        3717 |  483   0    0 |         809 |
|protobuf-net   | MemStream Deserialize  |        6234 |   76   0    0 |             |
|protobuf-net   | NetTest                |        7290 |  560   0    0 |             |

## 100 DecimalMessage x 50000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         818 |   63   0    0 |        1360 |
|NetSerializer  | MemStream Deserialize  |        1019 |   50   0    0 |             |
|NetSerializer  | NetTest                |        1373 |  114   0    0 |             |
|protobuf-net   | MemStream Serialize    |        2812 |  305   0    0 |        2022 |
|protobuf-net   | MemStream Deserialize  |        4227 |   50   0    0 |             |
|protobuf-net   | NetTest                |        4958 |  356   0    0 |             |

## 100 NullableDecimalMessage x 100000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         667 |    3   0    0 |         238 |
|NetSerializer  | MemStream Deserialize  |        1286 |  127   0    0 |             |
|NetSerializer  | NetTest                |        1426 |  131   0    0 |             |
|protobuf-net   | MemStream Serialize    |        4307 |  487   0    0 |         353 |
|protobuf-net   | MemStream Deserialize  |        6646 |  127   0    0 |             |
|protobuf-net   | NetTest                |        7587 |  615   0    0 |             |

## 100 PrimitivesMessage x 10000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         754 |   12   0    0 |        5286 |
|NetSerializer  | MemStream Deserialize  |         753 |   38   0    0 |             |
|NetSerializer  | NetTest                |        1007 |   51   0    0 |             |
|protobuf-net   | MemStream Serialize    |         777 |   48   0    0 |        7290 |
|protobuf-net   | MemStream Deserialize  |        1106 |   25   0    0 |             |
|protobuf-net   | NetTest                |        1405 |   74   0    0 |             |

## 10 DictionaryMessage x 1000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |        1438 |   37   0    0 |       86187 |
|NetSerializer  | MemStream Deserialize  |        1966 |  109  54    0 |             |
|NetSerializer  | NetTest                |        2454 |  135  67    0 |             |
|protobuf-net   | MemStream Serialize    |        2088 |  206   0    0 |      142035 |
|protobuf-net   | MemStream Deserialize  |        3936 |  233 116    0 |             |
|protobuf-net   | NetTest                |        4753 |  433 216    0 |             |

## 100 ComplexMessage x 10000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         518 |    0   0    0 |        2838 |
|NetSerializer  | MemStream Deserialize  |         770 |   50   0    0 |             |
|NetSerializer  | NetTest                |         930 |   50   0    0 |             |
|protobuf-net   | MemStream Serialize    |        1068 |   48   0    0 |        5087 |
|protobuf-net   | MemStream Deserialize  |        1979 |   50   0    0 |             |
|protobuf-net   | NetTest                |        2233 |   99   0    0 |             |

## 100 StringMessage x 20000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         468 |    0   0    0 |        4886 |
|NetSerializer  | MemStream Deserialize  |         646 |   91   0    0 |             |
|NetSerializer  | NetTest                |         926 |   91   0    0 |             |
|protobuf-net   | MemStream Serialize    |        1127 |   96   0    0 |        5085 |
|protobuf-net   | MemStream Deserialize  |        4352 |   91   0    0 |             |
|protobuf-net   | NetTest                |        2658 |  188   0    0 |             |

## 100 StructMessage x 20000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         587 |    0   0    0 |        2455 |
|NetSerializer  | MemStream Deserialize  |         710 |   58   0    0 |             |
|NetSerializer  | NetTest                |         937 |   58   0    0 |             |
|protobuf-net   | MemStream Serialize    |        1538 |  137   0    0 |        3622 |
|protobuf-net   | MemStream Deserialize  |        5001 |  140   0    0 |             |
|protobuf-net   | NetTest                |        3176 |  278   0    0 |             |

## 100 BoxedPrimitivesMessage x 20000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         938 |    0   0    0 |        1723 |
|NetSerializer  | MemStream Deserialize  |         783 |  111   0    0 |             |
|NetSerializer  | NetTest                |        1086 |  111   0    0 |             |

## 10000 ByteArrayMessage x 1 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         602 |    1   1    1 |   498085311 |
|NetSerializer  | MemStream Deserialize  |         294 |   58  30    1 |             |
|NetSerializer  | NetTest                |        1021 |   57  27    0 |             |
|protobuf-net   | MemStream Serialize    |        1151 |  173   6    3 |   498151945 |
|protobuf-net   | MemStream Deserialize  |         394 |   58  29    1 |             |
|protobuf-net   | NetTest                |        1675 |  172  40    2 |             |

## 1000 IntArrayMessage x 1 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |        1690 |    0   0    0 |   177278871 |
|NetSerializer  | MemStream Deserialize  |        1215 |    2   1    0 |             |
|NetSerializer  | NetTest                |        1961 |    2   1    0 |             |
|protobuf-net   | MemStream Serialize    |        1985 |   39   2    1 |   283510795 |
|protobuf-net   | MemStream Deserialize  |        1776 |   24   3    0 |             |
|protobuf-net   | NetTest                |        2439 |   61   5    2 |             |

## 10 TriDimArrayCustomSerializersMessage x 100 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |        1432 |    0   0    0 |     1601277 |
|NetSerializer  | MemStream Deserialize  |        1174 |   33  31   29 |             |
|NetSerializer  | NetTest                |        1888 |   47  44   43 |             |
