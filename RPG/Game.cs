using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KilpackLibrary;

namespace RPG
{
    class Game
    {
        enum eAction
        {
            Display,
            Attack,
            Flee,
            Heal,
            Exit
        }

        public List<Character> Characters { get; set; } = new List<Character>();
        public bool Quit { get; private set; } = false;
        public void PlayRound()
        {
            Console.WriteLine("\n\n");
            eAction action = (eAction)Utils.GetConsoleMenu("Enter Action: ", Enum.GetNames(typeof(eAction)));
            Console.Clear();
            switch (action)
            {
                case eAction.Display:
                    foreach (var c in Characters) { c.Display(); }
                    break;
                case eAction.Attack:
                    break;
                case eAction.Flee:
                    Flee();
                    break;
                case eAction.Heal:
                    break;
                case eAction.Exit:
                    Quit = true;
                    break;
                default:
                    break;
            }
        }

        void Flee()
        {
            var names = Characters.Select(c => c.Name).ToArray();
            int index = Utils.GetConsoleMenu("Who is Fleeing?: ", names);

            Character character = Characters[index];
            Console.WriteLine($"Goodbye, {character.Name}!");

            Characters.Remove(character);
        }
    }
}
