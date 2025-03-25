using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Diamante_de_X
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Entrada do número para criação do triângulo e validação
            while (true)
            {

                Console.WriteLine("---------------------------------------");
                Console.Write("Insira um valor ímpar para realizar o desenho do diamante: ");
                string entradaNumeroUsuario = Console.ReadLine();
                int numeroDeX;

                if (!int.TryParse(entradaNumeroUsuario, out numeroDeX))
                {
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Por favor, utilize apenas números.");
                    continue;
                }              
                                
                if (numeroDeX % 2 == 0)
                {
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Valor inserido é par! Insira um número novamente: ");
                    continue;
                }
                else                    
                break;

            }
            
            Console.ReadLine();
        }
    }
}
