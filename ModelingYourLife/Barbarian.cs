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

        // Barbarian Name, State, and Status
        public string name;
        //public State currentState = State.Alive;
        //public Status currentStatus = Status.Normal;

        // Barbarian Base Stats
        private int hp;
        private int intelligence;
        private int dexterity;
        private int strength;
        private int armor;
        private int mr;

        // Barbarian Abilities
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
            slash = 10;
            shieldSlam = 8;
            spellReflect = false;
            armor = 40;
            mr = 15;
        }
        public void Roll()
        {
            var rng = new Random();
            Console.WriteLine(rng.Next(1, 6));
        }

        public void LowerHP()
        {

        }

        public void Attack(Barbarian enemy)
        {
            Roll();
            int random = int.Parse(Console.ReadLine());

            if (random % 2 != 0)
            {
                Console.WriteLine($"{name} used shield slam on {enemy.name} for {shieldSlam} damage!");
                enemy.LowerHP();
            }
            else
            {
                Console.WriteLine($"{name} used slash on {enemy.name} for {slash} damage!");
                enemy.LowerHP();
            }
        }

        public void Attack(Mage enemy)
        {
            Roll();
            int random = int.Parse(Console.ReadLine());

            if (random % 2 != 0)
            {
                Console.WriteLine($"{name} used shield slam on {enemy.name} for {shieldSlam} damage!");
                enemy.LowerHP();
            }
            else
            {
                Console.WriteLine($"{name} used slash on {enemy.name} for {slash} damage!");
                enemy.LowerHP();
            }
        }

        public void Attack(Assassin enemy)
        {
            Roll();
            int random = int.Parse(Console.ReadLine());

            if (random % 2 != 0)
            {
                Console.WriteLine($"{name} used shield slam on {enemy.name} for {shieldSlam} damage!");
                enemy.LowerHP();
            }
            else
            {
                Console.WriteLine($"{name} used slash on {enemy.name} for {slash} damage!");
                enemy.LowerHP();
            }
        }

        public override string ToString()
        {
            return $"{name} : {hp} : {slash} : {shieldSlam}";
        }
    }
}
