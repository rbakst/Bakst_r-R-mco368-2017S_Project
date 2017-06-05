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
            this.calendarFrom = new System.Windows.Forms.MonthCalendar();
            this.calendarTo = new System.Windows.Forms.MonthCalendar();
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
            this.btnAllPurchases.Location = new System.Drawing.Point(365, 56);
            this.btnAllPurchases.Name = "btnAllPurchases";
            this.btnAllPurchases.Size = new System.Drawing.Size(75, 23);
            this.btnAllPurchases.TabIndex = 1;
            this.btnAllPurchases.Text = "View";
            this.btnAllPurchases.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "View Purchases By Date";
            // 
            // btnDatePurchases
            // 
            this.btnDatePurchases.Location = new System.Drawing.Point(365, 365);
            this.btnDatePurchases.Name = "btnDatePurchases";
            this.btnDatePurchases.Size = new System.Drawing.Size(75, 23);
            this.btnDatePurchases.TabIndex = 3;
            this.btnDatePurchases.Text = "View";
            this.btnDatePurchases.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "View Purchases By Amount";
            // 
            // btnAmountPurchases
            // 
            this.btnAmountPurchases.Location = new System.Drawing.Point(451, 421);
            this.btnAmountPurchases.Name = "btnAmountPurchases";
            this.btnAmountPurchases.Size = new System.Drawing.Size(75, 23);
            this.btnAmountPurchases.TabIndex = 5;
            this.btnAmountPurchases.Text = "View";
            this.btnAmountPurchases.UseVisualStyleBackColor = true;
            // 
            // calendarFrom
            // 
            this.calendarFrom.Location = new System.Drawing.Point(120, 146);
            this.calendarFrom.Name = "calendarFrom";
            this.calendarFrom.TabIndex = 6;
            // 
            // calendarTo
            // 
            this.calendarTo.Location = new System.Drawing.Point(411, 146);
            this.calendarTo.Name = "calendarTo";
            this.calendarTo.TabIndex = 7;
            // 
            // ViewPurchasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 502);
            this.Controls.Add(this.calendarTo);
            this.Controls.Add(this.calendarFrom);
            this.Controls.Add(this.btnAmountPurchases);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDatePurchases);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAllPurchases);
            this.Controls.Add(this.label1);
            this.Name = "ViewPurchasesForm";
            this.Text = "ViewPurchasesForm";
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
        private System.Windows.Forms.MonthCalendar calendarFrom;
        private System.Windows.Forms.MonthCalendar calendarTo;
    }
}