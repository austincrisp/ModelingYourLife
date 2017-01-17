using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelingYourLife
{
    class Mage
    {
        enum State
        {
            Alive, Dead, Ghost
        }

        enum Status
        {
            Stunned, Slowed, Snared, Poisoned, Hastened
        }

        // Mage Name
        public string name;

        // Mage Base Stats
        private int hp;
        private int intelligence;
        private int dexterity;
        private int strength;
        private int armor;
        private int mr;

        // Mage Abilities
        private int fireball;
        private int frostbolt;
        private bool focus;

        public Mage (string _name)
        {
            name = _name;
            hp = 135;
            intelligence = 14;
            dexterity = 9;
            strength = 3;
            fireball = 15;
            frostbolt = 10;
            focus = false;
            armor = 15;
            mr = 40;
        }

        public void Attack()
        {
            Console.Write($"What would you like to cast {name}? ");
            Console.ReadLine
        }
    }
}
