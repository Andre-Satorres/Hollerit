using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FolhaPagamento
{

    public partial class frmHollerit : Form
    {
        public frmHollerit()
        {
            InitializeComponent();
        }

        protected localhost.Service servico = new localhost.Service();

        private bool validarCpf(String s)
        {
            int sum = 0;
            int j=0;
            for (int i = 10; i > 1; i--)
            {
                sum += i * Convert.ToInt16(s[j] + "");
                j++;
            }

            int r = (sum * 10) % 11;

            if (r == 10)
                r = 0;

            if (r != Convert.ToInt16(s[9] + ""))
                return false;

            sum = 0;
            j = 0;
            for (int i = 11; i > 1; i--)
            {
                sum += i * Convert.ToInt16(s[j] + "");
                j++;
            }

            r = (sum * 10) % 11;

            if (r == 10)
                r = 0;

            if (r != Convert.ToInt16(s[10] + ""))
                return false;

            return true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            String cpf = txtCPF.Text.Substring(0, 3) + txtCPF.Text.Substring(4, 3) + txtCPF.Text.Substring(8, 3) + txtCPF.Text.Substring(12, 2);
            if (!validarCpf(cpf))
            {
                MessageBox.Show("CPF inválido!");
                return;
            }

            double salario = Convert.ToDouble(txtSal.Value);
            double fgts = servico.calcularFGTS(salario);
            double inss = servico.calcularINSS(salario);

            salario -= inss;
            salario -= servico.descontaDependentes(Convert.ToInt16(txtDep.Value));

            double ir = servico.calcularIR(salario);

            double salLiq = Convert.ToDouble(txtSal.Value) - ir -inss;
            this.escreva(inss, ir, fgts, salLiq);
        }

        private void escreva(double inss, double ir, double fgts, double salarioLiq)
        {
            this.txtInfos.Text = "Salário Bruto:   R$ " + txtSal.Value + "\r\n"
                               + "INSS:            R$ " + Math.Round(inss, 2).ToString("0.00")    + "\r\n"
                               + "Imp. Renda:      R$ " + Math.Round(ir, 2).ToString("0.00")      + "\r\n"
                               + "FGTS:            R$ " + Math.Round(fgts, 2).ToString("0.00")    + "\r\n"
                               + "Salário Líquido: R$ " + Math.Round(salarioLiq, 2).ToString("0.00");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCPF.Clear();
            txtDep.Value = 0;
            txtSal.Value = 0;
            txtInfos.Text = "";
        }
    }
}
