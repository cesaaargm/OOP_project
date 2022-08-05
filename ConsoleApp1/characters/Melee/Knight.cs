using System;
using System.Collections.Generic;
using System.Text;
using MagicMonsters.Equipment.Armour.Heavy;
using MagicMonsters.Equipment.Weapon.Blunt;

namespace MagicMonsters.characters.Melee
{
    class Knight
    {

        private int abilityPoints;
        private int healthPoints;
        private int level;
        private int name;

        private string faction;

        private ChainArmour bodyArmour;
        private Hammer weapon;

        public Knight()
        {
            throw new NotImplementedException();
        }

        public Knight(int abilityPoints, int healthPoints, int level, int name, string faction, ChainArmour bodyArmour, Hammer weapon)
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

        public void HolyBlow()
        {
            throw new NotImplementedException();
        }
        public void PurifySoul()
        {
            throw new NotImplementedException();
        }
        public void RighteousWings()
        {
            throw new NotImplementedException();
        }
    }
}
