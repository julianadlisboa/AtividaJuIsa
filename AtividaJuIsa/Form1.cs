using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividaJuIsa
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

        private void combustvelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm2 fm = new frm2();
            fm.Show();
        }

        private void algoritmosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabuadaWhileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm4 fm = new Frm4();
            fm.Show();
        }

        private void tabuadaDoWhileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm5 fm = new Frm5();
            fm.Show();
        }

        private void eleiçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm3 fm = new Frm3();
            fm.Show();
        }

        private void tabuadaForToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm6 fm = new Frm6();
            fm.Show();
        }
    }
}
