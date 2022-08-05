using System;
using MagicMonsters.characters.Melee;
using MagicMonsters.Equipment.Armour.Heavy;
using MagicMonsters.Equipment.Weapon.Sharp;
public class EntryType
{
    static void Main()
    {
        
        System.Console.WriteLine("Hello World!");
        Warrior goodWarrior = new Warrior(1000, 100, 1, 0, "goodWarrior", new ChainArmour(), new Axe());
        Warrior badWarrior = new Warrior(5000, 100, 1, 0, "badWarrior", new ChainArmour(), new Axe());


        //Console.WriteLine(goodWarrior.Height);
        //Console.WriteLine(goodWarrior.Weigth);

        //goodWarrior.Greetings(badWarrior);  
        //badWarrior.Greetings(goodWarrior);  

    }
}


