using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._03___Liskov_Substitution_Principle__LSP_.Conta.Solution
{
    /*
     Solução 1: Colocar essa validação na classe base ContaBancaria

     public class ContaBancaria
     { 
       if (valor< 0)
       {
          throw new ArgumentException("Valor inválido para depósito");
       } 
     }  
    */

    /*
     Solução 2: 
        A solução consiste em transformar a classe ContaBancaria em uma classe abstrata, 
        que define apenas as assinaturas dos métodos, sem implementá-los. 
        
        As classes ContaPoupanca e ContaCorrente agora implementam esses métodos de forma independente, 
        sem depender da implementação da classe base.

        Além disso, adicionamos um método ObterSaldo() para permitir que outras classes possam obter o saldo da 
        conta sem ter acesso direto à propriedade Saldo. 

        Isso também torna mais fácil adicionar outras implementações de ContaBancaria no futuro, 
        sem alterar a interface pública da classe.

        [abstract]:
        Classes Abstratas:
            - Uma classe abstrata é uma classe que não pode ser instanciada. 
                Você não pode criar um objeto a partir de uma classe abstrata.
            - Uma classe abstrata pode ser herdada e geralmente serve como classe base para outras classes.
            - Uma classe abstrata pode conter métodos abstratos e métodos comuns. Uma classe abstrata também podem 
                possuir construtores, propriedades, indexadores e eventos.
            - Uma classe abstrata não pode ser estática (static). Uma classe abstrata não pode ser selada (sealed).
            - Uma classe abstrata pode herdar de outra classe abstrata.
     */
    public abstract class ContaBancaria
    {
        public abstract void Depositar(double valor);
        public abstract void Sacar(double valor);
        public abstract double ObterSaldo();
    }
}
