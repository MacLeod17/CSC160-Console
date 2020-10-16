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
            //Console.Clear();
            switch (action)
            {
                case eAction.Display:
                    foreach (var c in Characters) { c.Display(); }
                    break;
                case eAction.Attack:
                    Attack();
                    break;
                case eAction.Flee:
                    Flee();
                    break;
                case eAction.Heal:
                    Heal();
                    break;
                case eAction.Exit:
                    Quit = true;
                    break;
                default:
                    break;
            }
        }

        void Attack()
        {
            var names = Characters.Select(c => c.Name).ToArray();
            int attackIndex = Utils.GetConsoleMenu("Who is attacking?: ", names);
            int targetIndex = Utils.GetConsoleMenu("Who is the target?: ", names);

            Character attacker = Characters[attackIndex];
            Character target = Characters[targetIndex];

            attacker.Attack(target);

            //Check For Death
            if (target.Health <= 0)
            {
                Console.WriteLine($"{target.Name} is dead.");
                Characters.Remove(target);
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

        void Heal()
        {
            var names = Characters.Select(c => c.Name).ToArray();
            int index = Utils.GetConsoleMenu("Who do you want to heal?: ", names);

            Character character = Characters[index];
            if (character is IHealer healer)
            {
                int r = 20;
                int heal = r.GetRandom(5);
                healer.Heal(heal);
                Console.WriteLine($"{character.Name} has been healed {heal} points.");
            }
            else
            {
                Console.WriteLine($"{character.Name} cannot be healed.");
            }
        }
    }
}
