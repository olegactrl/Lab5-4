using System;

namespace Lab4
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            Ecosystem ecosystem = new Ecosystem();
            ecosystem.Plant();
            ecosystem.Weight();
            ecosystem.Hunt();
            ecosystem.Reproduct();
            ecosystem.Number();
            Console.WriteLine();
        }

    }
}