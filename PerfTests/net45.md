# NET Framework 4.5
Serializer.Initialize() in 21 ms

## 1000 Object x 1000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |          45 |    0   0    0 |        1000 |
|NetSerializer  | MemStream Deserialize  |          24 |    7   0    0 |             |
|NetSerializer  | NetTest                |          55 |    7   0    0 |             |

## 100 LargeStruct x 30000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         566 |   45   0    0 |        1859 |
|NetSerializer  | MemStream Deserialize  |         436 |   45   0    0 |             |
|NetSerializer  | NetTest                |         723 |   91   0    0 |             |
|protobuf-net   | MemStream Serialize    |        1019 |  190   0    0 |        2151 |
|protobuf-net   | MemStream Deserialize  |        1603 |   91   0    0 |             |
|protobuf-net   | NetTest                |        2179 |  283   0    0 |             |

## 100 LargeStruct x 30000 (direct) 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         513 |    0   0    0 |        1759 |
|NetSerializer  | MemStream Deserialize  |         423 |    0   0    0 |             |
|NetSerializer  | NetTest                |         690 |    0   0    0 |             |

## 100 Guid x 50000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         855 |   50   0    0 |        1969 |
|NetSerializer  | MemStream Deserialize  |         538 |   50   0    0 |             |
|NetSerializer  | NetTest                |        1122 |  102   0    0 |             |
|protobuf-net   | MemStream Serialize    |        4899 |  445   0    0 |        2100 |
|protobuf-net   | MemStream Deserialize  |        4831 |  139   0    0 |             |
|protobuf-net   | NetTest                |        6306 |  588   0    0 |             |

## 100 Guid x 50000 (direct) 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         738 |    0   0    0 |        1874 |
|NetSerializer  | MemStream Deserialize  |         586 |    0   0    0 |             |
|NetSerializer  | NetTest                |         921 |    0   0    0 |             |

## 100 Int32 x 100000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         790 |   76   0    0 |         461 |
|NetSerializer  | MemStream Deserialize  |         453 |   76   0    0 |             |
|NetSerializer  | NetTest                |         935 |  153   0    0 |             |
|protobuf-net   | MemStream Serialize    |        9251 |  763   0    0 |         648 |
|protobuf-net   | MemStream Deserialize  |        9448 |  279   6    0 |             |
|protobuf-net   | NetTest                |       11196 | 1049   1    0 |             |

## 100 Int32 x 100000 (direct) 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         610 |    0   0    0 |         361 |
|NetSerializer  | MemStream Deserialize  |         570 |    0   0    0 |             |
|NetSerializer  | NetTest                |         688 |    0   0    0 |             |

## 100 U8Message x 100000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         568 |    0   0    0 |         200 |
|NetSerializer  | MemStream Deserialize  |        1126 |   76   0    0 |             |
|NetSerializer  | NetTest                |        1294 |   76   0    0 |             |
|protobuf-net   | MemStream Serialize    |        3314 |  483   0    0 |         527 |
|protobuf-net   | MemStream Deserialize  |        5797 |   76   0    0 |             |
|protobuf-net   | NetTest                |        6855 |  560   0    0 |             |

## 100 U8Message x 100000 (direct) 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         426 |    0   0    0 |         100 |
|NetSerializer  | MemStream Deserialize  |        1245 |   76   0    0 |             |
|NetSerializer  | NetTest                |        1333 |   76   0    0 |             |

## 100 S16Message x 100000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         663 |    0   0    0 |         341 |
|NetSerializer  | MemStream Deserialize  |        1286 |   76   0    0 |             |
|NetSerializer  | NetTest                |        1473 |   76   0    0 |             |
|protobuf-net   | MemStream Serialize    |        3632 |  483   0    0 |         844 |
|protobuf-net   | MemStream Deserialize  |        6096 |   76   0    0 |             |
|protobuf-net   | NetTest                |        7326 |  560   0    0 |             |

## 100 S32Message x 100000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         747 |    0   0    0 |         461 |
|NetSerializer  | MemStream Deserialize  |        1339 |   76   0    0 |             |
|NetSerializer  | NetTest                |        1571 |   76   0    0 |             |
|protobuf-net   | MemStream Serialize    |        3854 |  483   0    0 |         828 |
|protobuf-net   | MemStream Deserialize  |        6305 |   76   0    0 |             |
|protobuf-net   | NetTest                |        7558 |  560   0    0 |             |

## 100 S64Message x 100000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         820 |    0   0    0 |         542 |
|NetSerializer  | MemStream Deserialize  |        1431 |   76   0    0 |             |
|NetSerializer  | NetTest                |        1693 |   76   0    0 |             |
|protobuf-net   | MemStream Serialize    |        4001 |  483   0    0 |         809 |
|protobuf-net   | MemStream Deserialize  |        6535 |   76   0    0 |             |
|protobuf-net   | NetTest                |        7682 |  560   0    0 |             |

## 100 DecimalMessage x 50000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         720 |   63   0    0 |        1360 |
|NetSerializer  | MemStream Deserialize  |        1042 |   50   0    0 |             |
|NetSerializer  | NetTest                |        1388 |  114   0    0 |             |
|protobuf-net   | MemStream Serialize    |        3083 |  305   0    0 |        2022 |
|protobuf-net   | MemStream Deserialize  |        4453 |   50   0    0 |             |
|protobuf-net   | NetTest                |        5131 |  356   0    0 |             |

## 100 NullableDecimalMessage x 100000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         608 |    3   0    0 |         238 |
|NetSerializer  | MemStream Deserialize  |        1279 |  127   0    0 |             |
|NetSerializer  | NetTest                |        1432 |  131   0    0 |             |
|protobuf-net   | MemStream Serialize    |        4913 |  487   0    0 |         353 |
|protobuf-net   | MemStream Deserialize  |        7164 |  127   0    0 |             |
|protobuf-net   | NetTest                |        8282 |  615   0    0 |             |

## 100 PrimitivesMessage x 10000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         752 |   12   0    0 |        5286 |
|NetSerializer  | MemStream Deserialize  |         847 |   38   0    0 |             |
|NetSerializer  | NetTest                |        1137 |   51   0    0 |             |
|protobuf-net   | MemStream Serialize    |         810 |   48   0    0 |        7290 |
|protobuf-net   | MemStream Deserialize  |        1158 |   25   0    0 |             |
|protobuf-net   | NetTest                |        1524 |   74   0    0 |             |

## 10 DictionaryMessage x 1000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |        1416 |   37   0    0 |       86187 |
|NetSerializer  | MemStream Deserialize  |        1954 |  109  54    0 |             |
|NetSerializer  | NetTest                |        2508 |  133  66    0 |             |
|protobuf-net   | MemStream Serialize    |        2077 |  206   0    0 |      142035 |
|protobuf-net   | MemStream Deserialize  |        3908 |  233 116    0 |             |
|protobuf-net   | NetTest                |        4682 |  419 209    0 |             |

## 100 ComplexMessage x 10000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         460 |    0   0    0 |        2838 |
|NetSerializer  | MemStream Deserialize  |         759 |   50   0    0 |             |
|NetSerializer  | NetTest                |         902 |   50   0    0 |             |
|protobuf-net   | MemStream Serialize    |        1049 |   48   0    0 |        5087 |
|protobuf-net   | MemStream Deserialize  |        1970 |   50   0    0 |             |
|protobuf-net   | NetTest                |        2217 |   99   0    0 |             |

## 100 StringMessage x 20000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         458 |    0   0    0 |        4886 |
|NetSerializer  | MemStream Deserialize  |         622 |   91   0    0 |             |
|NetSerializer  | NetTest                |         869 |   91   0    0 |             |
|protobuf-net   | MemStream Serialize    |        1172 |   96   0    0 |        5085 |
|protobuf-net   | MemStream Deserialize  |        4481 |   91   0    0 |             |
|protobuf-net   | NetTest                |        2739 |  188   0    0 |             |

## 100 StructMessage x 20000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         558 |    0   0    0 |        2455 |
|NetSerializer  | MemStream Deserialize  |         683 |   58   0    0 |             |
|NetSerializer  | NetTest                |         902 |   58   0    0 |             |
|protobuf-net   | MemStream Serialize    |        1588 |  137   0    0 |        3622 |
|protobuf-net   | MemStream Deserialize  |        4889 |  140   0    0 |             |
|protobuf-net   | NetTest                |        3058 |  278   0    0 |             |

## 100 BoxedPrimitivesMessage x 20000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         859 |    0   0    0 |        1723 |
|NetSerializer  | MemStream Deserialize  |         755 |  111   0    0 |             |
|NetSerializer  | NetTest                |         979 |  111   0    0 |             |

## 10000 ByteArrayMessage x 1 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         550 |    1   1    1 |   498085311 |
|NetSerializer  | MemStream Deserialize  |         269 |   58  30    1 |             |
|NetSerializer  | NetTest                |         942 |   57  28    0 |             |
|protobuf-net   | MemStream Serialize    |        1052 |  173   6    3 |   498151945 |
|protobuf-net   | MemStream Deserialize  |         361 |   58  29    1 |             |
|protobuf-net   | NetTest                |        1559 |  170  40    2 |             |

## 1000 IntArrayMessage x 1 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |        1583 |    0   0    0 |   177278871 |
|NetSerializer  | MemStream Deserialize  |        1178 |    2   1    0 |             |
|NetSerializer  | NetTest                |        1622 |    1   0    0 |             |
|protobuf-net   | MemStream Serialize    |        1890 |   39   2    1 |   283510795 |
|protobuf-net   | MemStream Deserialize  |        1705 |   24   3    0 |             |
|protobuf-net   | NetTest                |        2243 |   59   5    2 |             |

## 10 TriDimArrayCustomSerializersMessage x 100 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |        1287 |    0   0    0 |     1601277 |
|NetSerializer  | MemStream Deserialize  |        1173 |   33  31   29 |             |
|NetSerializer  | NetTest                |        1829 |   47  44   43 |             |
