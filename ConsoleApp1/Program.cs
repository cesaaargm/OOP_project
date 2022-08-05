using System;
using ConsoleApp1.characters.warriors;

public class EntryType
{
    static void Main()
    {
        System.Console.WriteLine("Hello World!");
        Warrior goodWarrior = new Warrior(180, 90,"JOhnny");
        Warrior badWarrior = new Warrior(190, 80,"McFly");

        
        //Console.WriteLine(goodWarrior.Height);
        //Console.WriteLine(goodWarrior.Weigth);

        goodWarrior.Greetings(badWarrior);  
        badWarrior.Greetings(goodWarrior);  

    }
}


