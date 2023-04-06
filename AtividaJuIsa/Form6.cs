using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividaJuIsa
{
    public partial class Frm6 : Form
    {
        public Frm6()
        {
            InitializeComponent();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txtresult.Clear();
            txtnum.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu menu = new frmmenu();
            menu.Show(this);
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int i, num, result;
            num=Convert.ToInt32(txtnum.Text);

            for (i=0; i<=10; i++) 
            {
                result = num * i;
                txtresult.Text= String.Concat(txtresult.Text, "\r\n", result.ToString());
            
            }
        }
    }
}
