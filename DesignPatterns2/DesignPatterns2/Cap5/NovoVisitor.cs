﻿using DesignPatterns2.Cap4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap5
{
    class NovoVisitor : IVisitor
    {
        public void ImprimeSoma(Soma soma)
        {
            Console.Write("+ (");
            soma.Esquerda.Aceita(this);
            Console.Write(",");
            soma.Direita.Aceita(this);
            Console.Write(")");
        }
        public void ImprimeSubtracao(Subtracao subtracao)
        {
            Console.Write("- (");
            subtracao.Esquerda.Aceita(this);
            Console.Write(",");
            subtracao.Direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeDivisao(Divisao divisao)
        {
            Console.Write("/ (");
            divisao.Esquerda.Aceita(this);
            Console.Write(",");
            divisao.Direita.Aceita(this);
            Console.Write(")");
        }
        public void ImprimeMultiplicacao(Multiplicacao multiplicacao)
        {
            Console.Write("* (");
            multiplicacao.Esquerda.Aceita(this);
            Console.Write(",");
            multiplicacao.Direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeRaiz(RaizQuadrada raizQuadrada)
        {
            Console.Write("raiz, (");
            raizQuadrada.Valor.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeNumero(Numero numero)
        {
            Console.Write(numero.Valor);
        }
    }
}
