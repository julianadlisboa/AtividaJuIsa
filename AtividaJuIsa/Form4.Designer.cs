﻿namespace AtividaJuIsa
{
    partial class Frm4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.lblnum = new System.Windows.Forms.Label();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(563, 354);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 19;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(353, 354);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 18;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(134, 354);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 17;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(131, 125);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(72, 16);
            this.lbl.TabIndex = 15;
            this.lbl.Text = "Resultado:";
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Location = new System.Drawing.Point(131, 67);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(114, 16);
            this.lblnum.TabIndex = 14;
            this.lblnum.Text = "Digite um número:";
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(538, 122);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.ReadOnly = true;
            this.txtresult.Size = new System.Drawing.Size(100, 188);
            this.txtresult.TabIndex = 13;
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(538, 64);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(100, 22);
            this.txtnum.TabIndex = 11;
            // 
            // Frm4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtnum);
            this.Name = "Frm4";
            this.Text = "Tabuada while";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.TextBox txtnum;
    }
}