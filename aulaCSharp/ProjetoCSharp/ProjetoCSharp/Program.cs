using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjetoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter x;

            Console.WriteLine("Digite seu nome completo: ");
            string name = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            int age = Convert.ToInt32 (Console.ReadLine());
            
            Console.WriteLine("Digite seu cpf: ");
            int cpf = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o bairro onde mora: ");
            string neighborhood = Console.ReadLine();
            
            Console.WriteLine("Deixe aqui sua reclamação: ");
            string complaint = Console.ReadLine();

            x.WriteLine = "Nome: " + name;  // Cria a string de texto
            x.WriteLine();
            File.WriteAllText("filename.txt", writeText);  //Crie um arquivo e escreva o conteúdo do writeText nele

            string writeLine = "Idade: " + age;
            x.WriteLine();
            File.WriteAllText("filename.txt", writeText);

            string writeLine = "CPF: " + cpf;
            x.WriteLine();
            File.WriteAllText("filename.txt", writeText);

            string writeLine = "Bairro: " + neighborhood;
            x.WriteLine();
            File.WriteAllText("filename.txt", writeText);

            string readText = File.ReadAllText("filename.txt"); // Lê o conteúdo do arquivo
            Console.WriteLine(readText); // Saída do conteúdo
        }
    }
}
