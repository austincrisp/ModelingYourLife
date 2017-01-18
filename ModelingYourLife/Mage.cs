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
            Normal, Stunned, Slowed, Snared, Poisoned, Hastened
        }

        // Mage Name, State, and Status
        public string name;
        public State currentState = State.Alive;
        //public Status currentStatus = Status.Normal;

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

        public Mage(string _name)
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
                Console.WriteLine($"{name} cast frostbolt on {enemy.name} for {frostbolt} damage!");
                enemy.LowerHP();
            }
            else
            {
                Console.WriteLine($"{name} cast fireball on {enemy.name} for {fireball} damage!");
                enemy.LowerHP();
            }
        }

        public void Attack(Mage enemy)
        {
            Roll();
            int random = int.Parse(Console.ReadLine());

            if (random % 2 != 0)
            {
                Console.WriteLine($"{name} cast frostbolt on {enemy.name} for {frostbolt} damage!");
                enemy.LowerHP();
            }
            else
            {
                Console.WriteLine($"{name} cast fireball on {enemy.name} for {fireball} damage!");
                enemy.LowerHP();
            }
        }

        public void Attack(Assassin enemy)
        {
            Roll();
            int random = int.Parse(Console.ReadLine());

            if (random % 2 != 0)
            {
                Console.WriteLine($"{name} cast frostbolt on {enemy.name} for {frostbolt} damage!");
                enemy.LowerHP();
            }
            else
            {
                Console.WriteLine($"{name} cast fireball on {enemy.name} for {fireball} damage!");
                enemy.LowerHP();
            }
        }

        public override string ToString()
        {
            return $"{name} : {hp} : {frostbolt} : {fireball}";
        }
    }
}
