﻿using System;
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
    public partial class Frm5 : Form
    {
        public Frm5()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int i, num, result;

            num = Convert.ToInt32(txtnum.Text);
            i = Convert.ToInt32(txtnum.Text);

            i = 1;

            do
            {
                result = num * i;
                txtresult.Text=String.Concat(txtresult.Text, "\r\n", result.ToString());
                i++;
            }while (i<11);
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
    }
}
