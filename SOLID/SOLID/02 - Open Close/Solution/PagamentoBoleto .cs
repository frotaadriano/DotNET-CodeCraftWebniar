using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._02___Open_Close.Solution
{
    public class PagamentoBoleto: IPagamentoStrategy
    {
        public void RealizarPagamento(decimal valor)
        {
            Console.WriteLine($"Realizando pagamento via [boleto] no valor de R$...: {valor}");
        }
    }
}
