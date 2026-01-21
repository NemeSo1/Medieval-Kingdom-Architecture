using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;

namespace mini;

class Program
{
    static void Main()
    {
        Soldier soldier1 = new Soldier("Андрій", 13, 55);
        Soldier soldier2 = new Soldier("Василь", 15, 44);
        Soldier soldier3 = new Soldier("Роман", 15, 33);
        Soldier soldier4 = new Soldier("Адам", 16, 322);
        Soldier soldier5 = new Soldier("Танджиро", 18, 133);

        Peasant peasant1 = new Peasant("Іван", 45, ResourceType.Stone);
        Peasant peasant2 = new Peasant("Олег", 35, ResourceType.Food);
        Peasant peasant3 = new Peasant("Марко", 25, ResourceType.Stone);
        Peasant peasant4 = new Peasant("Остап", 35, ResourceType.Stone);
        Peasant peasant5 = new Peasant("Ivan", 5, ResourceType.Wood);

        Merchant merchant1 = new Merchant("Богатий1", 52, 444);
        Merchant merchant2 = new Merchant("Богатий2", 76, 520);
        Merchant merchant3 = new Merchant("Богатий3", 99, 4424);
        Merchant merchant4 = new Merchant("Богатий4", 55, 33);
        Merchant merchant5 = new Merchant("Богатий5", 66, 5110);

        //first
        City city = new City();
        city.AddCitizen(soldier1);
        city.AddCitizen(soldier2);
        city.AddCitizen(soldier3);
        city.AddCitizen(soldier4);
        city.AddCitizen(soldier5);

        city.AddCitizen(peasant1);
        city.AddCitizen(peasant2);
        city.AddCitizen(peasant3);
        city.AddCitizen(peasant4);
        city.AddCitizen(peasant5);

        city.AddCitizen(merchant1);
        city.AddCitizen(merchant2);
        city.AddCitizen(merchant3);
        city.AddCitizen(merchant4);
        city.AddCitizen(merchant5);

        System.Console.WriteLine("Кількість людей в кожній групі");
        var group = city.Population
        .GroupBy(x => x.GetType().Name);
        foreach (var item in group)
        {
            System.Console.WriteLine($"{item.Key}: {item.Count()}");
        }
        System.Console.WriteLine("-------------------------------");

        //second
        city.ArmyBarracks.AddRecruit(soldier1);
        city.ArmyBarracks.AddRecruit(soldier2);
        city.ArmyBarracks.AddRecruit(soldier3);
        city.ArmyBarracks.AddRecruit(soldier4);
        city.ArmyBarracks.AddRecruit(soldier5);
        var strongs = city.ArmyBarracks.line
        .OrderByDescending(x => x.Strenght)
        .Take(3);
        System.Console.WriteLine("3 найсильніші солдати!");
        foreach (var el in strongs)
        {
            System.Console.WriteLine($"Ім'я: {el.Name}, Вік: {el.Age}, Сила: {el.Strenght}");
        }
        System.Console.WriteLine("-------------------------------");


        //third
        var darmoide = city.Population
        .Where(x => x is not ITaxPayer ITaxPayer)
        .Select(man => man.Name);
        System.Console.WriteLine("Не платять податок!");
        foreach (var el in darmoide)
        {

            System.Console.WriteLine(el);
        }
        System.Console.WriteLine("-------------------------------");

        //four 
        System.Console.WriteLine("Загальна сума податку");
        var sum = city.Population
        .OfType<ITaxPayer>()
        .Sum(x => x.PayTax());
        System.Console.WriteLine(sum);
        System.Console.WriteLine("-------------------------------");

        //five(final)
        System.Console.WriteLine("Імена людей, які страше 30 і добувають камінь");
        var stone = city.Population
        .OfType<Peasant>()
        .Where(x => x.Age > 30 && x.Specialization == ResourceType.Stone)
        .Select(x => x.Name);

        foreach( var el in stone)
        {
            System.Console.WriteLine(el);
        }
        System.Console.WriteLine("-------------------------------");

    }

}