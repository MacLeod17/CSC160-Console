using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Game game = new Game();
                
                game.Characters.Add(new Warrior("Rick"));
                game.Characters.Add(new Wizard("Morgan", Character.eTeam.Evil));
                game.Characters.Add(new Wizard("Harry", Character.eTeam.Good));

                do
                {
                    game.PlayRound();
                } while (!game.Quit);




                List<Character> wizards = game.Characters.FindAll(c => c is Wizard);
                foreach (Wizard wizard in wizards)
                {
                    Console.Write($"{wizard.Name} shouts ");
                    wizard.Chant();
                }

                foreach(var character in game.Characters)
                {
                    character.Display();
                    if (character is Wizard wiz)
                    {
                        wiz.Chant();
                        Console.WriteLine($"You're a wizard, {wiz.Name}!");
                    }
                }

                Console.ReadKey();
            }

        }
    }
}
