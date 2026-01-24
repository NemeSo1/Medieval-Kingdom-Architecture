using System;

namespace mini;

class Merchant : Citizen, ITaxPayer, IHideable
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
    public void Hide(string enemy)
    {
        Console.WriteLine($"Торговець {Name} кидає справи і біжить в замок від {enemy}!");
    }
}
