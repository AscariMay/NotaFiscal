using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaComposicao
{
    class PessoaFisica : Cliente
    {
        public string Cpf { get; set; }

        public PessoaFisica()
        {
        }
        public PessoaFisica(string cpf)
        {
            Cpf = cpf;
        }
    }
}
