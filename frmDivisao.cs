using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabuada
{
    public partial class frmDivisao : Form
    {
        public frmDivisao()
        {
            InitializeComponent();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (txtNumero3.Text == "")
            {
                MessageBox.Show("Insira um número no campo 'Número' para continuar...", "Opa!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                double numero, resultado;
                numero = double.Parse(txtNumero3.Text);

                for (int i = 0; i <= 10; i++)
                {
                    resultado = numero / i;
                    txtTabuada3.Text += numero + " / " + i + " = " + resultado + "\r\n";
                }
            }
        }

        private void btnLimpar3_Click(object sender, EventArgs e)
        {
            txtTabuada3.Text = "";
            txtNumero3.Text = "";
        }
    }
}
