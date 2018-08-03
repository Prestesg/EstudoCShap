using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaCshap.Model
{
    class Moto : Veiculo, IMotorizado
    {
        public int Velocidade { get ; set ; }

        public void Acelerar()
        {
            Console.WriteLine("Girando o Guidão..");
            Velocidade += 5;
        }

        public void Freiar()
        {
            Console.WriteLine("Apertando o freio...");
            Velocidade -= 5;
        }
    }
}
