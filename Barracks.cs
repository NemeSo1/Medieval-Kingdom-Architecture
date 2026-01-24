using System;
using System.Collections.Generic;

namespace mini;

class Barracks<T> where T : Soldier
{
    public Queue<T> line = new Queue<T>();
    public void AddRecruit(T Soldier)
    {
        line.Enqueue(Soldier);
    
    }

    public Soldier TrainNext()
    {
        Soldier soldier = line.Dequeue();
        soldier.Strenght += 10;
        return soldier;
    }

    public void DeployTroops(string enemy)
    {
        System.Console.WriteLine("На захист виводиться вся казарма!");
        foreach(Soldier el in line)
        {
            System.Console.WriteLine($"Ім'я: {el.Name}, Вік: {el.Age}, Сила: {el.Strenght}");
        }
    }
}