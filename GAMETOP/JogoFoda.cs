using GAMETOP.Interface;
using System;

namespace GAMETOP
{
    public class JogoFoda
    {
        public readonly iJogador _jogadorA;
        public readonly iJogador _jogadorB;

        public JogoFoda(iJogador jogadorA, iJogador jogadorB)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
            
        }
        
        public void IniciarJogo(){
            Console.WriteLine(_jogadorA.Corre());
            Console.WriteLine(_jogadorA.Chuta());
            Console.WriteLine(_jogadorA.Passe());

            Console.WriteLine("PROXIMO JOGADOR");

            Console.WriteLine(_jogadorB.Corre());
            Console.WriteLine(_jogadorB.Chuta());
            Console.WriteLine(_jogadorB.Passe());
        }
    }
}