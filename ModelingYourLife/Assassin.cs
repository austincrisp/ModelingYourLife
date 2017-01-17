using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelingYourLife
{
    class Assassin
    {
        enum State
        {
            Alive, Dead, Ghost
        }

        enum Status
        {
            Stunned, Slowed, Snared, Poisoned, Hastened
        }

        // Assassin Name
        public string name;

        // Assassin Base Stats
        private int hp;
        private int intelligence;
        private int dexterity;
        private int strength;
        private int armor;
        private int mr;

        // Assassin Abilities
        private int attack;
        private int twinStrike;
        private int backstab;
        private bool dodge;

        public Assassin (string _name)
        {
            name = _name;
            hp = 210;
            intelligence = 4;
            dexterity = 13;
            strength = 8;
            attack = 4;
            twinStrike = 6;
            backstab = 7;
            dodge = false;
            armor = 25;
            mr = 22;
        }
    }
}
