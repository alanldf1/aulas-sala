﻿using System;

namespace aula6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            cars[0] = "Opel";
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars.Length);
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
        }
    }
}
