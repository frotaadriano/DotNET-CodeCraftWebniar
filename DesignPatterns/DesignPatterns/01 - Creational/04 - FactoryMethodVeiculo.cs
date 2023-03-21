using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._01___Creational
{
    public class FactoryMethodVeiculo
    {
        // Define a interface comum para todos os veículos
        // UML - [Product]
        public interface IVeiculo
        {
            void Acelerar();
        }

        // Implementa a classe Carro
        // UML - [Concrete Product]
        public class Carro : IVeiculo
        {
            public void Acelerar()
            {
                Console.WriteLine("Acelerando o carro");
            }
        }

        // Implementa a classe Moto
        // UML - [Concrete Product]
        public class Moto : IVeiculo
        {
            public void Acelerar()
            {
                Console.WriteLine("Acelerando a moto");
            }
        }

        // Define o Factory Method para criar os veículos
        // UML - [Creator]
        public class FabricaVeiculos
        {
            public static IVeiculo CriarVeiculo(string tipo)
            {
                if (tipo == "carro")
                {
                    return new Carro();
                }
                else if (tipo == "moto")
                {
                    return new Moto();
                }
                else
                {
                    throw new ArgumentException("Tipo de veículo desconhecido");
                }
            }
        }
    }
}
