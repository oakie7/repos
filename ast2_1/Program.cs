﻿using System;

namespace ast2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange cirkelns diameter: ");

            double userInput = double.Parse(Console.ReadLine());

            Console.WriteLine("En cirkel med diametern {0} har: ", userInput);

            double circumference = Math.PI * userInput;

            Console.WriteLine("omkretsen: {0}", circumference);

            Console.WriteLine("En cirkel med diametern {0} har: ", userInput);

            double area = Math.PI * userInput / 2;
            Console.WriteLine("arean: {0}", area);

            Console.ReadKey();
        }
    }
}
