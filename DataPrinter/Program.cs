using System;

object[] data = { 42, 3.14, "Hello", true, 100, "World", false, 2.718 };
Data d = new Data();
d.PrintAll(data);
Console.WriteLine("[타입별 통계]");
Console.WriteLine($"정수: {d.icount}개");
Console.WriteLine($"실수: {d.dcount}개");
Console.WriteLine($"문자열: {d.scount}개");
Console.WriteLine($"논리값: {d.bcount}개");
