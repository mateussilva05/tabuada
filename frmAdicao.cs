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
    public partial class frmAdicao : Form
    {
        public frmAdicao()
        {
            InitializeComponent();
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            if (txtNumero2.Text == "")
            {
                MessageBox.Show("Insira um número no campo 'Número' para continuar...", "Opa!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                double numero, resultado;
                numero = double.Parse(txtNumero2.Text);

                for (int i = 0; i <= 10; i++)
                {
                    resultado = numero + i;
                    txtTabuada2.Text += numero + " + " + i + " = " + resultado + "\r\n";
                }
            }
        }

        private void btnLimpar2_Click(object sender, EventArgs e)
        {
            txtTabuada2.Text = "";
            txtNumero2.Text = "";
        }
    }
}
