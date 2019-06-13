using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OiMundo
{
    class Cliente{
        public string nome;
        public string cpf;
        public string rg;
        public string endereco;
        public int idade;


        public Cliente (string nome)
        {
            this.nome = nome;
        }

        public Cliente(string nome,int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }
    }
}
