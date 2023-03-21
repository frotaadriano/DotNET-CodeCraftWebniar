using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._03___Liskov_Substitution_Principle__LSP_.Violation
{
    public class ContaBancaria
    {
        // ContaPoupanca e ContaCorrente restringem a pré-condição do parâmetro valor no
        // método Depositar e Sacar e, em nosso exemplo a Classe ContaBancaria não o faz

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
