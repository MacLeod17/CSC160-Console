using KilpackLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    abstract class Character
    {
        public enum eTeam : byte
        {
            Good,
            Evil
        }

        public eTeam Team { get; protected set; } = eTeam.Good;
        public string Name { get; protected set; }
        public int Health 
        { 
            get { return _health; }
            set 
            {
                _health = value;
                if (_health > _healthMax) _health = _healthMax;
            }
        }

        protected const int _healthMax = 100;
        private int _health;
        private static int _counter = 0;

        public Character()
        {
            _counter++;
        }
        public Character(string name, eTeam team = eTeam.Good, int health = _healthMax)
        {
            Name = name;
            Team = team;
            Health = health;
            _counter++;
        }
        static Character()
        {
            Console.WriteLine("Static Constructor");
        }
        ~Character()
        {
            Console.WriteLine("Destructor");
            _counter--;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Name: {Name}\nTeam: {Team}\nHealth: {Health}");
        }

        public abstract void Attack(Character target);
    }
}
