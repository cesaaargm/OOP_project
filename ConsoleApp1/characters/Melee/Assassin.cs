using System;
using MagicMonsters.Equipment.Armour.Leather;
using MagicMonsters.Equipment.Weapon.Sharp;

namespace MagicMonsters.characters.Melee
{
    class Assassin
    {
        #region fields

        private int abilityPoints;
        private int healthPoints;
        private int level;

        private string name;
        private string faction;

        private LightLeatherVest bodyArmour;
        private Sword weapon;


        #endregion fields

        #region Properties

        public int AbilityPoints 
        { 
            get => abilityPoints;

            set
            {
                if (value >= 0)
                {
                    try
                    {
                        abilityPoints = value;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                     throw new ArgumentOutOfRangeException(string.Empty, "Ability points must be a positive number! Not assigned");
                }
            } 
        }
        public int HealthPoints
        {
            get => healthPoints;

            set
            {
                if (value >= 0)
                {
                    try
                    {
                        healthPoints = value;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Health points must be a positive number! Not assigned");
                }
            }
        }
        public int Level
        {
            get => level;

            set
            {
                if (value > 0 && value <= 100)
                {
                    try
                    {
                        level = value;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Level must be between 1 and 100");
                }
            }
        }
       
        public string Name
        {
            get => name;

            set
            {
                if (0==0)
                {
                    try
                    {
                        name = value;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "TBd");
                }
            }
        }
        public string Faction
        {
            get => faction;

            set
            {
                if (0 == 0)
                {
                    try
                    {
                        faction = value;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "TBd");
                }
            }
        }

        internal LightLeatherVest BodyArmour 
        {
            get => bodyArmour;

            set => bodyArmour = value; 
        }
        internal Sword Weapon 
        {
            get => weapon; 
            set => weapon = value;
        }


        #endregion Properties

        #region Constructors
        public Assassin()
        {
            throw new NotImplementedException();
        }

        public Assassin(int abilityPoints, string faction, int healthPoints, int level, string name, LightLeatherVest bodyArmour, Sword weapon)
        {
            this.AbilityPoints = abilityPoints;
            this.Faction = faction;
            this.HealthPoints = healthPoints;
            this.Level = level;
            this.Name = name;
            this.BodyArmour = bodyArmour;
            this.Weapon = weapon;
        }

        #endregion Constructors
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
