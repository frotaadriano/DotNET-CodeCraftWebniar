using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._02___Open_Close.Solution
{
    public class Pagamento
    {
        public decimal Valor { get; set; }
        private readonly IPagamentoStrategy _pagamentoStrategy;

        public Pagamento(IPagamentoStrategy pagamentoStrategy)
        {
            _pagamentoStrategy = pagamentoStrategy;
        }

        public void RealizarPagamento()
        {
            _pagamentoStrategy.RealizarPagamento(Valor);
        }
    }
}
