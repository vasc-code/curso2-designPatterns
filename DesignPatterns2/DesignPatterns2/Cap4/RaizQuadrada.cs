using DesignPatterns2.Cap5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap4
{
    class RaizQuadrada : IExpressao
    {
        public IExpressao Valor { get; private set; }

        public RaizQuadrada(IExpressao valor)
        {
            Valor = valor;
        }

        public int Avalia()
        {
            double raiz = Valor.Avalia();

            return (int)Math.Sqrt(raiz);
        }

        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeRaiz(this);
        }

    }
}
