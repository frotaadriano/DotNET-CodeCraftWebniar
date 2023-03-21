using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._02___Estruturais
{
    // Define a interface esperada pelo cliente
    interface IClima
    {
        void ExibirTemperatura();
    }

    // Define a interface da classe que fornece informações sobre o tempo
    interface ITempo
    {
        int ObterTemperatura();
    }

    // Implementa a classe que fornece informações sobre o tempo
    class ServicoTempo : ITempo
    {
        public int ObterTemperatura()
        {
            return 25;
        }
    }

    // Implementa o Adapter para adaptar a interface da classe ServicoTempo para a interface IClima
    class AdaptadorTempo : IClima
    {
        private ITempo _servicoTempo;

        public AdaptadorTempo(ITempo servicoTempo)
        {
            _servicoTempo = servicoTempo;
        }

        public void ExibirTemperatura()
        {
            int temperatura = _servicoTempo.ObterTemperatura();
            Console.WriteLine("A temperatura atual é: " + temperatura);
        }
    }

    // Cliente que espera receber informações sobre o clima
    class Cliente
    {
        private IClima _clima;

        public Cliente(IClima clima)
        {
            _clima = clima;
        }

        public void ExibirClima()
        {
            _clima.ExibirTemperatura();
        }
    } 
    

}
