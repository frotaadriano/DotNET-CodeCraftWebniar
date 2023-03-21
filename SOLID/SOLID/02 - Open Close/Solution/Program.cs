using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._02___Open_Close.Solution
{
    public class Program
    {
        static void Main(string[] args)
        { 

            //Boleto
            var pagamentoBoleto = new Pagamento(new PagamentoBoleto());
            pagamentoBoleto.Valor = 50.00m;
            pagamentoBoleto.RealizarPagamento();

            //Cartao
            var pagamentoCartao = new Pagamento(new PagamentoCartao());
            pagamentoCartao.Valor = 75.00m;
            pagamentoCartao.RealizarPagamento();

            //Transferencia
            var pagamentoTransferencia = new Pagamento(new PagamentoTransferencia())
            {
                Valor = 100.00m
            };
            pagamentoTransferencia.RealizarPagamento();

            Console.ReadKey();
        }
    }
}
