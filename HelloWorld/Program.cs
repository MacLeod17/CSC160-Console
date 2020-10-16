using HelloWorld;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using KilpackLibrary;


class Program
{
    class Point
    {
        public Point(int x, int y) { X = x; Y = y; }

        public int X;
        public int Y;
    }

    static void Main(string[] args)
    {
        Utils.Hello("Garrick");
        
        {
            Character player = new Character("Carter");
            player.Health = 20;
            player.Damage = 30;
            int sn = 5;
            Character.Sqr(ref sn);
            Console.WriteLine(sn);
        }
        
        int[] a = { 1, 2, 3, 4, 5 };
        foreach (int n in a)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();

        int[,] ma = new int[3, 3]
        {
            {1, 2, 3 },
            {1, 2, 3 },
            {1, 2, 3 }
        };

        var names = new List<string>();
        names.Add("Carter");
        names.Add("Alex");
        foreach(var name in names)
        {
            Console.Write(name + " ");
        }
        Console.WriteLine();

        var al = new ArrayList() { "Spencer", 10, 4.5f };
        foreach(var an in al)
        {
            Console.Write(an + " ");
        }
        Console.WriteLine();

        Point p1 = new Point(10, 20);

        Console.WriteLine("Hello, World!");
        Console.ReadLine();
    }
}
