# NET Framework 3.5
Serializer.Initialize() in 43 ms

## 1000 Object x 1000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |          70 |    0   0    0 |        1000 |
|NetSerializer  | MemStream Deserialize  |          29 |    7   0    0 |             |
|NetSerializer  | NetTest                |          80 |    7   0    0 |             |

## 100 LargeStruct x 30000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         575 |   45   0    0 |        1859 |
|NetSerializer  | MemStream Deserialize  |         458 |   45   0    0 |             |
|NetSerializer  | NetTest                |         826 |   91   0    0 |             |
|protobuf-net   | MemStream Serialize    |        1077 |  190   0    0 |        2151 |
|protobuf-net   | MemStream Deserialize  |       10787 |   91   1    0 |             |
|protobuf-net   | NetTest                |       11167 |  282   2    0 |             |

## 100 LargeStruct x 30000 (direct) 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         490 |    0   0    0 |        1759 |
|NetSerializer  | MemStream Deserialize  |         542 |    0   0    0 |             |
|NetSerializer  | NetTest                |         683 |    0   0    0 |             |

## 100 Guid x 50000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         895 |   50   0    0 |        1969 |
|NetSerializer  | MemStream Deserialize  |         554 |   50   0    0 |             |
|NetSerializer  | NetTest                |        1331 |  102   0    0 |             |
|protobuf-net   | MemStream Serialize    |        5596 |  458   0    0 |        2100 |
|protobuf-net   | MemStream Deserialize  |        6011 |  152   0    0 |             |
|protobuf-net   | NetTest                |        6625 |  612   1    0 |             |

## 100 Guid x 50000 (direct) 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         949 |    0   0    0 |        1871 |
|NetSerializer  | MemStream Deserialize  |         747 |    0   0    0 |             |
|NetSerializer  | NetTest                |        1134 |    0   0    0 |             |

## 100 Int32 x 100000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |        1029 |   76   0    0 |         461 |
|NetSerializer  | MemStream Deserialize  |         490 |   76   0    0 |             |
|NetSerializer  | NetTest                |        1265 |  153   0    0 |             |
|protobuf-net   | MemStream Serialize    |       11449 |  788   1    0 |         648 |
|protobuf-net   | MemStream Deserialize  |       11929 |  305   6    0 |             |
|protobuf-net   | NetTest                |       13166 | 1097   2    0 |             |

## 100 Int32 x 100000 (direct) 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         813 |    0   0    0 |         361 |
|NetSerializer  | MemStream Deserialize  |         837 |    0   0    0 |             |
|NetSerializer  | NetTest                |         947 |    0   0    0 |             |

## 100 U8Message x 100000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         768 |    0   0    0 |         200 |
|NetSerializer  | MemStream Deserialize  |        1063 |   76   0    0 |             |
|NetSerializer  | NetTest                |        1194 |   76   0    0 |             |
|protobuf-net   | MemStream Serialize    |        3468 |  483   0    0 |         527 |
|protobuf-net   | MemStream Deserialize  |        7753 |   76   0    0 |             |
|protobuf-net   | NetTest                |        8284 |  560   0    0 |             |

## 100 U8Message x 100000 (direct) 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         705 |    0   0    0 |         100 |
|NetSerializer  | MemStream Deserialize  |        1490 |   76   0    0 |             |
|NetSerializer  | NetTest                |        1547 |   76   0    0 |             |

## 100 S16Message x 100000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         887 |    0   0    0 |         341 |
|NetSerializer  | MemStream Deserialize  |        1202 |   76   0    0 |             |
|NetSerializer  | NetTest                |        1362 |   76   0    0 |             |
|protobuf-net   | MemStream Serialize    |        3845 |  483   0    0 |         844 |
|protobuf-net   | MemStream Deserialize  |        7979 |   76   0    0 |             |
|protobuf-net   | NetTest                |        8582 |  559   1    0 |             |

## 100 S32Message x 100000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         983 |    0   0    0 |         461 |
|NetSerializer  | MemStream Deserialize  |        1261 |   76   0    0 |             |
|NetSerializer  | NetTest                |        1471 |   76   0    0 |             |
|protobuf-net   | MemStream Serialize    |        3917 |  483   0    0 |         828 |
|protobuf-net   | MemStream Deserialize  |        8068 |   76   0    0 |             |
|protobuf-net   | NetTest                |        9125 |  559   1    0 |             |

## 100 S64Message x 100000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         997 |    0   0    0 |         542 |
|NetSerializer  | MemStream Deserialize  |        1353 |   76   0    0 |             |
|NetSerializer  | NetTest                |        1600 |   76   0    0 |             |
|protobuf-net   | MemStream Serialize    |        4032 |  483   0    0 |         809 |
|protobuf-net   | MemStream Deserialize  |        8348 |   76   0    0 |             |
|protobuf-net   | NetTest                |        9593 |  559   1    0 |             |

## 100 DecimalMessage x 50000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         820 |   63   0    0 |        1360 |
|NetSerializer  | MemStream Deserialize  |        1053 |   50   0    0 |             |
|NetSerializer  | NetTest                |        1349 |  113   1    0 |             |
|protobuf-net   | MemStream Serialize    |        3434 |  305   0    0 |        2022 |
|protobuf-net   | MemStream Deserialize  |        5267 |   50   0    0 |             |
|protobuf-net   | NetTest                |        6233 |  355   1    0 |             |

## 100 NullableDecimalMessage x 100000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         890 |    3   0    0 |         238 |
|NetSerializer  | MemStream Deserialize  |        1519 |  127   0    0 |             |
|NetSerializer  | NetTest                |        1656 |  130   1    0 |             |
|protobuf-net   | MemStream Serialize    |        4636 |  487   0    0 |         353 |
|protobuf-net   | MemStream Deserialize  |        8991 |  127   0    0 |             |
|protobuf-net   | NetTest                |        9829 |  615   0    0 |             |

## 100 PrimitivesMessage x 10000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         506 |    7   0    0 |        5286 |
|NetSerializer  | MemStream Deserialize  |         663 |   33   0    0 |             |
|NetSerializer  | NetTest                |         892 |   39   1    0 |             |
|protobuf-net   | MemStream Serialize    |         851 |   48   0    0 |        7290 |
|protobuf-net   | MemStream Deserialize  |        1396 |   25   0    0 |             |
|protobuf-net   | NetTest                |        1703 |   73   1    0 |             |

## 10 DictionaryMessage x 1000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |        1921 |   37   0    0 |       86187 |
|NetSerializer  | MemStream Deserialize  |        2034 |  109  54    0 |             |
|NetSerializer  | NetTest                |        2468 |  135  67    0 |             |
|protobuf-net   | MemStream Serialize    |        2462 |  206   0    0 |      142035 |
|protobuf-net   | MemStream Deserialize  |        4622 |  383 191    0 |             |
|protobuf-net   | NetTest                |        5518 |  618 309    0 |             |

## 100 ComplexMessage x 10000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         577 |    0   0    0 |        2838 |
|NetSerializer  | MemStream Deserialize  |         753 |   50   0    0 |             |
|NetSerializer  | NetTest                |         884 |   50   0    0 |             |
|protobuf-net   | MemStream Serialize    |        1093 |   48   0    0 |        5087 |
|protobuf-net   | MemStream Deserialize  |        2192 |   50   0    0 |             |
|protobuf-net   | NetTest                |        2428 |   98   1    0 |             |

## 100 StringMessage x 20000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         572 |    0   0    0 |        4886 |
|NetSerializer  | MemStream Deserialize  |         731 |   91   0    0 |             |
|NetSerializer  | NetTest                |        1011 |   91   0    0 |             |
|protobuf-net   | MemStream Serialize    |        1213 |   96   0    0 |        5085 |
|protobuf-net   | MemStream Deserialize  |        6072 |   91   0    0 |             |
|protobuf-net   | NetTest                |        3200 |  187   1    0 |             |

## 100 StructMessage x 20000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         624 |    0   0    0 |        2455 |
|NetSerializer  | MemStream Deserialize  |         824 |   58   0    0 |             |
|NetSerializer  | NetTest                |         987 |   58   0    0 |             |
|protobuf-net   | MemStream Serialize    |        1712 |  137   0    0 |        3622 |
|protobuf-net   | MemStream Deserialize  |        6738 |  140   0    0 |             |
|protobuf-net   | NetTest                |        3770 |  277   1    0 |             |

## 100 BoxedPrimitivesMessage x 20000 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |        1174 |    0   0    0 |        1723 |
|NetSerializer  | MemStream Deserialize  |         763 |  111   0    0 |             |
|NetSerializer  | NetTest                |        1340 |  111   0    0 |             |

## 10000 ByteArrayMessage x 1 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |         499 |    1   1    1 |   498085311 |
|NetSerializer  | MemStream Deserialize  |         277 |   57  28    1 |             |
|NetSerializer  | NetTest                |        1017 |   58  27    1 |             |
|protobuf-net   | MemStream Serialize    |        1066 |  169  10    5 |   498151945 |
|protobuf-net   | MemStream Deserialize  |         409 |   57  28    1 |             |
|protobuf-net   | NetTest                |        1568 |  170  39    2 |             |

## 1000 IntArrayMessage x 1 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |        1361 |    1   1    1 |   177278871 |
|NetSerializer  | MemStream Deserialize  |        1139 |    2   1    1 |             |
|NetSerializer  | NetTest                |        1648 |    3   1    1 |             |
|protobuf-net   | MemStream Serialize    |        1956 |   42   6    3 |   283510795 |
|protobuf-net   | MemStream Deserialize  |        1765 |   25   4    1 |             |
|protobuf-net   | NetTest                |        2307 |   63  10    3 |             |

## 10 TriDimArrayCustomSerializersMessage x 100 
|  Serializer   |          Test          |  time (ms)  |    GC coll.   |   size (B)  |
| --------------| -----------------------| ------------| --------------| ------------|
|NetSerializer  | MemStream Serialize    |        1012 |    0   0    0 |     1601277 |
|NetSerializer  | MemStream Deserialize  |        1261 |   31  31   31 |             |
|NetSerializer  | NetTest                |        1676 |   49  49   49 |             |
