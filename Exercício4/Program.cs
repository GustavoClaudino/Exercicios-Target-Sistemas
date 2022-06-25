using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCIOCIO_4
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sp = 67836.43m, rj = 36678.66m, mg = 29229.88m, es = 27165.48m, outros = 19849.53m;
            decimal valorTotal = 153621.66m;

            Console.WriteLine("Escolha uma sigla dos Estados");
            string valorDigitado = Console.ReadLine();

            decimal valor;
            switch (valorDigitado.ToUpper())
            {
                case "SP":
                    valor = sp;
                    break;

                case "RJ":
                    valor = rj;
                    break;

                case "MG":
                    valor = mg;
                    break;

                case "ES":
                    valor = es;
                    break;
                default:
                    valor = outros;
                    break;
            }

            decimal calculo = (valor * 100 / valorTotal);
            Console.WriteLine($"O lucro do estado foi {decimal.Round(calculo, 2)}%");

            Console.Read();
        }
    }
}
