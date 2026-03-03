using System;
using System.Collections.Generic;
using System.Text;

class Item
{
    protected string Name;
    protected int Price;
    public Item(string name, int price)
    {
        Name = name;
        Price = price;
    }
    public override string ToString()
    {
        return $"{{ Name = {Name}, Price = {Price}}}";
    }
}
