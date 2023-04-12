using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 
namespace DesignPatterns._01___Creational
{
    using System;

    namespace Singleton.Structural
    { 

        public class Program
        {
            public static void Main(string[] args)
            {
                // Constructor is protected -- cannot use new 
                Singleton s1 = Singleton.Instance();
                Singleton s2 = Singleton.Instance(); 

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
                if (instance == null)
                {
                    instance = new Singleton();
                }

                return instance;
            }
        }
    }

}
