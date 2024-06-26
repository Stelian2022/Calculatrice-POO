﻿using Calculatrice.Operations;
using System;
using System.Collections.Generic;

namespace Calculatrice
{
    class Program
    {
      

        static Dictionary<string, Operation> Operations { get; }
= new()
{
{ "+", new Addition() },
{ "-", new Soustraction() },
{ "*", new Multiplication() },
{ "/", new Division() },
{ "%", new Modulo() }
};
        static void Main(string[] args)
        {
            do
            {
                if (SaisirNombre("Entrez un premier nombre", out int a ) &&
                    SaisirNombre("Entrez un deuxième nombre", out int b))
                {
                    Console.WriteLine("Entrez un symbole d'opération");
                    string operateur = Console.ReadLine();
                    if (Operations.TryGetValue(operateur, out Operation operation))
                    {
                        Console.WriteLine($"{a} {operateur} {b} = {operation.Calculer(a,b)}");
                    }
                }
                Console.WriteLine("Tapez ESC pour quitter ou Une autre touche pour continuer.");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        private static bool SaisirNombre(string message, out int valeur)
        {
            Console.WriteLine(message);
            return int.TryParse(Console.ReadLine(), out valeur);
        }
    }
}
