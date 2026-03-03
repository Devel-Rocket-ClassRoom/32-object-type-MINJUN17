using System;
using System.Collections.Generic;
using System.Text;

class Data
{
    public int icount = 0;
    public int dcount = 0;
    public int scount = 0;
    public int bcount = 0;
    public void PrintData(object data)
    {
        if(data.GetType().Name == "Int32")
        {
            Console.WriteLine($"정수: {data}");
            icount++;
        }
        else if(data.GetType().Name == "Double")
        {
            Console.WriteLine($"실수: {data}");
            dcount++;
        }
        else if (data.GetType().Name == "String")
        {
            Console.WriteLine($"문자열: {data}");
            scount++;
        }
        else if (data.GetType().Name == "Boolean")
        {
            Console.WriteLine($"논리값: {data}");
            bcount++;
        }
        else
        {
            Console.WriteLine($"알 수 없는 타입: {data.GetType().Name} - {data}");
        }
    }
    public void PrintAll(object[] data)
    {
        for(int i = 0; i < data.Length; i++)
        {
            PrintData(data[i]);
        }
    }

}
