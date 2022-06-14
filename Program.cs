using System;
using System.Collections.Generic;
using System.Globalization;

namespace HerancaComposicao
{
    public class Program
    {

        static void Main(string[] args)
        {

            Cliente cliente = new PessoaFisica() { Nome = "Mayara Ascari", Cpf = "123.456.789-x" };
            Cliente clienteCnpj = new PessoaJuridica() { Nome = "IBM", Cnpj = "11.222.333/0001-x" };
            Cabecalho cabecalho = new Cabecalho() { Codigo = Guid.NewGuid(), Cliente = cliente };
            new Cabecalho() { Codigo = Guid.NewGuid(), Cliente = clienteCnpj };

            List<Produto> produtos = new List<Produto>()
                {
                    new Produto() {Nome = "Notethinkpad",Preco = 10000, Quantidade = 2},
                    new Produto() {Nome = "Mouse Logitech",Preco = 125, Quantidade = 4},
                    new Produto() {Nome = "Teclado LG",Preco = 150, Quantidade = 10},
                };
            decimal valorTotal = 0;
            foreach (Produto list in produtos)
                valorTotal += list.Quantidade * list.Preco;

            Rodape rodape = new Rodape() { ValorTotal = valorTotal };
            NotaFiscal notaFiscal = new NotaFiscal() { Cabecalho = cabecalho, Produtos = produtos, Rodape = rodape };


            notaFiscal.Imprimir();
        }
    }
}

