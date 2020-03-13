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
        Conta c1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // criou a conta
            Conta c1 = new Conta();
            c1.Titular = "Maria";
            c1.Numero = 1;

            //imprimir os campos
            textoTitular.Text = c1.Titular;
            textoNumero.Text = Convert.ToString(c1.Numero);
            textoSaldo.Text = Convert.ToString(c1.Saldo);
               
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(textoValorOperacao.Text);
            c1.Depositar(valor);

            textoSaldo.Text = Convert.ToString(c1.Saldo);
        }
    }
}
