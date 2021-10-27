using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.SenoCosTang
{
    public class Calculo:Props
    {
        public Calculo(double n1)
        {
            this.valor = n1;
        }
        public override void Executar()
        {
            seno = Math.Sin(valor);
            cons = Math.Cos(valor);
            tang = Math.Tan(valor);
        }
    }
}
