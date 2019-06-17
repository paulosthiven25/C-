using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        private Conta c;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
       {
            this.c = new Conta();
            Conta c = new Conta();
            c.Numero = 1;
            Cliente c1 = new Cliente("Pedro");
            c.Titular = c1;

            txtTitular.Text = c.Titular.Nome;
            txtSaldo.Text = Convert.ToString(c.Saldo);
            txtNumero.Text = Convert.ToString(c.Numero);


        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            string valorDigitado = txtValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            c.Deposita(valorOperacao);
            txtSaldo.Text = Convert.ToString(this.c.Saldo);
            MessageBox.Show("Deu bom");
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            string valorDigitado = txtValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            c.Saca(valorOperacao);
            txtSaldo.Text = Convert.ToString(this.c.Saldo);
            MessageBox.Show("Deu bom");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
