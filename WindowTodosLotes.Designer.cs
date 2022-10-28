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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodosLotes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTodosLotes
            // 
            this.dgvTodosLotes.AllowUserToAddRows = false;
            this.dgvTodosLotes.AllowUserToDeleteRows = false;
            this.dgvTodosLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodosLotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTodosLotes.Location = new System.Drawing.Point(0, 0);
            this.dgvTodosLotes.Name = "dgvTodosLotes";
            this.dgvTodosLotes.ReadOnly = true;
            this.dgvTodosLotes.RowHeadersVisible = false;
            this.dgvTodosLotes.Size = new System.Drawing.Size(602, 318);
            this.dgvTodosLotes.TabIndex = 0;
            // 
            // WindowTodosLotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 318);
            this.Controls.Add(this.dgvTodosLotes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WindowTodosLotes";
            this.Text = "Todos os Lotes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodosLotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTodosLotes;
    }
}