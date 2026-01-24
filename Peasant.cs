using System;

namespace mini;

class Peasant : Citizen, ITaxPayer, IHideable
{
    public ResourceType Specialization { get; set; }
    public Peasant(string name, int age, ResourceType specialization) : base(name, age)
    {
        this.Specialization = specialization;
    }


    public override void Work()
    {
        System.Console.WriteLine($"Селянин {Name} добуває {Specialization}");
    }

    public int PayTax()
    {
        return 5;
    }

    public void Hide(string enemy)
    {
        Console.WriteLine($"Селянин {Name} кидає справи і біжить в замок від {enemy}!");
    }

}