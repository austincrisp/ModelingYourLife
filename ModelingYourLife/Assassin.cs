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
            Normal, Stunned, Slowed, Snared, Poisoned, Hastened
        }

        // Assassin Name, State, and Status
        public string name;
        //public State currentState = State.Alive;
        //public Status currentStatus = Status.Normal;

        // Assassin Base Stats
        private int hp;
        private int intelligence;
        private int dexterity;
        private int strength;
        private int armor;
        private int mr;

        // Assassin Abilities
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
            twinStrike = 6;
            backstab = 7;
            dodge = false;
            armor = 25;
            mr = 22;
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
                Console.WriteLine($"{name} used backstab on {enemy.name} for {backstab} damage!");
                enemy.LowerHP();
            }
            else
            {
                Console.WriteLine($"{name} used twin strike on {enemy.name} for {twinStrike} damage!");
                enemy.LowerHP();
            }
        }

        public void Attack(Mage enemy)
        {
            Roll();
            int random = int.Parse(Console.ReadLine());

            if (random % 2 != 0)
            {
                Console.WriteLine($"{name} used backstab on {enemy.name} for {backstab} damage!");
                enemy.LowerHP();
            }
            else
            {
                Console.WriteLine($"{name} used twin strike on {enemy.name} for {twinStrike} damage!");
                enemy.LowerHP();
            }
        }

        public void Attack(Assassin enemy)
        {
            Roll();
            int random = int.Parse(Console.ReadLine());

            if (random % 2 != 0)
            {
                Console.WriteLine($"{name} used backstab on {enemy.name} for {backstab} damage!");
                enemy.LowerHP();
            }
            else
            {
                Console.WriteLine($"{name} used twin strike on {enemy.name} for {twinStrike} damage!");
                enemy.LowerHP();
            }
        }

        public override string ToString()
        {
            return $"{name} : {hp} : {twinStrike} : {backstab}";
        }
    }
}
