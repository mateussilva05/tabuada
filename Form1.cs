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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTabuada_Click(object sender, EventArgs e)
        {
            frmTabuada tabuada = new frmTabuada();
            tabuada.ShowDialog();

        }

        private void btnTabuadaSoma_Click(object sender, EventArgs e)
        {
            frmAdicao adicao = new frmAdicao();
            adicao.ShowDialog();
        }

        private void btnTabuadaDiv_Click(object sender, EventArgs e)
        {
            frmDivisao divisao = new frmDivisao();
            divisao.ShowDialog();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            frmSub subtracao = new frmSub();
            subtracao.ShowDialog();
        }
    }
}
