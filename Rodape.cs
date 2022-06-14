using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaComposicao
{
    class Rodape : NotaFiscal
    {
        public decimal ValorTotal { get; set; }

        public Rodape()
        {
        }

        public override string ToString()
        {
           return $"VALOR TOTAL: {ValorTotal:C2}";
        }
    }
}
