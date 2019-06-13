using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OiMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta victor = new Conta();
            // inicialização da conta
            victor.saldo = 1000;

            Conta guilherme = new Conta();
            // inicialização da conta

            // Agora vamos transferir o dinheiro da conta do victor para a do guilherme
            victor.Transfere(10.0,guilherme);

            MessageBox.Show("" + victor.saldo + "\n" + guilherme.saldo);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente("Victor Harada")
            {
                // bloco de inicialização
               cpf = "123.456.789-01",
                rg = "21.345.987-x",
                idade = 25
            };
        }
    }
}
