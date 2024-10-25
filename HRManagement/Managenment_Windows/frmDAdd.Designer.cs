namespace Managenment_Windows
{
    partial class frmDAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDAdd));
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.lblProjectEmployee = new System.Windows.Forms.Label();
            this.lblAllEmployee = new System.Windows.Forms.Label();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.chklstRight = new System.Windows.Forms.CheckedListBox();
            this.chklstLeft = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(599, 28);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(121, 32);
            this.btnLuu.TabIndex = 43;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(599, 84);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(121, 32);
            this.btnBack.TabIndex = 42;
            this.btnBack.Text = "Trở lại";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(144, 83);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(435, 22);
            this.textBox3.TabIndex = 41;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(435, 22);
            this.textBox2.TabIndex = 40;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(16, 84);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(81, 25);
            this.lblDescription.TabIndex = 39;
            this.lblDescription.Text = "Mô tả:";
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectName.Location = new System.Drawing.Point(16, 35);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(122, 25);
            this.lblProjectName.TabIndex = 38;
            this.lblProjectName.Text = "Tên dự án:";
            // 
            // lblProjectEmployee
            // 
            this.lblProjectEmployee.AutoSize = true;
            this.lblProjectEmployee.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectEmployee.Location = new System.Drawing.Point(402, 167);
            this.lblProjectEmployee.Name = "lblProjectEmployee";
            this.lblProjectEmployee.Size = new System.Drawing.Size(226, 25);
            this.lblProjectEmployee.TabIndex = 52;
            this.lblProjectEmployee.Text = "Nhân viên của dự án:";
            // 
            // lblAllEmployee
            // 
            this.lblAllEmployee.AutoSize = true;
            this.lblAllEmployee.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllEmployee.Location = new System.Drawing.Point(7, 167);
            this.lblAllEmployee.Name = "lblAllEmployee";
            this.lblAllEmployee.Size = new System.Drawing.Size(186, 25);
            this.lblAllEmployee.TabIndex = 51;
            this.lblAllEmployee.Text = "Tất cả nhân viên:";
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(341, 378);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(60, 45);
            this.btnRemoveAll.TabIndex = 50;
            this.btnRemoveAll.Text = "<<";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(341, 317);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(60, 45);
            this.btnRemove.TabIndex = 49;
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(341, 256);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 45);
            this.btnAdd.TabIndex = 48;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnAddAll
            // 
            this.btnAddAll.Location = new System.Drawing.Point(341, 195);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(60, 45);
            this.btnAddAll.TabIndex = 47;
            this.btnAddAll.Text = ">>";
            this.btnAddAll.UseVisualStyleBackColor = true;
            // 
            // chklstRight
            // 
            this.chklstRight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklstRight.FormattingEnabled = true;
            this.chklstRight.Location = new System.Drawing.Point(407, 195);
            this.chklstRight.Name = "chklstRight";
            this.chklstRight.Size = new System.Drawing.Size(319, 229);
            this.chklstRight.TabIndex = 46;
            // 
            // chklstLeft
            // 
            this.chklstLeft.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklstLeft.FormattingEnabled = true;
            this.chklstLeft.Location = new System.Drawing.Point(12, 195);
            this.chklstLeft.Name = "chklstLeft";
            this.chklstLeft.Size = new System.Drawing.Size(319, 229);
            this.chklstLeft.TabIndex = 45;
            // 
            // frmDAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(732, 453);
            this.Controls.Add(this.lblProjectEmployee);
            this.Controls.Add(this.lblAllEmployee);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnAddAll);
            this.Controls.Add(this.chklstRight);
            this.Controls.Add(this.chklstLeft);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblProjectName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDAdd";
            this.Text = "Thêm phòng ban";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label lblProjectEmployee;
        private System.Windows.Forms.Label lblAllEmployee;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.CheckedListBox chklstRight;
        private System.Windows.Forms.CheckedListBox chklstLeft;
    }
}