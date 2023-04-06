namespace AtividaJuIsa
{
    partial class Frm3
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
            this.lblvotot = new System.Windows.Forms.Label();
            this.lblvencedor = new System.Windows.Forms.Label();
            this.txtvotot = new System.Windows.Forms.TextBox();
            this.txtvencedor = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btna = new System.Windows.Forms.Button();
            this.btnb = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblvotot
            // 
            this.lblvotot.BackColor = System.Drawing.Color.White;
            this.lblvotot.Location = new System.Drawing.Point(36, 208);
            this.lblvotot.Name = "lblvotot";
            this.lblvotot.Size = new System.Drawing.Size(104, 22);
            this.lblvotot.TabIndex = 0;
            this.lblvotot.Text = "Total de votos:";
            // 
            // lblvencedor
            // 
            this.lblvencedor.BackColor = System.Drawing.Color.White;
            this.lblvencedor.Location = new System.Drawing.Point(36, 274);
            this.lblvencedor.Name = "lblvencedor";
            this.lblvencedor.Size = new System.Drawing.Size(167, 22);
            this.lblvencedor.TabIndex = 1;
            this.lblvencedor.Text = "O vencedor da eleição foi:";
            // 
            // txtvotot
            // 
            this.txtvotot.Location = new System.Drawing.Point(218, 208);
            this.txtvotot.Name = "txtvotot";
            this.txtvotot.Size = new System.Drawing.Size(132, 22);
            this.txtvotot.TabIndex = 2;
            // 
            // txtvencedor
            // 
            this.txtvencedor.Location = new System.Drawing.Point(218, 274);
            this.txtvencedor.Name = "txtvencedor";
            this.txtvencedor.Size = new System.Drawing.Size(359, 22);
            this.txtvencedor.TabIndex = 3;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(29, 354);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(126, 36);
            this.btncalcular.TabIndex = 4;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(192, 354);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(126, 36);
            this.btnlimpar.TabIndex = 5;
            this.btnlimpar.Text = "limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(367, 354);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(126, 36);
            this.btnvoltar.TabIndex = 6;
            this.btnvoltar.Text = "voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btna
            // 
            this.btna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btna.Location = new System.Drawing.Point(135, 99);
            this.btna.Name = "btna";
            this.btna.Size = new System.Drawing.Size(157, 36);
            this.btna.TabIndex = 7;
            this.btna.Text = "1.José Nascimento";
            this.btna.UseVisualStyleBackColor = false;
            this.btna.Click += new System.EventHandler(this.btna_Click);
            // 
            // btnb
            // 
            this.btnb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnb.Location = new System.Drawing.Point(324, 99);
            this.btnb.Name = "btnb";
            this.btnb.Size = new System.Drawing.Size(118, 36);
            this.btnb.TabIndex = 8;
            this.btnb.Text = "2.Maria Juruma";
            this.btnb.UseVisualStyleBackColor = false;
            this.btnb.Click += new System.EventHandler(this.btnb_Click);
            // 
            // btnc
            // 
            this.btnc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnc.Location = new System.Drawing.Point(472, 99);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(159, 36);
            this.btnc.TabIndex = 9;
            this.btnc.Text = "3. João da Tapioca";
            this.btnc.UseVisualStyleBackColor = false;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // lbltitulo
            // 
            this.lbltitulo.BackColor = System.Drawing.Color.IndianRed;
            this.lbltitulo.Location = new System.Drawing.Point(237, 24);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(296, 47);
            this.lbltitulo.TabIndex = 10;
            this.lbltitulo.Text = "ELEIÇÕES";
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtnome
            // 
            this.txtnome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtnome.ForeColor = System.Drawing.Color.White;
            this.txtnome.Location = new System.Drawing.Point(269, 161);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(233, 22);
            this.txtnome.TabIndex = 11;
            this.txtnome.Text = "...";
            // 
            // Frm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.btnb);
            this.Controls.Add(this.btna);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtvencedor);
            this.Controls.Add(this.txtvotot);
            this.Controls.Add(this.lblvencedor);
            this.Controls.Add(this.lblvotot);
            this.Name = "Frm3";
            this.Text = "Eleição";
            this.Load += new System.EventHandler(this.Frm3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblvotot;
        private System.Windows.Forms.Label lblvencedor;
        private System.Windows.Forms.TextBox txtvotot;
        private System.Windows.Forms.TextBox txtvencedor;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btna;
        private System.Windows.Forms.Button btnb;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.TextBox txtnome;
    }
}