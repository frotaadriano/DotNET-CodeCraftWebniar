using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._03___Comportamental.Command
{
    // Implementa a classe que representa o comando de ligar a TV
    public class TurnOnCommand : ICommand
    {
        private TV tv;

        public TurnOnCommand(TV tv)
        {
            this.tv = tv;
        }

        public void Execute()
        {
            tv.TurnOn();
        }
    }
}
