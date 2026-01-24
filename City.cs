using System;
using System.Collections.Generic;
using System.Linq;

namespace mini;

class City
{
    public event Action<string> OnKingdomAttacked;
    public Dictionary<ResourceType, int> Resourse = new Dictionary<ResourceType, int>();
    public List<Citizen> Population = new List<Citizen>();
    public Barracks<Soldier> ArmyBarracks = new Barracks<Soldier>();



    public void AddCitizen(Citizen citizen)
    {
        Population.Add(citizen);

        if (citizen is IHideable hideablePerson)
        {
            this.OnKingdomAttacked += hideablePerson.Hide;
        }
    }

    public void CollectTaxes()
    {
        foreach (var el in Population)
        {
            if (el is ITaxPayer taxPayer)
            {
                int x = taxPayer.PayTax();
                Resourse[ResourceType.Gold] += x;
            }
        }

    }

    public void CityLife()
    {
        foreach (var el in Population)
        {
            el.Work();
        }
    }

    public void Alarm(string enemy)
    {
        System.Console.WriteLine($"Тривога! На нас напав ворог {enemy}");
        OnKingdomAttacked?.Invoke(enemy);
    }

}
