namespace QuanLySuaXe.View
{
    partial class FormTho
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
            this.dgvTho = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTho)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTho
            // 
            this.dgvTho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTho.Location = new System.Drawing.Point(189, 85);
            this.dgvTho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTho.Name = "dgvTho";
            this.dgvTho.RowHeadersWidth = 51;
            this.dgvTho.Size = new System.Drawing.Size(861, 372);
            this.dgvTho.TabIndex = 0;
            // 
            // FormTho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 596);
            this.Controls.Add(this.dgvTho);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormTho";
            this.Text = "FormTho";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTho;
    }
}