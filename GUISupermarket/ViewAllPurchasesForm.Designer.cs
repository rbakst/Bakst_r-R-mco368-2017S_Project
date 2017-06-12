namespace GUISupermarket
{
    partial class ViewAllPurchasesForm
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
            this.purchasesGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // purchasesGridView
            // 
            this.purchasesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchasesGridView.Location = new System.Drawing.Point(49, 88);
            this.purchasesGridView.Name = "purchasesGridView";
            this.purchasesGridView.RowTemplate.Height = 24;
            this.purchasesGridView.Size = new System.Drawing.Size(690, 229);
            this.purchasesGridView.TabIndex = 0;
            // 
            // ViewAllPurchasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 543);
            this.Controls.Add(this.purchasesGridView);
            this.Name = "ViewAllPurchasesForm";
            this.Text = "ViewAllPurchasesForm";
            ((System.ComponentModel.ISupportInitialize)(this.purchasesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView purchasesGridView;
    }
}