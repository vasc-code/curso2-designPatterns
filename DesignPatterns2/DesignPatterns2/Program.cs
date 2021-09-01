using DesignPatterns2.Cap1;
using DesignPatterns2.Cap2;
using DesignPatterns2.Cap3;
using DesignPatterns2.Cap4;
using DesignPatterns2.Cap5;
using DesignPatterns2.Cap6;
using DesignPatterns2.Cap7;
using DesignPatterns2.Cap8;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Xml.Serialization;
using DesignPatterns2.Cap9;

namespace DesignPatterns2
{
    class Program
    {

        static void Main(string[] args)
        {
            String cpf = "1234";

            EmpresaFacade facade = new EmpresaFacade();
            Cliente cliente = facade.BuscaCliente(cpf);

            var fatura = facade.CriarFatura(cliente, 5000);
            fatura.GeraCobranca(tipo.Boleto, fatura);
        }
    }
}
