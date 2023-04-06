namespace AtividaJuIsa
{
    partial class frmmenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.algoritmosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.combustvelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eleiçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabuadaWhileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabuadaDoWhileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabuadaForToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algoritmosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // algoritmosToolStripMenuItem
            // 
            this.algoritmosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.combustvelToolStripMenuItem,
            this.eleiçãoToolStripMenuItem,
            this.tabuadaWhileToolStripMenuItem,
            this.tabuadaDoWhileToolStripMenuItem,
            this.tabuadaForToolStripMenuItem});
            this.algoritmosToolStripMenuItem.Name = "algoritmosToolStripMenuItem";
            this.algoritmosToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.algoritmosToolStripMenuItem.Text = "Algoritmos";
            this.algoritmosToolStripMenuItem.Click += new System.EventHandler(this.algoritmosToolStripMenuItem_Click);
            // 
            // combustvelToolStripMenuItem
            // 
            this.combustvelToolStripMenuItem.Name = "combustvelToolStripMenuItem";
            this.combustvelToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.combustvelToolStripMenuItem.Text = "Combustível";
            this.combustvelToolStripMenuItem.Click += new System.EventHandler(this.combustvelToolStripMenuItem_Click);
            // 
            // eleiçãoToolStripMenuItem
            // 
            this.eleiçãoToolStripMenuItem.Name = "eleiçãoToolStripMenuItem";
            this.eleiçãoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.eleiçãoToolStripMenuItem.Text = "Eleição";
            this.eleiçãoToolStripMenuItem.Click += new System.EventHandler(this.eleiçãoToolStripMenuItem_Click);
            // 
            // tabuadaWhileToolStripMenuItem
            // 
            this.tabuadaWhileToolStripMenuItem.Name = "tabuadaWhileToolStripMenuItem";
            this.tabuadaWhileToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tabuadaWhileToolStripMenuItem.Text = "tabuada while";
            this.tabuadaWhileToolStripMenuItem.Click += new System.EventHandler(this.tabuadaWhileToolStripMenuItem_Click);
            // 
            // tabuadaDoWhileToolStripMenuItem
            // 
            this.tabuadaDoWhileToolStripMenuItem.Name = "tabuadaDoWhileToolStripMenuItem";
            this.tabuadaDoWhileToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tabuadaDoWhileToolStripMenuItem.Text = "tabuada do while";
            this.tabuadaDoWhileToolStripMenuItem.Click += new System.EventHandler(this.tabuadaDoWhileToolStripMenuItem_Click);
            // 
            // tabuadaForToolStripMenuItem
            // 
            this.tabuadaForToolStripMenuItem.Name = "tabuadaForToolStripMenuItem";
            this.tabuadaForToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tabuadaForToolStripMenuItem.Text = "tabuada for";
            this.tabuadaForToolStripMenuItem.Click += new System.EventHandler(this.tabuadaForToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmmenu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem algoritmosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem combustvelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eleiçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabuadaWhileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabuadaDoWhileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabuadaForToolStripMenuItem;
    }
}

