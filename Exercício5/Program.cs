using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra");
            string palavraRecebida = Console.ReadLine();
            char[] palavraArray = palavraRecebida.ToCharArray();
            char[] palavraInvertida = new char[palavraRecebida.Length];
            
            for (int i = 0; i < palavraRecebida.Length; i++)
            {
                palavraInvertida[i] = palavraArray [(palavraRecebida.Length - i)-1];
            }

            Console.WriteLine(palavraInvertida);
            string palavra = new string(palavraInvertida);

            if (palavraRecebida.Replace(" ", "").ToUpper() == palavra.Replace(" ", "").ToUpper())
            {
                Console.WriteLine("Parabéns é um palíndromo");
            }
            else
            {
                Console.WriteLine("Tente novamente, não é um palíndromo");
            }

            Console.ReadLine();
        }
    }
}
