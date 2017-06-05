namespace GUISupermarket
{
    partial class SignUpForm
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
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pswdTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reenterpswdTB = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.newUsernameLabel = new System.Windows.Forms.Label();
            this.passwordProblemLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "username";
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(234, 59);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(100, 22);
            this.usernameTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "password (8 characters)";
            // 
            // pswdTB
            // 
            this.pswdTB.Location = new System.Drawing.Point(234, 121);
            this.pswdTB.Name = "pswdTB";
            this.pswdTB.Size = new System.Drawing.Size(100, 22);
            this.pswdTB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "reenter password";
            // 
            // reenterpswdTB
            // 
            this.reenterpswdTB.Location = new System.Drawing.Point(234, 185);
            this.reenterpswdTB.Name = "reenterpswdTB";
            this.reenterpswdTB.Size = new System.Drawing.Size(100, 22);
            this.reenterpswdTB.TabIndex = 5;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(208, 251);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 30);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // newUsernameLabel
            // 
            this.newUsernameLabel.AutoSize = true;
            this.newUsernameLabel.Location = new System.Drawing.Point(231, 81);
            this.newUsernameLabel.Name = "newUsernameLabel";
            this.newUsernameLabel.Size = new System.Drawing.Size(256, 17);
            this.newUsernameLabel.TabIndex = 7;
            this.newUsernameLabel.Text = "username taken choose new username";
            this.newUsernameLabel.Visible = false;
            // 
            // passwordProblemLabel
            // 
            this.passwordProblemLabel.AutoSize = true;
            this.passwordProblemLabel.Location = new System.Drawing.Point(234, 150);
            this.passwordProblemLabel.Name = "passwordProblemLabel";
            this.passwordProblemLabel.Size = new System.Drawing.Size(205, 17);
            this.passwordProblemLabel.TabIndex = 8;
            this.passwordProblemLabel.Text = "password must be 8 characters";
            this.passwordProblemLabel.Visible = false;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 368);
            this.Controls.Add(this.passwordProblemLabel);
            this.Controls.Add(this.newUsernameLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.reenterpswdTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pswdTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.label1);
            this.Name = "SignUpForm";
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pswdTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox reenterpswdTB;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label newUsernameLabel;
        private System.Windows.Forms.Label passwordProblemLabel;
    }
}