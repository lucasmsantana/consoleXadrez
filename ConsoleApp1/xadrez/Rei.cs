using System;
using tabuleiro;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.tabuleiro;

namespace xadrez
{
    internal class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        public override string ToString()
        {
            return "R";
        }

    }
    
    }

