namespace GestaoCompras
{
    partial class WindowVencerCinco
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
            this.dgvCincoDias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCincoDias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCincoDias
            // 
            this.dgvCincoDias.AllowUserToAddRows = false;
            this.dgvCincoDias.AllowUserToDeleteRows = false;
            this.dgvCincoDias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCincoDias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCincoDias.Location = new System.Drawing.Point(0, 0);
            this.dgvCincoDias.Name = "dgvCincoDias";
            this.dgvCincoDias.ReadOnly = true;
            this.dgvCincoDias.RowHeadersVisible = false;
            this.dgvCincoDias.Size = new System.Drawing.Size(450, 328);
            this.dgvCincoDias.TabIndex = 0;
            // 
            // WindowVencerCinco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 328);
            this.Controls.Add(this.dgvCincoDias);
            this.Name = "WindowVencerCinco";
            this.Text = "A vencer em até 5 dias";
            this.Load += new System.EventHandler(this.WindowVencerCinco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCincoDias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCincoDias;
    }
}