using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade.APP_4bimestre
{
    public partial class frmex3 : Form
    {
        public frmex3()
        {
            InitializeComponent();
        }

        private void btncalcularwhile_Click(object sender, EventArgs e)
        {
            int i = 1, qtd, num = 1;
            double largura, comprimento, resul, soma = 0.0;

            if (!int.TryParse(txtqtd.Text, out qtd))
            {
                MessageBox.Show("Digite um número válido de cômodos!");
                return; // sai do método para evitar erro
            }

            while (i <= qtd)
            {
                string compStr = Interaction.InputBox($"Digite o comprimento do cômodo {i}:");
                string largStr = Interaction.InputBox($"Digite a largura do cômodo {i}:");
                /*Mensagem de texto para o usuário*/

                comprimento = Convert.ToDouble(compStr);
                largura = Convert.ToDouble(largStr);

                resul = comprimento * largura;

                txtareaqtd.Text += "O cômodo número " + num + " possui a área de: " + resul + "\r\n";
                /* texto + variáveis, pulando linha a cada nova*/
                soma = soma + resul;
                i++;
                num++;
            }

            txttotal.Text = soma.ToString();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtareaqtd.Clear();
            txtqtd.Clear();
            txttotal.Clear();
            txtqtd.Focus();
        }

        private void btncalculardowhile_Click(object sender, EventArgs e)
        {
            int i = 1, qtd, num = 1;
            double largura, comprimento, resul, soma = 0.0;

            if (!int.TryParse(txtqtd.Text, out qtd))
            {
                MessageBox.Show("Digite um número válido!");
                return;
            }
            /* garante com que haja valores inteiros dentro do campo, caso contrário, não fará a operação*/
            /*Açém disso, converte a variável para int*/

            do
            {
                string compStr = Interaction.InputBox($"Digite o comprimento do cômodo {i}:");
                string largStr = Interaction.InputBox($"Digite a largura do cômodo {i}:");
                /*Mensagem de texto para o usuário*/

                comprimento = Convert.ToDouble(compStr);
                largura = Convert.ToDouble(largStr);

                resul = comprimento * largura;

                txtareaqtd.Text += "O cômodo número " + num + " possui a área de: " + resul + "\r\n";
                /* texto + variáveis, pulando linha a cada nova*/
                soma = soma + resul;
                i++;
                num++;
            } while (i <= qtd);

            txttotal.Text = soma.ToString();
        }

        private void btncalcularfor_Click(object sender, EventArgs e)
        {
            int i = 1, qtd, num = 1;
            double largura, comprimento, resul, soma = 0.0;
            if (!int.TryParse(txtqtd.Text, out qtd))
            {
                MessageBox.Show("Digite um número válido!");
                return;
            }
            /* garante com que haja valores inteiros dentro do campo, caso contrário, não fará a operação*/
            /*Açém disso, converte a variável para int*/
            for (i = 1; i <= qtd; i++)
            {
                string compStr = Interaction.InputBox($"Digite o comprimento do cômodo {i}:");
                string largStr = Interaction.InputBox($"Digite a largura do cômodo {i}:");
                /*Mensagem de texto para o usuário*/

                comprimento = Convert.ToDouble(compStr);
                largura = Convert.ToDouble(largStr);
                /*larg--- foi o local no houve a entrada da variável*/

                resul = comprimento * largura;

                txtareaqtd.Text += "O cômodo número " + num + " possui a área de: " + resul + "\r\n";
                /* texto + variáveis, pulando linha a cada nova*/
                soma = soma + resul;
                num++;
            }

            txttotal.Text = soma.ToString();
        }

        private void txtqtd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
