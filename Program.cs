using System.Collections;
using System.Diagnostics;

namespace calculator
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

            Console.WriteLine("O que deseja ?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            Console.WriteLine("-----------------");
            Console.WriteLine("Escolha uma opção:");

            short resultado = short.Parse(Console.ReadLine());

            switch (resultado)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;

            }

        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro numero : ");
            float v1 = float.Parse(Console.ReadLine());


            Console.WriteLine("Digite o segundo numero : ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            Console.WriteLine($"O valor da soma é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro numero: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"O valor da subtração é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro numero: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;
            Console.WriteLine($"O valor da multiplicação é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro numero: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / v2;
            Console.WriteLine($"O valor da divisão é {resultado}");
            Console.ReadKey();
            Menu();
        }

    }
}
