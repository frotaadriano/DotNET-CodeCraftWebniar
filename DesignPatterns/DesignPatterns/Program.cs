
#region Creational - Singleton
// Obter a instância única do contador
//using DesignPatterns._01___Creational;
//Counter primeiroContador = Counter.Instance();
//// Incrementar o contador algumas vezes
//primeiroContador.Increment();
//primeiroContador.Increment();
//primeiroContador.Increment();

//// Imprimir o valor atual do contador
//Console.WriteLine("[1] - primeiroContador: " + primeiroContador.GetCount()); // Saída: Contador: 3

//// Decrementar o contador e imprimir o novo valor
//primeiroContador.Decrement();
//Console.WriteLine("[2] - primeiroContador: " + primeiroContador.GetCount()); // Saída: Contador: 2

//Counter segundoContador = Counter.Instance();
//Console.WriteLine("[3] - segundoContador valor:" + primeiroContador.GetCount());
//primeiroContador.Increment();
//Console.WriteLine("[4] - segundoContador: " + primeiroContador.GetCount());
//Console.WriteLine("[5] - segundoContador: " + primeiroContador.GetCount());
#endregion

//#region Creational - Factory Method  
using DesignPatterns._01___Creational;
using DesignPatterns._02___Estruturais;
using DesignPatterns._03___Comportamental.Command;
using static DesignPatterns._01___Creational.FactoryMethodVeiculo;

////==================================//
////             Factory 1 
////==================================//

//// Cria uma fábrica de animais aleatórios  
//IAnimalFactory animalFactory = new RandomAnimalFactory();

//// Cria vários animais usando a fábrica
//for (int i = 0; i < 10; i++)
//{
//    IAnimal animal = animalFactory.CreateAnimal();
//    animal.MakeSound();
//}

////==================================//
////             Factory 2 
////==================================//
//// Testa a criação de diferentes veículos
//IVeiculo veiculo1 = FabricaVeiculos.CriarVeiculo("carro");
//  veiculo1.Acelerar();


/*
    === explicção importante sobre o Factory method ===
    O padrão Factory Method é útil em situações em que precisamos criar objetos de diferentes classes que compartilham uma interface comum, 
    sem precisar conhecer a implementação específica de cada uma delas. 
    O objetivo é criar um método que é responsável por instanciar objetos, ao invés de criar esses objetos diretamente em outros lugares do código.

    A seguir, alguns exemplos de situações em que o padrão Factory Method pode ser aplicado:

    Classes que precisam ser instanciadas de forma condicional:
    Suponha que estamos criando um jogo que possui diferentes personagens. 
    Cada personagem tem sua própria classe, mas todas implementam a mesma interface. 
    Para instanciar o personagem correto de acordo com as escolhas do jogador, podemos usar um Factory Method 
    que recebe um parâmetro indicando qual classe deve ser instanciada.


    Classes que precisam ser instanciadas de forma dinâmica:
    Em algumas situações, precisamos criar objetos de classes que só conhecemos em tempo de execução. 
    Por exemplo, em um sistema de plugins, podemos ter diferentes plugins que estendem uma interface comum. 
    Para carregar o plugin correto em tempo de execução, podemos usar um Factory Method que recebe 
    o nome da classe do plugin como parâmetro.

    Classes que precisam de uma configuração complexa:
    Algumas classes possuem um processo de construção complexo, com diversas etapas que precisam ser executadas na ordem correta. 
    Para evitar que o código fique confuso, podemos encapsular o processo de criação em um Factory Method, 
    que executa as etapas necessárias e retorna o objeto já configurado.

    Classes que precisam ser instanciadas de forma eficiente:
    Em alguns casos, criar objetos de uma determinada classe pode ser uma operação cara em termos de desempenho. 
    Para evitar que o código crie instâncias desnecessárias, podemos usar um Factory Method que mantém uma cache de objetos já criados 
    e reutiliza esses objetos quando necessário.

    Em todos esses casos, o Factory Method oferece uma forma flexível e fácil de criar objetos, sem que precisemos conhecer detalhes da 
    implementação de cada classe. 
    Além disso, o uso de um método para criar objetos torna o código mais modular e fácil de manter. 
  
 */

//#endregion

#region Estrutural - Adapter
// Cria o serviço que fornece informações sobre o tempo
ITempo servicoTempo = new ServicoTempo();

// Cria o adaptador que adapta a interface do serviço de tempo para a interface de clima
IClima adaptadorTempo = new AdaptadorTempo(servicoTempo);

// Cria o cliente que espera receber informações sobre o clima
Cliente cliente = new Cliente(adaptadorTempo);

// Exibe as informações sobre o clima para o cliente
cliente.ExibirClima();
#endregion

#region Comportamental - Command
// Cria a TV e o controle remoto
TV tv = new TV();
RemoteControl control = new RemoteControl();

// Define os comandos
ICommand turnOnCommand = new TurnOnCommand(tv);
ICommand turnOffCommand = new TurnOffCommand(tv);
ICommand changeChannelCommand = new ChangeChannelCommand(tv, 5);

// Associa os comandos aos botões do controle remoto
control.SetCommand(turnOnCommand);
control.PressButton();

control.SetCommand(changeChannelCommand);
control.PressButton();

control.SetCommand(turnOffCommand);
control.PressButton();

/*
interface acessos 
    
interface acoes
    
*/
// pessoa : acessos, acoes

// carro  : geral
#endregion


