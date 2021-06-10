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
    public partial class frmTabuada : Form
    {
        public frmTabuada()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text == "") //se o txtNumero estiver vazio...                       
            {
                MessageBox.Show("Insira um número no campo 'Número' para continuar...", "Opa!", //Uma caixa de mensagem será exibida
                                MessageBoxButtons.OK, MessageBoxIcon.Warning); //para declarar um MessageBox, 1º Informamos sua mensagem, em seguida seu título e por fim seus botões e ícone
            }
            else
            {
                double numero, resultado; //declarando varáveis do tipo double
                numero = double.Parse(txtNumero.Text); //convertendo o numero digitado na txtNumero em texto

                for (int i = 0; i <= 10; i++)/*Laço de repetição For onde o int i é igual a 0,
                        i será repetido 10 vezes e a cada repetição receberá +1 em seu valor*/
                {
                    resultado = numero * i; //cálculo onde o número digitado pelo usuário é multiplicado por i
                    txtTabuada.Text += numero + " x " + i + " = " + resultado + "\r\n"; // os resultados são exibidos na txtTabuada
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e) //ao clicar no botão Limpar...
        {
            txtTabuada.Text = ""; //o texto de txtTabuada é apagado
            txtNumero.Text = ""; // o texto de txtNumero é apagado
        }
    }
}
