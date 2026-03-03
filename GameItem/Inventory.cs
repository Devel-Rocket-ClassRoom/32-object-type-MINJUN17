using System;
using System.Collections.Generic;
using System.Text;

class Inventory
{
    private object[] obj = new object[10];
    private int objectCount = 0;
    public void AddItem(object item)
    {
        obj[objectCount++] = item;
    }
    public void ShowInventory()
    {
        for(int i = 0; i < objectCount; i++)
        {
            Console.WriteLine($"슬롯 {i+1}: {obj[i].GetType().Name} {obj[i].ToString()}");
        }
    }
}
