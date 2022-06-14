using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaComposicao
{
    class PessoaJuridica : Cliente
    {
        public string Cnpj { get; set; }

        public PessoaJuridica()
        {
        }
        public PessoaJuridica(string cnpj)
        {
            Cnpj = cnpj;
        }
    }
}
