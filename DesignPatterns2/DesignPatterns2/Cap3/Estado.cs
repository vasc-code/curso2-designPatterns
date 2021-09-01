using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap3
{
    class Estado
    {
        public Estado(Contrato contrato)
        {
            Contrato = contrato;
        }

        public Contrato Contrato { get; private set; }

    }
}
