using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaComposicao
{
    public class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }


        public Produto()
        {
        }
        public Produto(string nome, decimal preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
    }
}
