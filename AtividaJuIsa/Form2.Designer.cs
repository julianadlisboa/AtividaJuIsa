namespace AtividaJuIsa
{
    partial class frm2
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
            this.txtcomb = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.txtlitro = new System.Windows.Forms.TextBox();
            this.lblcomb = new System.Windows.Forms.Label();
            this.lbllitro = new System.Windows.Forms.Label();
            this.lblvalor = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtcomb
            // 
            this.txtcomb.Location = new System.Drawing.Point(459, 110);
            this.txtcomb.Name = "txtcomb";
            this.txtcomb.Size = new System.Drawing.Size(100, 22);
            this.txtcomb.TabIndex = 0;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(459, 237);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 22);
            this.txtvalor.TabIndex = 1;
            // 
            // txtlitro
            // 
            this.txtlitro.Location = new System.Drawing.Point(459, 171);
            this.txtlitro.Name = "txtlitro";
            this.txtlitro.Size = new System.Drawing.Size(100, 22);
            this.txtlitro.TabIndex = 2;
            // 
            // lblcomb
            // 
            this.lblcomb.AutoSize = true;
            this.lblcomb.Location = new System.Drawing.Point(52, 113);
            this.lblcomb.Name = "lblcomb";
            this.lblcomb.Size = new System.Drawing.Size(353, 16);
            this.lblcomb.TabIndex = 3;
            this.lblcomb.Text = "Qual o tipo de combustível A para Álcool G para Gasolina:";
            // 
            // lbllitro
            // 
            this.lbllitro.AutoSize = true;
            this.lbllitro.Location = new System.Drawing.Point(52, 177);
            this.lbllitro.Name = "lbllitro";
            this.lbllitro.Size = new System.Drawing.Size(175, 16);
            this.lbllitro.TabIndex = 4;
            this.lbllitro.Text = "Quantos litros você colocou:";
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Location = new System.Drawing.Point(52, 237);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(110, 16);
            this.lblvalor.TabIndex = 5;
            this.lblvalor.Text = "Valor a ser pago:";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(55, 310);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 36);
            this.btncalcular.TabIndex = 6;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(274, 310);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 36);
            this.btnlimpar.TabIndex = 7;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(484, 310);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 36);
            this.btnvoltar.TabIndex = 8;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(52, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Posto de Gasolina e Álcool";
            // 
            // frm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lblvalor);
            this.Controls.Add(this.lbllitro);
            this.Controls.Add(this.lblcomb);
            this.Controls.Add(this.txtlitro);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.txtcomb);
            this.Name = "frm2";
            this.Text = "Combustível";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcomb;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.TextBox txtlitro;
        private System.Windows.Forms.Label lblcomb;
        private System.Windows.Forms.Label lbllitro;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Label label1;
    }
}