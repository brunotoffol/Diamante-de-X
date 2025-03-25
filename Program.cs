using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Diamante_de_X
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numeroDeX;            
            //Entrada do número para criação do triângulo e validação
            while (true)
            {

                Console.WriteLine("---------------------------------------");
                Console.Write("Insira um valor ímpar para realizar o desenho do diamante: ");
                string entradaNumeroUsuario = Console.ReadLine();                

                if (!int.TryParse(entradaNumeroUsuario, out numeroDeX))
                {
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Por favor, utilize apenas números.");
                    continue;
                }              
                                
                else if (numeroDeX % 2 == 0)
                {
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Valor inserido é par! Insira um número novamente: ");
                    continue;
                }
                else                    
                break;

            }

            //Laços de repetição que desenham o Losango  
            for (int i = 1; i <= numeroDeX; i++)
            {                   
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }

            for (int i = numeroDeX; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
