using System;
using System.Collections.Generic;
using System.Text;
using MagicMonsters.Equipment.Armour.Leather;
using MagicMonsters.Equipment.Weapon.Sharp;

namespace MagicMonsters.characters.Spellcasters
{
    class Necromancer
    {

        // Fields

        private int abilityPoints;
        private int healthPoints;
        private int level;
        private int name;

        private string faction;

        private LightLeatherVest bodyArmour;
        private Sword weapon;


        // Constructors

        public Necromancer()
        {
            throw new NotImplementedException();
        }

        public Necromancer(int abilityPoints, int healthPoints, int level, int name, string faction, LightLeatherVest bodyArmour, Sword weapon)
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

        public void ShadowRage()
        {
            throw new NotImplementedException();
        }
        public void VampireTouch()
        {
            throw new NotImplementedException();
        }
        public void BoneShield()
        {
            throw new NotImplementedException();
        }
    }
}
