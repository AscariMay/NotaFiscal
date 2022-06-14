using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaComposicao
{
    class NotaFiscal
    {
        public Cabecalho Cabecalho { get; set; }
        public List<Produto> Produtos { get; set; }
        public Rodape Rodape { get; set; }


        public void Imprimir()
        {
            Console.WriteLine("");
            Console.WriteLine("**************************** NOTA FISCAL DE SAIDA ********************************");
            Console.WriteLine("");
            Console.WriteLine(Cabecalho);
            Console.WriteLine("");
            Console.WriteLine($"Produto\t\t\tQuantidade \t Preço");
            foreach (Produto list in Produtos)
            {
                Console.WriteLine($"{list.Nome} \t\t   {list.Quantidade}\t\t{list.Preco:C2}");
            }
                Console.WriteLine("");
                Console.WriteLine(Rodape);
                Console.WriteLine("");
                Console.WriteLine("*********************************************************************************");    
        }

    }
}
