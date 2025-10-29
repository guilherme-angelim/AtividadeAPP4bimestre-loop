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
    public partial class frmex2 : Form
    {
        public frmex2()
        {
            InitializeComponent();
        }

        private void btncalcularwhile_Click(object sender, EventArgs e)
        {
            int i = 10;
            double ce = 10, fh;

            while (i <= 100)
            {
                i = i + 10;
                fh = (ce * 1.8) + 32;
                ce = i + 0;
                txttemp.Text += fh + "\r\n";
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txttemp.Clear();
        }

        private void btncalculardowhile_Click(object sender, EventArgs e)
        {
            int i = 10;
            double ce = 10, fh;

            do
            {
                i = i + 10;
                fh = (ce * 1.8) + 32;
                ce = i + 0;
                txttemp.Text += fh + "\r\n";
            } while (i <= 100);
        }

        private void btncalcularfor_Click(object sender, EventArgs e)
        {
            int i;
            double ce = 10, fh;

            for (i = 10; i <= 100; i = i + 10)
            {
                ce = i + 0;
                fh = (ce * 1.8) + 32;
                txttemp.Text += fh + "\r\n";
            }
;
        }
    }
}
