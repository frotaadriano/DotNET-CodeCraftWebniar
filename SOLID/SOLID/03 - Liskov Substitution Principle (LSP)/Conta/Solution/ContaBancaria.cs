using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._03___Liskov_Substitution_Principle__LSP_.Conta.Solution
{
    
    public abstract class ContaBancaria
    {
        public abstract void Depositar(double valor);
        public abstract void Sacar(double valor);
        public abstract double ObterSaldo();
    }
}
