using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaCshap.Model
{
    interface IMotorizado
    {
        int Velocidade { get; set; }
        void Acelerar();
        void Freiar();
    }
}
