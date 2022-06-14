using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaComposicao
{
    class Cabecalho
    {
        public Guid Codigo { get; set; }
        public Cliente Cliente { get; set; }
        public Cabecalho()
        {
        }

        public Cabecalho(Guid codigo, Cliente cliente)
        {
            Codigo = codigo;
            Cliente = cliente;
        }
        public override string ToString()
        {
            StringBuilder cabecalho = new StringBuilder();
            cabecalho.AppendLine($"Número: {Codigo}");
            cabecalho.AppendLine($"Cliente: {Cliente.Nome}");
            if  (Cliente is PessoaFisica)
                 cabecalho.AppendLine($"CPF: {(Cliente as PessoaFisica).Cpf}");

            return cabecalho.ToString();

        }
    }
}
