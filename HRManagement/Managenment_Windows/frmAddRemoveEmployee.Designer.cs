namespace Managenment_Windows
{
    partial class frmAddRemoveEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddRemoveEmployee));
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.chklstRight = new System.Windows.Forms.CheckedListBox();
            this.chklstLeft = new System.Windows.Forms.CheckedListBox();
            this.lblDaThem = new System.Windows.Forms.Label();
            this.lblChuaThem = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(338, 275);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(60, 45);
            this.btnRemoveAll.TabIndex = 11;
            this.btnRemoveAll.Text = "<<";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(338, 214);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(60, 45);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(338, 153);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 45);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnAddAll
            // 
            this.btnAddAll.Location = new System.Drawing.Point(338, 92);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(60, 45);
            this.btnAddAll.TabIndex = 8;
            this.btnAddAll.Text = ">>";
            this.btnAddAll.UseVisualStyleBackColor = true;
            // 
            // chklstRight
            // 
            this.chklstRight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklstRight.FormattingEnabled = true;
            this.chklstRight.Location = new System.Drawing.Point(404, 92);
            this.chklstRight.Name = "chklstRight";
            this.chklstRight.Size = new System.Drawing.Size(319, 229);
            this.chklstRight.TabIndex = 7;
            // 
            // chklstLeft
            // 
            this.chklstLeft.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklstLeft.FormattingEnabled = true;
            this.chklstLeft.Location = new System.Drawing.Point(9, 92);
            this.chklstLeft.Name = "chklstLeft";
            this.chklstLeft.Size = new System.Drawing.Size(319, 229);
            this.chklstLeft.TabIndex = 6;
            // 
            // lblDaThem
            // 
            this.lblDaThem.AutoSize = true;
            this.lblDaThem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaThem.Location = new System.Drawing.Point(404, 64);
            this.lblDaThem.Name = "lblDaThem";
            this.lblDaThem.Size = new System.Drawing.Size(264, 25);
            this.lblDaThem.TabIndex = 12;
            this.lblDaThem.Text = "Nhân viên đã được thêm:";
            // 
            // lblChuaThem
            // 
            this.lblChuaThem.AutoSize = true;
            this.lblChuaThem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuaThem.Location = new System.Drawing.Point(12, 64);
            this.lblChuaThem.Name = "lblChuaThem";
            this.lblChuaThem.Size = new System.Drawing.Size(330, 25);
            this.lblChuaThem.TabIndex = 13;
            this.lblChuaThem.Text = "Nhân viên chưa được thêm vào:";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(612, 343);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 45);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(409, 343);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(168, 45);
            this.btnLuu.TabIndex = 23;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // frmAddRemoveEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(732, 453);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lblChuaThem);
            this.Controls.Add(this.lblDaThem);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnAddAll);
            this.Controls.Add(this.chklstRight);
            this.Controls.Add(this.chklstLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddRemoveEmployee";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.frmAddRemoveEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.CheckedListBox chklstRight;
        private System.Windows.Forms.CheckedListBox chklstLeft;
        private System.Windows.Forms.Label lblDaThem;
        private System.Windows.Forms.Label lblChuaThem;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLuu;
    }
}