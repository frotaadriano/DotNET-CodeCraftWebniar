using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._03___Comportamental.Command
{
    // Implementa a classe que representa o comando de mudar de canal
    public class ChangeChannelCommand : ICommand
    {
        private TV tv;
        private int channel;

        public ChangeChannelCommand(TV tv, int channel)
        {
            this.tv = tv;
            this.channel = channel;
        }

        public void Execute()
        {
            tv.ChangeChannel(channel);
        }
    }
}
