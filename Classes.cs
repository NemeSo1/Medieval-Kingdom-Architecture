using System;

namespace mini;

class Peasant : Citizen, ITaxPayer
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

}



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

class Merchant : Citizen, ITaxPayer
{
    public int DailyProfit { get; set; }
    public Merchant(string name, int age, int dailyProfit) : base(name, age)
    {
        this.DailyProfit = dailyProfit;
    }

    public int PayTax()
    {
        return (int)(0.2 * DailyProfit);
    }

    public override void Work()
    {
        System.Console.WriteLine($"Торговець {Name} продав товарів на {DailyProfit}");
    }
}
