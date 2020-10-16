using System;

namespace aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            //int soma1 = 100 + 50; // 150 (100 + 50)
            //int soma2 = soma1 + 250; // 150 (150 + 250)
            //int soma3 = soma2 + soma2; // 800 (400 + 400)

            //int x = 1, y = 9;
            //x += 5;

            //if (x > y)
            //{
            //    Console.WriteLine("x é maior que y");
            //}
            //else
            //{
            //    Console.WriteLine("x não é maior que y");
            //}

            //int tempo = 20;
            //string resultado = (tempo < 18) ? "Bom dia!" : "Boa noite!";
            //Console.WriteLine(resultado);

            int dia = 4;

            switch (dia)
            {
                case 1:
                    Console.WriteLine("Segunda-feira");
                    break;
                case 2:
                    Console.WriteLine("Terça-feira");
                    break;
                case 3:
                    Console.WriteLine("quarta-feira");
                    break;
                case 4:
                    Console.WriteLine("Quinta-feira");
                    break;
                case 5:
                    Console.WriteLine("Sexta-feira");
                    break;
                case 6:
                    Console.WriteLine("Sábado");
                    break;
                case 7:
                    Console.WriteLine("domingo");
                    break;
            }
        }
    }
}
