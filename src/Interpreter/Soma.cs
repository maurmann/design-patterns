﻿namespace Interpreter
{
    internal class Soma : IExpressao
    {
        private IExpressao esquerda;
        private IExpressao direita;

        public Soma(IExpressao esquerda, IExpressao direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public int Avalia()
        {
            int resultadoEsquerda = this.esquerda.Avalia();
            int resultadoDireita = this.direita.Avalia();
            return resultadoEsquerda + resultadoDireita;
        }
    }
}