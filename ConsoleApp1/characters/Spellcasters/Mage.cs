using System;
using System.Collections.Generic;
using System.Text;
using MagicMonsters.Equipment.Armour.Light;
using MagicMonsters.Equipment;

namespace MagicMonsters.characters.Spellcasters
{
    class Mage
    {
        // Fields 

        private int abilityPoints;
        private int healthPoints;
        private int level;
        private int name;

        private string faction;

        private ClothRobe bodyArmour;
        private Staff weapon;

        // Constructors

        public Mage()
        {
            throw new NotImplementedException();
        }

        public Mage(int abilityPoints, int healthPoints, int level, int name, string faction, ClothRobe bodyArmour, Staff weapon)
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

        public void ArcaneWrath()
        {
            throw new NotImplementedException();
        }
        public void Firewall()
        {
            throw new NotImplementedException();
        }
        public void Meditation()
        {
            throw new NotImplementedException();
        }
    }
}
