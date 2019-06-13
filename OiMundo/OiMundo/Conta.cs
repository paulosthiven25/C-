using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OiMundo
{
    class Conta
    {
        private double saldo { get; set; }
        private int numero { get; set; }
        private Cliente titular { get; set; }



        public void saca(double valor){
            
                this.saldo -= valor;
               
        }


        public void deposita(double valor) {
            this.saldo += valor;
        }


        public void Transfere(double valor,Conta destino)
        {
            this.saca(valor);
             destino.deposita(valor);
            }
           
        }

    }
}
