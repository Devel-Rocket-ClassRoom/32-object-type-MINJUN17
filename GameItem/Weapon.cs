using System;
using System.Collections.Generic;
using System.Text;

class Weapon: Item
{
    private int Damage;

    public Weapon(string name, int price, int damage): base(name, price)
    {
        Damage = damage;
    }
    public override string ToString()
    {
        return $"Weapon {{ Name = {Name}, Price = {Price}, Damage = {Damage} }} [Weapon]";
    }
}
