using System;
using tabuleiro;

namespace Gabriela_Xadres {
    class Program {
        static void Main(string[] args) {

            Posicao p;
            
            p = new Posicao(3, 4);
            
            Console.WriteLine("Posição: " + p);

            Tabuleiro tab = new Tabuleiro(8, 8);

            Console.ReadLine();
        }
    }
}
