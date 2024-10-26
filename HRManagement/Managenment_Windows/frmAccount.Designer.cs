namespace Managenment_Windows
{
    partial class frmAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccount));
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.Location = new System.Drawing.Point(254, 40);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(224, 93);
            this.btnCreateAccount.TabIndex = 0;
            this.btnCreateAccount.Text = "Tạo tài khoản";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Location = new System.Drawing.Point(254, 180);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(224, 93);
            this.btnChangePassword.TabIndex = 1;
            this.btnChangePassword.Text = "Đổi mật khẩu";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(254, 320);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(224, 93);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(732, 453);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnCreateAccount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tài khoản";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnLogOut;
    }
}