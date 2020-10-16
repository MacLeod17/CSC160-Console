using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Character
    {
        public int Health = 100;
        private int _damage = 20;
        private int multi = 2;
        private static int _numCharacters = 0;

        private const int _maxHealth = 100;

        public int Damage { get { return _damage * multi; } set { if (value <= 100) _damage = value; } }
        public int Armour { get; private set; } = 100;
        public string Name { get; set; }

        public Character() { _numCharacters++; }
        public Character(string name)
        {
            Name = name;
            _numCharacters++;
        }

        public void HitDamage(int damage)
        {
            _damage = damage;
        }

        public static void Sqr(ref int n)
        {
            n = n * n;
        }
    }
}
