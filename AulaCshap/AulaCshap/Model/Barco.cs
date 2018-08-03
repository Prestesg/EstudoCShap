using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaCshap.Model
{
    class Barco : Veiculo, IMotorizado
    {
        public int Velocidade { get; set; }
        public void Acelerar()
        {
            Console.WriteLine("Afundando o mancho...");
            Velocidade += 5;
        }

        public void Freiar()
        {
            Console.WriteLine("Reduzindo o mancho..");
            Velocidade += 5;
        }
    }
}
