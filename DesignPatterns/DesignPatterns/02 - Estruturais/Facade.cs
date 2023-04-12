using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._02___Estruturais
{
     
    // Classe que representa um produto
    public class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }

    // Classe que representa o carrinho de compras
    public class CarrinhoCompras
    {
        private List<Produto> _produtos = new List<Produto>();

        public void AdicionarProduto(Produto produto)
        {
            _produtos.Add(produto);
        }

        public void RemoverProduto(Produto produto)
        {
            _produtos.Remove(produto);
        }

        public decimal CalcularTotal()
        {
            return _produtos.Sum(p => p.Preco);
        }

        public void LimparCarrinho()
        {
            _produtos.Clear();
        }
    }

    // Classe que representa o processo de pagamento
    public class ProcessadorPagamento
    {
        public void ProcessarPagamento(decimal valor)
        {
            // Simula o processamento do pagamento
            Console.WriteLine($"Processando pagamento de R${valor}");
            Console.WriteLine("Pagamento aprovado!");
        }
    }



    // Classe que implementa o padrão Facade para simplificar o processo de compra
    public class LojaVirtualFacade
    {
        private CarrinhoCompras _carrinho;
        private ProcessadorPagamento _processadorPagamento;

        public LojaVirtualFacade()
        {
            _carrinho = new CarrinhoCompras();
            _processadorPagamento = new ProcessadorPagamento();
        }

        public void AdicionarProdutoAoCarrinho(Produto produto)
        {
            _carrinho.AdicionarProduto(produto);
        }

        public void RemoverProdutoDoCarrinho(Produto produto)
        {
            _carrinho.RemoverProduto(produto);
        }

        public decimal CalcularTotalCarrinho()
        {
            return _carrinho.CalcularTotal();
        }

        public void LimparCarrinho()
        {
            _carrinho.LimparCarrinho();
        }

        public void FinalizarCompra()
        {
            decimal total = CalcularTotalCarrinho();

            // Simula o processo de pagamento
            _processadorPagamento.ProcessarPagamento(total);

            // Limpa o carrinho após o processamento do pagamento
            LimparCarrinho();
        }
    }

    // Exemplo de uso da Facade para realizar uma compra
    class Program
    {
        static void Main(string[] args)
        {
            // Cria uma instância da Facade
            LojaVirtualFacade loja = new LojaVirtualFacade();

            // Adiciona alguns produtos ao carrinho
            Produto p1 = new Produto { Nome = "Camiseta", Preco = 50 };
            Produto p2 = new Produto { Nome = "Calça", Preco = 100 };
            loja.AdicionarProdutoAoCarrinho(p1);
            loja.AdicionarProdutoAoCarrinho(p2);

            // Calcula o total do carrinho
            decimal total = loja.CalcularTotalCarrinho();
            Console.WriteLine($"Total do carrinho: R${total}");

            // Finaliza a compra
            loja.FinalizarCompra();
        }
    }

}
