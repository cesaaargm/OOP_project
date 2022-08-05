using System;
using MagicMonsters.Equipment.Armour.Heavy;
using MagicMonsters.Equipment.Weapon.Sharp;

namespace MagicMonsters.characters.Melee
{
    class Warrior
    {
        private int abilityPoints;
        private int healthPoints;
        private int level;
        private int name;

        private string faction;

        private ChainArmour bodyArmour;
        private Axe weapon;

        public Warrior()
        {
            throw new NotImplementedException();
        }

        public Warrior(int abilityPoints, int healthPoints, int level, int name, string faction, ChainArmour bodyArmour, Axe weapon)
        {
            this.abilityPoints = abilityPoints;
            this.healthPoints = healthPoints;
            this.level = level;
            this.name = name;
            this.faction = faction;
            this.bodyArmour = bodyArmour;
            this.weapon = weapon;
        }

        public void Strike()
        {
            throw new NotImplementedException();
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
        public void SkinHarden()
        {
            throw new NotImplementedException();
        }
    }
}