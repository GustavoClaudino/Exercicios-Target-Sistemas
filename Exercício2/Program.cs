using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estagio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 2 Fibonacci
            int a = 0; // numero anterior
            int b = 1; //numero atual
            int fibonacci = 0;

            Console.WriteLine(" Escreva um valor para conferir se é fibonacci");
            var valorTela = Console.ReadLine();
            int valor = int.Parse(valorTela);

            while (fibonacci < valor)
            {
                fibonacci = a + b;
                b =
                a = fibonacci;
            }

            if (fibonacci == valor)
            {
                Console.WriteLine("pertence ao fibonacci");
            }
            else
            {
                Console.WriteLine("não é o valor");
            }

            Console.ReadKey();
        }
    }
}

