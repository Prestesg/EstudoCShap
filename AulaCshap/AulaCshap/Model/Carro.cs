using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaCshap.Model
{
    class Carro : Veiculo, IMotorizado
    {
        public int Velocidade { get; set; }
        public void Acelerar()
        {
            Console.WriteLine("Pisando no pedal...");
            Velocidade += 5;
        }

        public void Freiar()
        {
            Console.WriteLine("Pisando no pedal(freio)...");
            Velocidade -= 5;
        }
    }

}
