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
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }


        private void btncalcular_Click(object sender, EventArgs e)
        {
            char 
                comb=Convert.ToChar(txtcomb.Text);
            double litro, valor;
            litro=Convert.ToDouble(txtlitro.Text);

            if (comb == 'A')
            {
                if (litro <= 20)
                {
                    valor = (litro / 4.90) * 3 / 100;
                    txtvalor.Text = "$" + valor;
                }
                else
                {
                    valor = (litro / 4.90) * 5 / 100;
                    txtvalor.Text = "$" + valor;
                }
            }

            else
                    if (comb == 'G')
            {
                if (litro <= 20)
                {
                    valor = (litro / 5.50) * 4 / 100;
                    txtvalor.Text = "$" + valor;
                }
                else
                {
                    valor = (litro / 5.50) * 6 / 100;
                    txtvalor.Text = "$" + valor;
                }
            }

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcomb.Clear();
            txtlitro.Clear();
            txtvalor.Clear();
            
            txtcomb.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu frmmenu = new frmmenu();
            frmmenu.Show();
        }
    }



}