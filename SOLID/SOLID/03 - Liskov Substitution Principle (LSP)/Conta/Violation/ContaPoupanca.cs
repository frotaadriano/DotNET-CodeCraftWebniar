using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._03___Liskov_Substitution_Principle__LSP_.Violation
{
    public class ContaPoupanca: ContaBancaria
    {
        public override void Depositar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para depósito");
            }

            base.Depositar(valor);
        }

        public override void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                throw new ArgumentException("Saldo insuficiente");
            }

            base.Sacar(valor);
        }

        public double Saldo { get; set; }
    }
}
