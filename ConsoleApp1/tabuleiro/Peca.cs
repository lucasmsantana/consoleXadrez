﻿using System;
using tabuleiro;
namespace ConsoleApp1.tabuleiro
{
    internal abstract class Peca
    {

        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            this.posicao = null;
            this.cor = cor;
            this.tab = tab;
            this.qteMovimentos = 0;
        }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.tab = tab;
            this.cor = cor;
        }

        public abstract bool[,] movimentosPossiveis();
        public void incrementarQteMovimentos()
        {
            qteMovimentos++;
        }
        public void decrementarQteMovimentos()
        {
            qteMovimentos--;
        }

        public bool movimentoPossivel(Posicao pos)
        {
            return movimentosPossiveis() [pos.linha, pos.coluna];
        }
        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
