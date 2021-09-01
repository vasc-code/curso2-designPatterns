using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap6
{
    class MensagemAdministrativa : IMensagem
    {
        public string Nome;
        public IEnviador Enviador { get; set; }

        public MensagemAdministrativa(string nome)
        {
            Nome = nome;
        }

       
        public void Envia()
        {
            Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format("Enviando a mensagem para o administrador {0}", Nome);
        }
    }
}
