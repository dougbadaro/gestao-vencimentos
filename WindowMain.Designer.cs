namespace GestaoCompras
{
    partial class WindowMain
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
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoLoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTodosLotes = new System.Windows.Forms.ToolStripMenuItem();
            this.aVencerEmAté1DiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aVencerEmAté5DiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vencimentoPersonalizadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoLoteToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // novoLoteToolStripMenuItem
            // 
            this.novoLoteToolStripMenuItem.Name = "novoLoteToolStripMenuItem";
            this.novoLoteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoLoteToolStripMenuItem.Text = "Novo lote";
            this.novoLoteToolStripMenuItem.Click += new System.EventHandler(this.novoLoteToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTodosLotes,
            this.aVencerEmAté1DiaToolStripMenuItem,
            this.aVencerEmAté5DiasToolStripMenuItem,
            this.vencimentoPersonalizadoToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // mnuTodosLotes
            // 
            this.mnuTodosLotes.Name = "mnuTodosLotes";
            this.mnuTodosLotes.Size = new System.Drawing.Size(213, 22);
            this.mnuTodosLotes.Text = "Todos Lotes";
            this.mnuTodosLotes.Click += new System.EventHandler(this.mnuTodosLotes_Click);
            // 
            // aVencerEmAté1DiaToolStripMenuItem
            // 
            this.aVencerEmAté1DiaToolStripMenuItem.Name = "aVencerEmAté1DiaToolStripMenuItem";
            this.aVencerEmAté1DiaToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.aVencerEmAté1DiaToolStripMenuItem.Text = "A vencer em até 1 dia";
            this.aVencerEmAté1DiaToolStripMenuItem.Click += new System.EventHandler(this.aVencerEmAté1DiaToolStripMenuItem_Click);
            // 
            // aVencerEmAté5DiasToolStripMenuItem
            // 
            this.aVencerEmAté5DiasToolStripMenuItem.Name = "aVencerEmAté5DiasToolStripMenuItem";
            this.aVencerEmAté5DiasToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.aVencerEmAté5DiasToolStripMenuItem.Text = "A vencer em até 5 dias";
            this.aVencerEmAté5DiasToolStripMenuItem.Click += new System.EventHandler(this.aVencerEmAté5DiasToolStripMenuItem_Click);
            // 
            // vencimentoPersonalizadoToolStripMenuItem
            // 
            this.vencimentoPersonalizadoToolStripMenuItem.Name = "vencimentoPersonalizadoToolStripMenuItem";
            this.vencimentoPersonalizadoToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.vencimentoPersonalizadoToolStripMenuItem.Text = "Vencimento Personalizado";
            this.vencimentoPersonalizadoToolStripMenuItem.Click += new System.EventHandler(this.vencimentoPersonalizadoToolStripMenuItem_Click);
            // 
            // WindowMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WindowMain";
            this.Text = "Gestão de Compras";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoLoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuTodosLotes;
        private System.Windows.Forms.ToolStripMenuItem aVencerEmAté1DiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aVencerEmAté5DiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vencimentoPersonalizadoToolStripMenuItem;
    }
}

