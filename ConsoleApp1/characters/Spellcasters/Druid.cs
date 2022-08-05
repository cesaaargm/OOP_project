using System;
using System.Collections.Generic;
using System.Text;
using MagicMonsters.Equipment.Armour.Leather;
using MagicMonsters.Equipment;

namespace MagicMonsters.characters.Spellcasters
{
    class Druid
    {
        // Fields 

        private int abilityPoints;
        private int healthPoints;
        private int level;
        private int name;

        private string faction;

        private LightLeatherVest bodyArmour;
        private Staff weapon;

        // Constructors
        public Druid()
        {
            throw new NotImplementedException();
        }

        public Druid(int abilityPoints, int healthPoints, int level, int name, string faction, LightLeatherVest bodyArmour, Staff weapon)
        {
            this.abilityPoints = abilityPoints;
            this.healthPoints = healthPoints;
            this.level = level;
            this.name = name;
            this.faction = faction;
            this.bodyArmour = bodyArmour;
            this.weapon = weapon;
        }

        // Methods

        public void Moonfire()
        {
            throw new NotImplementedException();
        }
        public void Starburst()
        {
            throw new NotImplementedException();
        }
        public void OneWithTheNature()
        {
            throw new NotImplementedException();
        }
    }
}
