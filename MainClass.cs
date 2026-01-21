using System;

namespace mini;

abstract class Citizen
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Citizen(string name, int age)
    {
        this.Name = name;
        this.Age = age; 
    }
    public abstract void Work();
}