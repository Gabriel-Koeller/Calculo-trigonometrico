using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.SenoCosTang
{
    public class Controller : Props
    {
        public  Controller(string numero)
        {
            this.numero = numero;
        }


        public override void Executar()
        {

            Validate val = new Validate(this.numero);
            val.Executar();
            this.mensagem = val.mensagem;
            this.valor = val.valor;

            if (mensagem != "erro")
            {
                Calculo cal = new Calculo(this.valor);
                cal.Executar();

                this.seno = cal.seno;
                this.cons = cal.cons;
                this.tang = cal.tang;
            }

             
        }

    }
}
