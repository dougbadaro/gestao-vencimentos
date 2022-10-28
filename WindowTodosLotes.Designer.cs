namespace GestaoCompras
{
    partial class WindowTodosLotes
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
            this.dgvTodosLotes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodosLotes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTodosLotes
            // 
            this.dgvTodosLotes.AllowUserToOrderColumns = true;
            this.dgvTodosLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodosLotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvTodosLotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTodosLotes.Location = new System.Drawing.Point(0, 0);
            this.dgvTodosLotes.Name = "dgvTodosLotes";
            this.dgvTodosLotes.RowHeadersVisible = false;
            this.dgvTodosLotes.Size = new System.Drawing.Size(503, 318);
            this.dgvTodosLotes.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // WindowTodosLotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 318);
            this.Controls.Add(this.dgvTodosLotes);
            this.Name = "WindowTodosLotes";
            this.Text = "Todos os Lotes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodosLotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dgvTodosLotes;
    }
}