using System;
using System.IO;  // inclui o System.IO namespace

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string writeText = "Olá mundo!";  // Cria a string de texto
            File.WriteAllText("filename.txt", writeText);  //Crie um arquivo e escreva o conteúdo do writeText nele

            string readText = File.ReadAllText("filename.txt"); // Lê o conteúdo do arquivo
            Console.WriteLine(readText); // Saída do conteúdo
        }
    }
}