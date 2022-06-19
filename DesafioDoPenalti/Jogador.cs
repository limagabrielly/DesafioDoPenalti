using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDoPenalti
{
    class Jogador
    {
        public TiposDeJogadores Tipo { get;}
        public Jogador(TiposDeJogadores tipo)
        {
            Tipo = tipo;
        }

        public string Chutar(int posição)
        {
            if (Tipo == TiposDeJogadores.Atacante)
            {
                return "Acertou";
            }
            else if (Tipo == TiposDeJogadores.MeioCampo && (posição == 2 || posição == 4))
            {
                return "Acertou";
            }
            else if (Tipo == TiposDeJogadores.Lateral && posição == 1)
            {
                return "Acertou";
            }
            else if (Tipo == TiposDeJogadores.Zagueiro && posição == 3)
            {
                return "Acertou";
            }
            else
            {
                return "Errou";
            }

        }
    }
}
