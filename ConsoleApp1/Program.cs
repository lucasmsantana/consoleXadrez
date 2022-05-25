using System;
using ConsoleApp1.tabuleiro;
using xadrez;
using tabuleiro;
using ConsoleApp1.xadrez;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();
                Tela.imprimirTabuleiro(partida.tab) ;
            }

            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();


        }
    }
}
