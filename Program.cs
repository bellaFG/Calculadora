using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)

        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Escolha o tipo de operação:");

            Console.WriteLine("");

            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisao");
            Console.WriteLine("4- Multiplicação");

            var operacao = int.Parse(Console.ReadLine());


            if (operacao == 1)
            {
                Soma();
            }

            else if (operacao == 2)
            {
                Subtracao();
            }

            else if (operacao == 3)
            {
                Divisao();
            }

            else if (operacao == 4)
            {
                Multiplicacao();
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }

        }
        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");


            float resultado = v1 + v2;
            Console.WriteLine($"O resultado da soma é: {v1 + v2}");
            Console.ReadKey();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Primeiro valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");


            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é {resultado}");
            Console.ReadKey();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Primeiro valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");


            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da subtração é {resultado}");
            Console.ReadKey();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Primeiro valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");


            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da subtração é {resultado}");
            Console.ReadKey();
        }
    }

}
