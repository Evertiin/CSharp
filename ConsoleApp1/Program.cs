using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            int Pontuacao = 0;
            System.Console.WriteLine("Bem vindo ao jogo de perguntas");


            System.Console.WriteLine("Deseja participar?");
            Console.WriteLine("1 - Opção 1");
            Console.WriteLine("2 - Opção 2");

            string opcao = Console.ReadLine();

            if (opcao == "1")
            {
                System.Console.WriteLine("Vamos começar");
            }
            else
            {
                System.Console.WriteLine("Até a próxima");
                return;
            }


            System.Console.WriteLine("Vamos a primeira pergunta");

            System.Console.WriteLine("Quem descobriu o Brasil");

            System.Console.WriteLine("(A) - Pedro Alavares Cabral");
            System.Console.WriteLine("(B) - Dom Pedro II");
            string pergunta1 = Console.ReadLine();

            if (pergunta1 == "A" || pergunta1 == "a")
            {
                System.Console.WriteLine("Acertouu");
                Pontuacao += 5;
            }
            else
            {
                System.Console.WriteLine("Errou");
                Pontuacao -= 5;
            }
            System.Console.WriteLine(Pontuacao);




        }
    }
}









