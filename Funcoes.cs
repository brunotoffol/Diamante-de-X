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

                Console.Clear();
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
            //Fórmula da quantidade de linhas: (numeroDeLinhas - 1) / 2
            int quantidadeDeLinhas = (numeroDeX - 1) / 2;
            int quantidadeDeX = 1;
            
            //A quantidade de espaços segue a fórmula: (numerodeLinhas - 1) /2
            int quantidadeDeEspacos = (numeroDeX - 1) / 2;            

            //Parte Superior do Diamante
            //Incrementa o X em 2 a cada linha
            for (int linhas = 0; linhas < quantidadeDeLinhas; linhas++)
            {
                for (int espacos = 0; espacos < quantidadeDeEspacos; espacos++)                
                    Console.Write(" ");              
                                
                for (int x = 0; x < quantidadeDeX; x++)                
                    Console.Write("X");

                quantidadeDeX += 2;
                quantidadeDeEspacos--;
                    
                                
                Console.WriteLine();
            }         
            
            //Parte do Meio do Diamante
            //A parte do meio do diamante sempre vai ter a mesma quantidade de Xs do input do usuário
            for (int colunas = 0; colunas < numeroDeX; colunas++)
            {
                Console.Write("X");
            }
            Console.WriteLine();

            //Parte Inferior do Diamante
            //A quantidade de espaços é incremenetada em 1 a cada linha
            //Decrementa o X em 2 a cada linha
            
            quantidadeDeX -= 2;
            quantidadeDeEspacos = 1;
            
            for (int linhas = 0; linhas < quantidadeDeLinhas; linhas++)
            {
                for (int espacos = 0; espacos < quantidadeDeEspacos; espacos++)
                    Console.Write(" ");

                for (int x = 0; x < quantidadeDeX; x++)
                    Console.Write("X");

                quantidadeDeX -= 2;
                quantidadeDeEspacos++;

                Console.WriteLine();
            }

        }
    }
}
