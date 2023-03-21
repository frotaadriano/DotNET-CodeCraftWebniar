using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._03___Liskov_Substitution_Principle__LSP_.Violation
{
    public class ContaCorrente: ContaBancaria
    {
        
        public override void Depositar(double valor)
        {
            if (valor < 50)
            {
                throw new ArgumentException("Valor inválido para depósito");
            }

            base.Depositar(valor);
        }

        public override void Sacar(double valor)
        {
            if (valor < 1)
            {
                throw new ArgumentException("Saldo inválido para Saque");
            }

            if (valor > Saldo + Limite)
            {
                throw new ArgumentException("Saldo e limite insuficientes");
            }

            base.Sacar(valor);
        }

        public double Saldo { get; set; }
        public double Limite { get; set; }
    }
}
