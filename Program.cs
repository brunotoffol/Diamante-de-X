using System;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Diamante_de_X
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Entrada do número para criação do triângulo e validação
            int numeroDeX = Funcoes.ExibirMenu();

            //Laços de repetição que fazem o desenho  
            Funcoes.DesenhoDiamante(numeroDeX);

            Console.ReadLine();

            
        }
    }
}
