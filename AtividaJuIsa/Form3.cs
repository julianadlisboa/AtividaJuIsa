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
    public partial class Frm3 : Form
    {
        double votot, a, b, c, votar, p;

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu menu = new frmmenu();
            menu.Show(this);
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtvotot.Clear();
            txtvencedor.Clear();
            txtnome.Text = "...";
            a = 0;
            b = 0;
            c = 0;
            btna.Enabled = true;
            btnb.Enabled = true;
            btnc.Enabled = true;
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            txtnome.Text = "...";

            votot = a + b + c;
            txtvotot.Text= votot.ToString();

            if(a > b && a > c)
            {
                p = (a * 100) / votot;
                txtvencedor.Text="José Nascimento, com " + a + " votos, sendo "+ p +" % dos votos".ToString();
            }
            else if (b > a && b > c)
            {
                p = (b * 100) / votot;
                txtvencedor.Text = "Maria Juruma, com " + b + " votos, sendo " + p +  "% dos votos ".ToString();
            }
            else if(c > a && c < b)
            {
                p = (c * 100) / votot;
                txtvencedor.Text = "João da Tapioca, com " + c + " votos, sendo " + p + "% dos votos".ToString();
            }
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            c++;
            txtnome.Text = "Seu voto foi em João da Tapioca";
        }

        private void btnb_Click(object sender, EventArgs e)
        {
            b++;
            txtnome.Text = "Seu voto foi em Maria Juruma";
        }

        private void btna_Click(object sender, EventArgs e)
        {
            a++;
            txtnome.Text = "Seu voto foi em José Nascimento";
        }

        public Frm3()
        {
            InitializeComponent();
        }

        private void Frm3_Load(object sender, EventArgs e)
        {

        }
    }
}
