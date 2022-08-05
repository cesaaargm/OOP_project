using System;
using MagicMonsters.Equipment.Armour.Leather;
using MagicMonsters.Equipment.Weapon.Sharp;

namespace MagicMonsters.characters.Melee
{
    class Assassin
    {
        private int abilityPoints;
        private int healthPoints;
        private int level;
        private int name;

        private string faction;

        private LightLeatherVest bodyArmour;
        private Sword weapon;

        public Assassin()
        {
            throw new NotImplementedException();
        }

        public Assassin(int abilityPoints, string faction, int healthPoints, int level, int name, LightLeatherVest bodyArmour, Sword weapon)
        {
            this.abilityPoints = abilityPoints;
            this.faction = faction;
            this.healthPoints = healthPoints;
            this.level = level;
            this.name = name;
            this.bodyArmour = bodyArmour;
            this.weapon = weapon;
        }

        // Methods

        public void Raze()
        {
            throw new NotImplementedException();
        }
        public void BleedToDeath()
        {
            throw new NotImplementedException();
        }
        public void Survival()
        {
            throw new NotImplementedException();
        }
    }
}
