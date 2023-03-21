using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._01___Creational
{
    /*
     * A seguir, alguns exemplos de situações em que o padrão Factory Method pode ser aplicado:

    Classes que precisam ser instanciadas de forma condicional:
        Suponha que estamos criando um jogo que possui diferentes personagens. 
        Cada personagem tem sua própria classe, mas todas implementam a mesma interface. 
        Para instanciar o personagem correto de acordo com as escolhas do jogador, podemos usar um Factory Method que 
        recebe um parâmetro indicando qual classe deve ser instanciada.

    Classes que precisam ser instanciadas de forma dinâmica:
        Em algumas situações, precisamos criar objetos de classes que só conhecemos em tempo de execução. 
        Por exemplo, em um sistema de plugins, podemos ter diferentes plugins que estendem uma interface comum. 
        Para carregar o plugin correto em tempo de execução, podemos usar um Factory Method que recebe o nome da classe do 
        plugin como parâmetro.

    Classes que precisam de uma configuração complexa:
        Algumas classes possuem um processo de construção complexo, com diversas etapas que precisam ser executadas na ordem correta. 
        Para evitar que o código fique confuso, podemos encapsular o processo de criação em um Factory Method, que executa as etapas 
        necessárias e retorna o objeto já configurado.

    Classes que precisam ser instanciadas de forma eficiente:
        Em alguns casos, criar objetos de uma determinada classe pode ser uma operação cara em termos de desempenho. 
        Para evitar que o código crie instâncias desnecessárias, podemos usar um Factory Method que mantém uma cache de objetos já 
        criados e reutiliza esses objetos quando necessário.



     * 
    Nesse exemplo, temos uma interface IAnimal que define a operação MakeSound. 
    Em seguida, temos duas classes que implementam essa interface, Cat e Dog.

    Temos também uma interface IAnimalFactory que define o método CreateAnimal, que retorna um objeto IAnimal. 

    Em seguida, temos uma classe RandomAnimalFactory que implementa essa interface e gera um número aleatório para escolher qual objeto IAnimal criar.

    No método Main, criamos uma instância da fábrica RandomAnimalFactory e, em seguida, chamamos o método CreateAnimal várias vezes para criar objetos IAnimal aleatórios. O método MakeSound é chamado em cada objeto para fazer com que ele emita um som.

    Observe que, se desejássemos criar animais diferentes ou implementar uma lógica de criação diferente, poderíamos simplesmente criar uma nova classe que implementasse a interface IAnimalFactory e escrevesse seu próprio método CreateAnimal. Isso permitiria que nosso código fosse facilmente estendido sem ter que modificar a lógica de criação de objetos em

 */


    // Temos uma interface IAnimal que define a operação MakeSound. 
    // Definição da interface do produto
    // UML - [Product]
    public interface IAnimal
    {
        void MakeSound();
    }

    // Em seguida, temos duas classes que implementam essa interface, Cat e Dog.
    // Implementação de dois produtos concretos
    // UML - [Concrete Product]
    public class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }
    public class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }


    // Temos também uma interface IAnimalFactory que define o método CreateAnimal, que retorna um objeto IAnimal.
    // Definição da interface da fábrica
    // UML - [Creator]
    public interface IAnimalFactory
    {
        IAnimal CreateAnimal();
    }

    // Em seguida, temos uma classe RandomAnimalFactory que implementa essa interface e
    // gera um número aleatório para escolher qual objeto IAnimal criar.

    // Implementação da fábrica concreta
    // UML - [Concrete Creator]
    public class RandomAnimalFactory : IAnimalFactory
    {
        private static Random random = new Random();

        public IAnimal CreateAnimal()
        {
            // Gera um número aleatório para escolher qual produto criar
            int randomNumber = random.Next(0, 2);

            // Retorna uma instância do produto escolhido
            switch (randomNumber)
            {
                case 0:
                    return new Cat();
                case 1:
                    return new Dog();
                default:
                    throw new Exception("Unexpected random number generated.");
            }
        }
    }

    /*
     Na implementação do padrão Factory Method apresentada acima, podemos identificar os seguintes elementos:
     Product: é a interface IAnimal, que define a interface comum para todos os produtos (animais) criados pela fábrica.
     Concrete Product: são as classes concretas Cat e Dog, que implementam a interface IAnimal e representam os produtos específicos criados pela fábrica.
     Creator: é a interface IAnimalFactory, que define a interface para a criação dos produtos (animais).
     Concrete Creator: é a classe RandomAnimalFactory, que implementa a interface IAnimalFactory e cria os produtos (animais) de forma aleatória.
     Em resumo, o Factory Method é utilizado para criar objetos de diferentes tipos, sem a necessidade de conhecermos sua implementação concreta, permitindo assim maior flexibilidade e extensibilidade no código. Na implementação apresentada, a fábrica é capaz de criar diferentes tipos de animais de forma aleatória, utilizando a interface IAnimal como um contrato para todos os produtos que serão criados.
     */
}
