namespace GestaoCompras
{
    partial class WindowNovoLote
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
            this.lblCadastroNovoLote = new System.Windows.Forms.Label();
            this.lblDataCompra = new System.Windows.Forms.Label();
            this.lblVencimento = new System.Windows.Forms.Label();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCadastroNovoLote
            // 
            this.lblCadastroNovoLote.AutoSize = true;
            this.lblCadastroNovoLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroNovoLote.Location = new System.Drawing.Point(24, 9);
            this.lblCadastroNovoLote.Name = "lblCadastroNovoLote";
            this.lblCadastroNovoLote.Size = new System.Drawing.Size(292, 25);
            this.lblCadastroNovoLote.TabIndex = 0;
            this.lblCadastroNovoLote.Text = "Cadastramento de Novo Lote";
            // 
            // lblDataCompra
            // 
            this.lblDataCompra.AutoSize = true;
            this.lblDataCompra.Location = new System.Drawing.Point(79, 86);
            this.lblDataCompra.Name = "lblDataCompra";
            this.lblDataCompra.Size = new System.Drawing.Size(90, 13);
            this.lblDataCompra.TabIndex = 2;
            this.lblDataCompra.Text = "Data da Compra: ";
            // 
            // lblVencimento
            // 
            this.lblVencimento.AutoSize = true;
            this.lblVencimento.Location = new System.Drawing.Point(59, 112);
            this.lblVencimento.Name = "lblVencimento";
            this.lblVencimento.Size = new System.Drawing.Size(110, 13);
            this.lblVencimento.TabIndex = 3;
            this.lblVencimento.Text = "Data de Vencimento: ";
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Location = new System.Drawing.Point(175, 135);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(100, 20);
            this.nudQuantidade.TabIndex = 4;
            this.nudQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantidade.ValueChanged += new System.EventHandler(this.nudQuantidade_ValueChanged);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(101, 137);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(68, 13);
            this.lblQuantidade.TabIndex = 5;
            this.lblQuantidade.Text = "Quantidade: ";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Enabled = false;
            this.btnCadastrar.Location = new System.Drawing.Point(136, 176);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(175, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(119, 59);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(50, 13);
            this.lblProduto.TabIndex = 11;
            this.lblProduto.Text = "Produto: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(175, 83);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(175, 109);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // WindowNovoLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 214);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.nudQuantidade);
            this.Controls.Add(this.lblVencimento);
            this.Controls.Add(this.lblDataCompra);
            this.Controls.Add(this.lblCadastroNovoLote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WindowNovoLote";
            this.Text = "Novo Lote";
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadastroNovoLote;
        private System.Windows.Forms.Label lblDataCompra;
        private System.Windows.Forms.Label lblVencimento;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}