using System;
using System.Collections.Generic;
using System.Text;

class Potion : Item
{
    private int HealAmount;

    public Potion(string name, int price, int healAmoount) : base(name, price)
    {
        HealAmount = healAmoount;
    }
    public override string ToString()
    {
        return $"Potion {{ Name = {Name}, Price = {Price}, HealAmount = {HealAmount} }} [Potion]";
    }
}
