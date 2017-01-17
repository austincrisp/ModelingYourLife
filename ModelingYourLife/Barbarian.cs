using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelingYourLife
{
    class Barbarian
    {
        enum State
        {
            Alive, Dead, Ghost
        }

        enum Status
        {
            Stunned, Slowed, Snared, Poisoned, Hastened
        }

        // Barbarian Name
        public string name;

        // Barbarian Base Stats
        private int hp;
        private int intelligence;
        private int dexterity;
        private int strength;
        private int armor;
        private int mr;

        // Barbarian Abilities
        private int attack;
        private int slash;
        private int shieldSlam;
        private bool spellReflect;

        public Barbarian(string _name)
        {
            name = _name;
            hp = 300;
            intelligence = 2;
            dexterity = 7;
            strength = 13;
            attack = 4;
            slash = 10;
            shieldSlam = 8;
            spellReflect = false;
            armor = 40;
            mr = 15;
        }
    }
}
