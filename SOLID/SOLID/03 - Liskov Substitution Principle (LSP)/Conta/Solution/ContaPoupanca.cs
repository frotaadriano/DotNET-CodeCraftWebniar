using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._03___Liskov_Substitution_Principle__LSP_.Conta.Solution
{
    public class ContaPoupanca: ContaBancaria
    {
        private double _saldo;
        
        public override void Depositar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para depósito");
            }

            _saldo += valor;
        }

        public override void Sacar(double valor)
        {
            if (valor > _saldo)
            {
                throw new ArgumentException("Saldo insuficiente");
            }

            _saldo -= valor;
        }

        public override double ObterSaldo()
        {
            return _saldo;
        }

    }
}
