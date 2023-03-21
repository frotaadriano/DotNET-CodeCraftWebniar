using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._02___Open_Close.Solution
{
    public class PagamentoTransferencia: IPagamentoStrategy
    {
        public void RealizarPagamento(decimal valor)
        {
            var iof = (double)valor * 0.0638;
            var valorLiquido = (double)valor - iof;
            Console.WriteLine($"Realizando pagamento via [transferência bancária] no valor liquido de R$...:{valorLiquido} e com taxa de iof de R$...: {iof} ");
        }
    }
}
