using System;
using System.Collections.Generic;

namespace DesafioDoPenalti
{
    class Program
    {
        static void Main(string[] args)
        {

            var listaDeJogadores = new List<Jogador>();

            var jogador1 = new Jogador(TiposDeJogadores.Atacante);
            var jogador2 = new Jogador(TiposDeJogadores.Lateral);
            var jogador3 = new Jogador(TiposDeJogadores.Lateral);
            var jogador4 = new Jogador(TiposDeJogadores.Lateral);

            listaDeJogadores.Add(jogador1);
            listaDeJogadores.Add(jogador2);
            listaDeJogadores.Add(jogador3);
            listaDeJogadores.Add(jogador4);

            for (int i = 0; i < listaDeJogadores.Count; i++)
            {
                Console.WriteLine(listaDeJogadores[i].Chutar(i+1)); 
            }
        }
    }
}
