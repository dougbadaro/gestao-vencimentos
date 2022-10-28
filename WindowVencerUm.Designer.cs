namespace GestaoCompras
{
    partial class WindowVencerUm
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
            this.dgvVencerUm = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVencerUm)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVencerUm
            // 
            this.dgvVencerUm.AllowUserToAddRows = false;
            this.dgvVencerUm.AllowUserToDeleteRows = false;
            this.dgvVencerUm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVencerUm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVencerUm.Location = new System.Drawing.Point(0, 0);
            this.dgvVencerUm.Name = "dgvVencerUm";
            this.dgvVencerUm.ReadOnly = true;
            this.dgvVencerUm.RowHeadersVisible = false;
            this.dgvVencerUm.Size = new System.Drawing.Size(602, 329);
            this.dgvVencerUm.TabIndex = 0;
            // 
            // WindowVencerUm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 329);
            this.Controls.Add(this.dgvVencerUm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WindowVencerUm";
            this.Text = "A vencer em até 1 dia";
            this.Load += new System.EventHandler(this.WindowVencerUm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVencerUm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVencerUm;
    }
}