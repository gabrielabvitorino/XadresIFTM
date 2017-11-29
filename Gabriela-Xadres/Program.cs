﻿using System;
using tabuleiro;
using xadrez;

namespace Gabriela_Xadres {
    class Program {
        static void Main(string[] args) {

            
                PosicaoXadrez pos = new PosicaoXadrez('c', 7);
                Console.WriteLine(pos);
            try {
                Tabuleiro tab = new Tabuleiro(8, 8);
                
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 3));
                
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(3, 5));
                
                Tela.imprimirTabuleiro(tab);
            }
             catch (TabuleiroException e){
                Console.WriteLine(e.Message);
             }

            Console.ReadLine();
        }
    }
}
