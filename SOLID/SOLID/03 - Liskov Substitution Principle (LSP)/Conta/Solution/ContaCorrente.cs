using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._03___Liskov_Substitution_Principle__LSP_.Conta.Solution
{
    public class ContaCorrente : ContaBancaria
    {
        private double _saldo;
        private double _limite;

        public override void Depositar(double valor)
        {
            if (valor < 50)
            {
                throw new ArgumentException("Valor inválido para depósito");
            }

            _saldo += valor;
        }

        public override void Sacar(double valor)
        {
            if (valor < 1)
            {
                throw new ArgumentException("Saldo inválido para Saque");
            }

            if (valor > _saldo + _limite)
            {
                throw new ArgumentException("Saldo e limite insuficientes");
            }

            _saldo -= valor;
        }

        public override double ObterSaldo()
        {
            return _saldo;
        }

    }
}
