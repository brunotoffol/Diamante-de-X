using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamante_de_X
{
    class Funcoes
    {

        //Metodo para Exibir o Menu
        static public int ExibirMenu()
        {
            int numeroDeX;
            while (true)
            {

                Console.WriteLine("---------------------------------------");
                Console.Write("Insira um valor ímpar para realizar o desenho do diamante: ");
                string entradaNumeroUsuario = Console.ReadLine()!;


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
                    return numeroDeX;

            }
        }
       
        //Loops que realizam o desenho do diamante de X
        static public void DesenhoDiamante(int numeroDeX)
        {
            for (int i = 1; i <= numeroDeX; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("");
                }

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
                    Console.Write("");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("X");
                }

                Console.WriteLine();
            }
        }
    }
}
