﻿using KilpackLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Warrior : Character
    {
        public int Strength { get; set; } = 100;

        public Warrior() : base() { }
        public Warrior(string name, 
                        eTeam team = eTeam.Good, 
                        int health = _healthMax,
                        int strength = 100) : base(name, team, health)
        {
            Strength = strength;
        }

        public override void Display()
        {
            Console.WriteLine();
            Console.WriteLine(typeof(Warrior).Name);
            base.Display();
            Console.WriteLine($"Strength: {Strength}");
        }

        public override void Attack(Character target)
        {
            Console.Write($"{Name} swings their sword at {target.Name}...");
            if (100.GetRandom() <= 50)
            {
                int damage = Strength.GetRandom();
                target.Health -= damage;
                Console.WriteLine($"and hits with {damage} damage!");
            }
            else
            {
                Console.WriteLine($"and misses.");
            }
        }
    }
}
