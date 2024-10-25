namespace Managenment_Windows
{
    partial class frmCreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateAccount));
            this.lblNameAccount = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnTrolai = new System.Windows.Forms.Button();
            this.txtNameAccount = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNameAccount
            // 
            this.lblNameAccount.AutoSize = true;
            this.lblNameAccount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameAccount.Location = new System.Drawing.Point(142, 156);
            this.lblNameAccount.Name = "lblNameAccount";
            this.lblNameAccount.Size = new System.Drawing.Size(157, 25);
            this.lblNameAccount.TabIndex = 0;
            this.lblNameAccount.Text = "Tên tài khoản:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(142, 194);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(119, 25);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Mật khẩu:";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.Location = new System.Drawing.Point(305, 250);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(170, 46);
            this.btnCreateAccount.TabIndex = 2;
            this.btnCreateAccount.Text = "Tạo tài khoản";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnTrolai
            // 
            this.btnTrolai.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrolai.Location = new System.Drawing.Point(501, 250);
            this.btnTrolai.Name = "btnTrolai";
            this.btnTrolai.Size = new System.Drawing.Size(89, 46);
            this.btnTrolai.TabIndex = 3;
            this.btnTrolai.Text = "Trở lại";
            this.btnTrolai.UseVisualStyleBackColor = true;
            this.btnTrolai.Click += new System.EventHandler(this.btnTrolai_Click);
            // 
            // txtNameAccount
            // 
            this.txtNameAccount.Location = new System.Drawing.Point(305, 156);
            this.txtNameAccount.Name = "txtNameAccount";
            this.txtNameAccount.Size = new System.Drawing.Size(285, 22);
            this.txtNameAccount.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(305, 194);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(285, 22);
            this.txtPassword.TabIndex = 4;
            // 
            // frmCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(732, 453);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtNameAccount);
            this.Controls.Add(this.btnTrolai);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblNameAccount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCreateAccount";
            this.Text = "Tạo tài khoản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameAccount;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnTrolai;
        private System.Windows.Forms.TextBox txtNameAccount;
        private System.Windows.Forms.TextBox txtPassword;
    }
}