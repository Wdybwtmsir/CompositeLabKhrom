using System;
using System.Collections.Generic;
interface IUnit
{
    void Attack();
}
class Warrior : IUnit
{
    public void Attack()
    {
        Console.WriteLine("Воин атакует мечом!");
    }
}
class Mage : IUnit
{
    public void Attack()
    {
        Console.WriteLine("Маг атакует заклинанием!");
    }
}
class Archer : IUnit
{
    public void Attack()
    {
        Console.WriteLine("Лучник атакует стрелами!");
    }
}
class Squad : IUnit
{
    private string name;
    private List<IUnit> units = new List<IUnit>();

    public Squad(string name)
    {
        this.name = name;
    }
    public void Add(IUnit unit)
    {
        units.Add(unit);
    }
    public void Attack()
    {
        Console.WriteLine($"\n--- {name} атакует! ---");
        foreach (IUnit unit in units)
        {
            unit.Attack();
        }
    }
}

class Program
{
    static void Main()
    {
        IUnit warrior1 = new Warrior();
        IUnit mage1 = new Mage();
        IUnit archer1 = new Archer();

        IUnit warrior2 = new Warrior();
        IUnit mage2 = new Mage();
        IUnit archer2 = new Archer();
        Squad subSquad = new Squad("Второй отряд (Разведчики)");
        subSquad.Add(warrior2);
        subSquad.Add(mage2);
        subSquad.Add(archer2);
        Squad mainSquad = new Squad("Главный отряд (Армия)");
        mainSquad.Add(warrior1);
        mainSquad.Add(mage1);
        mainSquad.Add(archer1);
        mainSquad.Add(subSquad);
        mainSquad.Attack();
    }
}