using System;
using System.Collections.Generic;
using System.Text;

namespace MagicMonsters.Equipment
{
    class Staff
    {
        string name;
        string ability;

        int age;

        public Staff()
        {
            throw new NotImplementedException();
        }

        public Staff(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Empower()
        {
            throw new NotImplementedException();
        }
    }
}
