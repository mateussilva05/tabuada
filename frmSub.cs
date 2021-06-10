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
    public partial class frmSub : Form
    {
        public frmSub()
        {
            InitializeComponent();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (txtNumero4.Text == "")
            {
                MessageBox.Show("Insira um número no campo 'Número' para continuar...", "Opa!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                double numero, resultado;
                numero = double.Parse(txtNumero4.Text);

                for (int i = 0; i <= 10; i ++)
                {
                    resultado = numero - i;
                    txtTabuada4.Text += numero + " - " + i + " = " + resultado + "\r\n";
                }
            }
        }

        private void btnLimpar4_Click(object sender, EventArgs e)
        {
            txtTabuada4.Text = "";
            txtNumero4.Text = "";
        }
    }
}
