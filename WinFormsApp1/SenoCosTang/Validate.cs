using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.SenoCosTang
{
    public class Validate:Props
    {
        public Validate(string numero )
        {
            this.numero = numero;
        }
        public override void Executar()
        {
            try
            {
                 this.valor= Convert.ToDouble(numero);
            }
            catch
            {
                this.mensagem = "Erro";
            }
        }
    }
}
