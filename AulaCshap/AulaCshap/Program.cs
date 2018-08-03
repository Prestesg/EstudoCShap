using AulaCshap.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaCshap
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro car = new Carro();
            TestedeMotor(car);
        }

        static void TestedeMotor (IMotorizado vec)
        {
            Console.WriteLine("Inicio dos teste, seu carro está na velocidade" + vec.Velocidade);
            vec.Acelerar();
            vec.Acelerar();
            vec.Acelerar();
            Console.WriteLine("Seu carro está na velocidade" + vec.Velocidade);
            vec.Freiar();
            vec.Freiar();
            vec.Freiar();
            Console.WriteLine("Seu carro está na velocidade" + vec.Velocidade);
            Console.ReadKey();

        }
    }
}
