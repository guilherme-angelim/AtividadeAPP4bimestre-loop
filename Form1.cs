namespace atividade.APP_4bimestre
{
    public partial class frmex1 : Form
    {
        public frmex1()
        {
            InitializeComponent();
        }

        private void btncalcularwhile_Click(object sender, EventArgs e)
        {
            int i = 1;
            double resul, num;
            num = Convert.ToDouble(txtnum.Text);
            if (num >= 10)
            {
                txtresul.Text = "Valor inválido!";
            }
            else
                while (i <= 10)
                {
                    resul = i * num;
                    i++;
                    txtresul.Text += resul + "\r\n";
                    /* BASICAMENTE, ESSA LINHA VAI APRESENTAR O RESULTADO E PULAR LINHA AO APRESENTAR CADA RESULTADO (JÁ QUE A TEXTBOX É MULTILINE)*/
                    /* += vai acumular os valores em um lugar só, no caso, todos os valores estarão na mesma textbox*/
                    /* + vai fazer com que a quebra de linha ocorra após apresentar o resultado*/
                }

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txtresul.Clear();
            txtnum.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }

        private void btncalculardowhile_Click(object sender, EventArgs e)
        {
            int i = 1;
            double resul, num;
            num = Convert.ToDouble(txtnum.Text);
            if (num >= 10)
            {
                txtresul.Text = "Valor inválido!";
            }
            else
                do
                {
                    resul = i * num;
                    i++;
                    txtresul.Text += resul + "\r\n";
                } while (i <= 10);


        }

        private void btncalcularfor_Click(object sender, EventArgs e)
        {
            int i ;
            double resul, num;
            num = Convert.ToDouble(txtnum.Text);
            if (num >= 10)
            {
                txtresul.Text = "Valor inválido!";
            }
            else
                for (i = 1; i <= 10; i++) /* valor incial; valor máximo (até onde será verdadeiro); soma após 1 loop)*/
                {
                    resul = i * num;
                    txtresul.Text += resul + "\r\n";
                }
        }
    }
}
