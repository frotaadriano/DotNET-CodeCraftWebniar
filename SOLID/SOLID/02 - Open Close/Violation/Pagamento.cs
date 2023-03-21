using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._02___Open_Close.Violation
{
    public  class Pagamento
    {
        public decimal Valor { get; set; }
        public string Tipo { get; set; }

        public void RealizarPagamento()
        {
            if (Tipo == "boleto")
            {
                // realiza pagamento via boleto
            }
            else if (Tipo == "cartao")
            {
                // realiza pagamento via cartão de crédito
            }
        }
    }
}
