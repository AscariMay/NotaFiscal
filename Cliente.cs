using System;
using System.Collections.Generic;
using System.Text;


namespace HerancaComposicao
{
    public class Cliente
    {
        public string Nome { get; set; }

        public Cliente()
        {
        }

        public Cliente(string nome)
        {
            Nome = nome;
        }
    }
}
