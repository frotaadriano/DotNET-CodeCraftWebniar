using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._02___Open_Close.Solution
{
    public interface IPagamentoStrategy
    {
        public void RealizarPagamento(decimal valor);
    }
}
