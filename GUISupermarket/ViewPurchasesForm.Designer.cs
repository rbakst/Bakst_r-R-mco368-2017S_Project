namespace GUISupermarket
{
    partial class ViewPurchasesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAllPurchases = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDatePurchases = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAmountPurchases = new System.Windows.Forms.Button();
            this.fromCalendar = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.FromAmount = new System.Windows.Forms.NumericUpDown();
            this.ToAmount = new System.Windows.Forms.NumericUpDown();
            this.toCalendar = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FromAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "View All Purchases";
            // 
            // btnAllPurchases
            // 
            this.btnAllPurchases.Location = new System.Drawing.Point(499, 26);
            this.btnAllPurchases.Name = "btnAllPurchases";
            this.btnAllPurchases.Size = new System.Drawing.Size(75, 23);
            this.btnAllPurchases.TabIndex = 1;
            this.btnAllPurchases.Text = "View";
            this.btnAllPurchases.UseVisualStyleBackColor = true;
            this.btnAllPurchases.Click += new System.EventHandler(this.btnAllPurchases_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "View Purchases By Date";
            // 
            // btnDatePurchases
            // 
            this.btnDatePurchases.Location = new System.Drawing.Point(374, 373);
            this.btnDatePurchases.Name = "btnDatePurchases";
            this.btnDatePurchases.Size = new System.Drawing.Size(75, 23);
            this.btnDatePurchases.TabIndex = 3;
            this.btnDatePurchases.Text = "View";
            this.btnDatePurchases.UseVisualStyleBackColor = true;
            this.btnDatePurchases.Click += new System.EventHandler(this.btnDatePurchases_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "View Purchases By Amount";
            // 
            // btnAmountPurchases
            // 
            this.btnAmountPurchases.Location = new System.Drawing.Point(645, 472);
            this.btnAmountPurchases.Name = "btnAmountPurchases";
            this.btnAmountPurchases.Size = new System.Drawing.Size(75, 23);
            this.btnAmountPurchases.TabIndex = 5;
            this.btnAmountPurchases.Text = "View";
            this.btnAmountPurchases.UseVisualStyleBackColor = true;
            this.btnAmountPurchases.Click += new System.EventHandler(this.btnAmountPurchases_Click);
            // 
            // fromCalendar
            // 
            this.fromCalendar.Location = new System.Drawing.Point(102, 146);
            this.fromCalendar.Name = "fromCalendar";
            this.fromCalendar.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 471);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Between:";
            // 
            // FromAmount
            // 
            this.FromAmount.DecimalPlaces = 2;
            this.FromAmount.Location = new System.Drawing.Point(260, 471);
            this.FromAmount.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.FromAmount.Name = "FromAmount";
            this.FromAmount.Size = new System.Drawing.Size(120, 22);
            this.FromAmount.TabIndex = 10;
            // 
            // ToAmount
            // 
            this.ToAmount.DecimalPlaces = 2;
            this.ToAmount.Location = new System.Drawing.Point(434, 472);
            this.ToAmount.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.ToAmount.Name = "ToAmount";
            this.ToAmount.Size = new System.Drawing.Size(120, 22);
            this.ToAmount.TabIndex = 11;
            // 
            // toCalendar
            // 
            this.toCalendar.Location = new System.Drawing.Point(458, 146);
            this.toCalendar.Name = "toCalendar";
            this.toCalendar.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "From:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(458, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "To:";
            // 
            // ViewPurchasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 559);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toCalendar);
            this.Controls.Add(this.ToAmount);
            this.Controls.Add(this.FromAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fromCalendar);
            this.Controls.Add(this.btnAmountPurchases);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDatePurchases);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAllPurchases);
            this.Controls.Add(this.label1);
            this.Name = "ViewPurchasesForm";
            this.Text = "ViewPurchasesForm";
            ((System.ComponentModel.ISupportInitialize)(this.FromAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAllPurchases;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDatePurchases;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAmountPurchases;
        private System.Windows.Forms.MonthCalendar fromCalendar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown FromAmount;
        private System.Windows.Forms.NumericUpDown ToAmount;
        private System.Windows.Forms.MonthCalendar toCalendar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}