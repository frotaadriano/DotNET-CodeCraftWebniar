using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Motivos/Situações para utilizar o padrão Singleton:

    Quando houver a necessidade de controlar o acesso a um recurso compartilhado: 
        Um exemplo é a criação de uma classe que gerencia a conexão com um banco de dados. 
        Como a conexão é um recurso compartilhado entre diversas partes da aplicação, 
        é importante que haja apenas uma instância da classe que gerencia a conexão, 
        para que o acesso ao banco de dados seja controlado de forma consistente.

    Quando a criação de uma única instância é menos custosa do que a criação de múltiplas instâncias: 
        Um exemplo é a criação de uma classe que realiza a leitura de um grande arquivo de dados. 
        Se a instância da classe for criada toda vez que for necessário realizar uma leitura, 
        o processo pode ser muito lento. 
        Nesse caso, é mais eficiente criar uma única instância da classe e reutilizá-la em todas as leituras.

    Quando se deseja ter apenas uma instância global de uma classe que possa ser acessada de qualquer lugar da aplicação: 
        Um exemplo é a criação de uma classe que gerencia as configurações da aplicação. 
        Essa classe deve ser acessível de qualquer parte da aplicação para que as configurações 
        possam ser lidas e gravadas de forma consistente. 
        Como as configurações são um recurso compartilhado, 
        é importante que haja apenas uma instância global da classe de configurações. 

 */
namespace DesignPatterns._01___Creational
{
    using System;

    namespace Singleton.Structural
    {
        /// <summary>
        /// Singleton Design Pattern
        /// </summary>

        public class Program
        {
            public static void Main(string[] args)
            {
                // Constructor is protected -- cannot use new

                Singleton s1 = Singleton.Instance();
                Singleton s2 = Singleton.Instance();
                //Singleton s3 = new Singleton();

                // Test for same instance
                if (s1 == s2)
                {
                    Console.WriteLine("Objects are the same instance");
                }

                // Wait for user
                Console.ReadKey();
            }
        }

        /// <summary>
        /// The 'Singleton' class
        /// </summary>
        public class Singleton
        {
            static Singleton instance;

            // Constructor is 'protected' para que nao possa ser instanciado fora (linha 35)
            protected Singleton()
            {
            }

            public static Singleton Instance()
            {
                // Uses lazy initialization.
                // Note: this is not thread safe.
                /*
                "Uses lazy initialization": essa linha significa que a instância da classe Singleton será criada apenas quando 
                o método Instance() for chamado pela primeira vez.
                Isso é chamado de inicialização tardia ou "lazy initialization", o que significa que a criação da instância é 
                adiada até que seja necessária.

                "Note: this is not thread safe": essa linha significa que a implementação do padrão Singleton no exemplo não é 
                segura para uso em ambientes concorrentes, ou seja, em que várias threads podem acessar simultaneamente o método 
                Instance().Isso pode levar a problemas de sincronização e criar múltiplas instâncias da classe Singleton.
                Portanto, se houver a possibilidade de uso concorrente do Singleton, é necessário adotar uma implementação 
                segura para threads, como o uso de bloqueios ou inicialização estática.
                */

                if (instance == null)
                {
                    instance = new Singleton();
                }

                return instance;
            }
        }
    }

}
