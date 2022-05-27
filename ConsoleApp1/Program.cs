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
                while (!partida.terminada)
                {
                    try { 
                    Console.Clear();
                        Tela.imprimirPartida(partida);
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    partida.validarPosicaoDeOrigem(origem);
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                    partida.realizaJogada(origem, destino);
                    partida.validarPosicaoDeDestino(origem, destino);

                    }
                    catch (TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
                
            }

            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();


        }
    }
}
