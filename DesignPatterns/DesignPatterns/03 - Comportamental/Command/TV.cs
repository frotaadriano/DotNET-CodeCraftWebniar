using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._03___Comportamental.Command
{
    // Implementa a classe que representa a TV
    public class TV
    {
        private bool isOn = false;
        private int currentChannel = 1;

        public void TurnOn()
        {
            isOn = true;
            Console.WriteLine("TV is turned on");
        }

        public void TurnOff()
        {
            isOn = false;
            Console.WriteLine("TV is turned off");
        }

        public void ChangeChannel(int channel)
        {
            if (isOn)
            {
                currentChannel = channel;
                Console.WriteLine("TV channel changed to " + channel);
            }
            else
            {
                Console.WriteLine("TV is off. Cannot change channel.");
            }
        }
    }
}
