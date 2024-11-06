namespace Managenment_Windows
{
    partial class frmInfoDepartment
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
            this.btnXphDepartment = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dtgEmployees = new System.Windows.Forms.DataGridView();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.lblLeader = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.cbLeader = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXphDepartment
            // 
            this.btnXphDepartment.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXphDepartment.Location = new System.Drawing.Point(473, 404);
            this.btnXphDepartment.Name = "btnXphDepartment";
            this.btnXphDepartment.Size = new System.Drawing.Size(228, 37);
            this.btnXphDepartment.TabIndex = 47;
            this.btnXphDepartment.Text = "Xóa phòng ban";
            this.btnXphDepartment.UseVisualStyleBackColor = true;
            this.btnXphDepartment.Click += new System.EventHandler(this.btnXphDepartment_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(473, 64);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdd.Size = new System.Drawing.Size(228, 32);
            this.btnAdd.TabIndex = 46;
            this.btnAdd.Text = "Thêm/Xóa nhân viên";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(473, 21);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(228, 32);
            this.btnLuu.TabIndex = 45;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(473, 107);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(228, 32);
            this.btnBack.TabIndex = 44;
            this.btnBack.Text = "Trở lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dtgEmployees
            // 
            this.dtgEmployees.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dtgEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmployees.Location = new System.Drawing.Point(36, 156);
            this.dtgEmployees.Name = "dtgEmployees";
            this.dtgEmployees.RowHeadersWidth = 51;
            this.dtgEmployees.RowTemplate.Height = 24;
            this.dtgEmployees.Size = new System.Drawing.Size(665, 242);
            this.dtgEmployees.TabIndex = 43;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(195, 70);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(248, 22);
            this.txtDepartment.TabIndex = 41;
            // 
            // lblLeader
            // 
            this.lblLeader.AutoSize = true;
            this.lblLeader.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeader.Location = new System.Drawing.Point(31, 115);
            this.lblLeader.Name = "lblLeader";
            this.lblLeader.Size = new System.Drawing.Size(164, 25);
            this.lblLeader.TabIndex = 40;
            this.lblLeader.Text = "Trưởng phòng:";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(31, 66);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(129, 25);
            this.lblDepartment.TabIndex = 39;
            this.lblDepartment.Text = "Phòng ban:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(31, 17);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(46, 25);
            this.lblID.TabIndex = 38;
            this.lblID.Text = "ID:";
            // 
            // cbLeader
            // 
            this.cbLeader.FormattingEnabled = true;
            this.cbLeader.Location = new System.Drawing.Point(195, 113);
            this.cbLeader.Name = "cbLeader";
            this.cbLeader.Size = new System.Drawing.Size(247, 24);
            this.cbLeader.TabIndex = 48;
            // 
            // frmInfoDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(732, 453);
            this.Controls.Add(this.cbLeader);
            this.Controls.Add(this.btnXphDepartment);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dtgEmployees);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.lblLeader);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblID);
            this.Name = "frmInfoDepartment";
            this.Text = "frmInfoDepartment";
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXphDepartment;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dtgEmployees;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label lblLeader;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox cbLeader;
    }
}