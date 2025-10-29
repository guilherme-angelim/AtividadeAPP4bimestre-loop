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
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiex1_Click(object sender, EventArgs e)
        {
            Hide();
            frmex1 ex1 = new frmex1();
            ex1.Show();
        }

        private void tsmsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiex2_Click(object sender, EventArgs e)
        {
            Hide();
            frmex2 ex2 = new frmex2();
            ex2.Show();
        }

        private void tsmiex3_Click(object sender, EventArgs e)
        {
            Hide();
            frmex3 ex3 = new frmex3();
            ex3.Show();
        }

        private void lbltxt_Click(object sender, EventArgs e)
        {

        }
    }
}
