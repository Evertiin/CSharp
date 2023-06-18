using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {

            var texto = "Testando";
            Console.WriteLine(texto);

            var a = texto;
            Console.WriteLine(a);

            const string A = "Oe";
            int idade = 25;
            int idadee = int.Parse("100");
            System.Console.WriteLine("idadee");
            uint interioSem = (uint)idade;

            Console.WriteLine(A);





            object gol = 'A';
            gol = 25;
            Console.WriteLine(gol);

            bool usuario = true;
            if (usuario == false)
            {

                Console.WriteLine("Falsa");
            }
            else
            {
                System.Console.WriteLine("AAA");
            }
            while (true)
            {
                if (usuario == false)
                {
                    System.Console.WriteLine("OK");
                    break;
                }
                else
                {
                    System.Console.WriteLine("Verdadeiro");
                    break;

                }

            }
            System.Console.WriteLine("Oi");

            int inteiro = 100;
            inteiro += 10;
            float real = 25.3f;

            real = inteiro;
            inteiro = Convert.ToInt32(real);
            inteiro = (int)real;
            System.Console.WriteLine(inteiro);
            inteiro = int.Parse(real.ToString());





        }
    }
}









