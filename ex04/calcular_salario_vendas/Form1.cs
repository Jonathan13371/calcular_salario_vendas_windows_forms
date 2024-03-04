using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex04
{
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void bntSalario_Click(object sender, EventArgs e)
        {
            string nome;

            double salario, subTotal,total, totalVendas;
            

            nome = textNome.Text;
            salario = Convert.ToDouble(textSalarioFixo.Text);
            totalVendas = Convert.ToDouble(textTotalVendas.Text);

            total = salario + (totalVendas * 15/100);

            lblSaida.Text = nome + " Vendeu" + totalVendas + " reais Vendas no Mês, seu salario final é " + total + " Reias";
        }
    }
}
