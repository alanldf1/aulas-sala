using System;

namespace Projeto3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int myint = 9;
            //double mydouble = myint; // conversão automática: int para dobrar

            //console.writeline(myint); // saída 9
            //console.writeline(mydouble); // saída 9

            //double mydouble = 9,78;
            //int myint = (int)mydouble; // transmissão manual: double to int

            //console.writeline(mydouble); // saídas 9.78
            //console.writeline(myint); // saídas 9

            //int myint = 10;
            //double mydouble = 5.25;
            //bool mybool = true;

            //console.writeline(convert.tostring(myint)); // converte int para string
            //console.writeline(convert.todouble(myint)); // converte int para o dobro
            //console.writeline(convert.toint32(mydouble)); // converte double para int
            //console.writeline(convert.tostring(mybool)); // converte bool para string

            // Digite seu nome de usuário e pressione enter
            //Console.WriteLine("Digite o nome de usuário:");

            // Crie uma variável de string e obtenha a entrada do usuário do teclado e armazene-a na variável
            //string userName = Console.ReadLine();

            //Console.WriteLine("Digite sua idade:");
            //int idade = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Sua idade é:" + idade);

            // Imprime o valor da variável (userName), que exibirá o valor de entrada
            //Console.WriteLine("Nome de usuário é " + userName + "e sua idade é " + idade);
            int i = 0;
            int fnumber = 0;
            int snumber = 0;

            Console.WriteLine("Digite seu nome:");
            string userName = Console.ReadLine ();

            Console.WriteLine("Escolha a operação que deseja fazer:" +
                "[1] - Adição." +
                "[2] - Subtração." +
                "[3] - Multiplicação." +
                "[4] - Divisão. ");

            int i = Convert.ToInt32(Console.ReadLine());

            if (i == 1)
            {
                Console.WriteLine("Digite o primeiro numero a ser somado: ");
                int fnumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero a ser somado: ");
                int snumber = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                return 0;
            }
       
            Console.WriteLine("Seu nome é" + userName + " e a soma solicitidada resulta em: " + fnumber + snumber);
        }
    }
}
