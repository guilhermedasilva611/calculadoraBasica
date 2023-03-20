using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraBasica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            * Faça uma calculadora que leia dois números inteiros e imprima a soma, subtração, multiplicação, divisão 
            * e o resto da divisão desses números.
            */

            Console.WriteLine("---Bem vindo ao programa CALCULADORA---");

            int i = 1;
            do
            {
                Console.Write("Digite um numero:");
                int numero = int.Parse(Console.ReadLine());
                Console.Write("Digite outro numero:");
                int numero2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"A SOMA:{numero + numero2}");
                Console.WriteLine($"A SUBTRAÇÃO:{numero - numero2}");
                Console.WriteLine($"A MULTIPLICAÇÃO:{numero * numero2}");
                Console.WriteLine($"A DIVISÃO:{(double)numero / numero2}");
                Console.WriteLine($"A RESTO DA DIVISÃO:{numero % numero2}");

                Console.WriteLine("Deseja calcular outros numeros? 1-sim 2-não");
                i = int.Parse(Console.ReadLine());

            } while (i == 1);


            Console.Write("---Pressione ENTER para encerrar---");
            Console.ReadLine();
        }
    }
}
