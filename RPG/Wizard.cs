using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Wizard : Character
    {
        public int Mana { get; set; } = 100;

        public Wizard() : base() { }
        public Wizard(string name,
                        eTeam team = eTeam.Good,
                        int health = _healthMax,
                        int mana = 100) : base(name, team, health)
        {
            Mana = mana;
        }

        public override void Display()
        {
            Console.WriteLine();
            Console.WriteLine(typeof(Wizard).Name);
            base.Display();
            Console.WriteLine($"Mana: {Mana}");
        }

        public void Chant()
        {
            Console.WriteLine("Abracadabra!");
        }
    }
}
