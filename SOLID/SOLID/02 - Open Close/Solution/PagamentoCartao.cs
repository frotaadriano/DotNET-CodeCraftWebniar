using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._02___Open_Close.Solution
{
    public class PagamentoCartao: IPagamentoStrategy
    {
        public void RealizarPagamento(decimal valor)
        {
            Console.WriteLine($"Realizando pagamento via [cartão de crédito] no valor de R$..: {valor}");
        }
    }
}
