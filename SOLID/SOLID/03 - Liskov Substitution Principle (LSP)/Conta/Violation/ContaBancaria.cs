using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._03___Liskov_Substitution_Principle__LSP_.Violation
{
    public class ContaBancaria
    {
        //TODO: 3 Liskov
        public virtual void Depositar(double valor)
        {
            // código para depositar o valor na conta
        }

        public virtual void Sacar(double valor)
        {
            // código para sacar o valor da conta
        }
    }
}
