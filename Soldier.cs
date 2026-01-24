using System;

namespace mini;


class Soldier : Citizen
{
    public int Strenght { get; set; }
    public Soldier(string name, int age, int strenght) : base(name, age)
    {
        this.Strenght = strenght;
    }

    public override void Work()
    {
        System.Console.WriteLine($"Солдат {Name} партулює місто");
    }
}