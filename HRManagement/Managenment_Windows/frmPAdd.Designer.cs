namespace Managenment_Windows
{
    partial class frmPAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPAdd));
            this.chklstList = new System.Windows.Forms.CheckedListBox();
            this.chklstSelect = new System.Windows.Forms.CheckedListBox();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.lblNameProject = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAllEmployee = new System.Windows.Forms.Label();
            this.lblProjectEmployee = new System.Windows.Forms.Label();
            this.ProjectName = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbLeader = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chklstList
            // 
            this.chklstList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklstList.FormattingEnabled = true;
            this.chklstList.Location = new System.Drawing.Point(7, 159);
            this.chklstList.Margin = new System.Windows.Forms.Padding(2);
            this.chklstList.Name = "chklstList";
            this.chklstList.Size = new System.Drawing.Size(240, 172);
            this.chklstList.TabIndex = 0;
            // 
            // chklstSelect
            // 
            this.chklstSelect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklstSelect.FormattingEnabled = true;
            this.chklstSelect.Location = new System.Drawing.Point(303, 159);
            this.chklstSelect.Margin = new System.Windows.Forms.Padding(2);
            this.chklstSelect.Name = "chklstSelect";
            this.chklstSelect.Size = new System.Drawing.Size(240, 172);
            this.chklstSelect.TabIndex = 1;
            // 
            // btnAddAll
            // 
            this.btnAddAll.Location = new System.Drawing.Point(254, 159);
            this.btnAddAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(45, 37);
            this.btnAddAll.TabIndex = 2;
            this.btnAddAll.Text = ">>";
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(254, 209);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 37);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(254, 258);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(45, 37);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(254, 308);
            this.btnRemoveAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(45, 37);
            this.btnRemoveAll.TabIndex = 5;
            this.btnRemoveAll.Text = "<<";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // lblNameProject
            // 
            this.lblNameProject.AutoSize = true;
            this.lblNameProject.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameProject.Location = new System.Drawing.Point(3, 21);
            this.lblNameProject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameProject.Name = "lblNameProject";
            this.lblNameProject.Size = new System.Drawing.Size(98, 22);
            this.lblNameProject.TabIndex = 7;
            this.lblNameProject.Text = "Tên dự án:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lãnh đạo dự án:";
            // 
            // lblAllEmployee
            // 
            this.lblAllEmployee.AutoSize = true;
            this.lblAllEmployee.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllEmployee.Location = new System.Drawing.Point(3, 136);
            this.lblAllEmployee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAllEmployee.Name = "lblAllEmployee";
            this.lblAllEmployee.Size = new System.Drawing.Size(151, 22);
            this.lblAllEmployee.TabIndex = 9;
            this.lblAllEmployee.Text = "Tất cả nhân viên:";
            // 
            // lblProjectEmployee
            // 
            this.lblProjectEmployee.AutoSize = true;
            this.lblProjectEmployee.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectEmployee.Location = new System.Drawing.Point(299, 136);
            this.lblProjectEmployee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProjectEmployee.Name = "lblProjectEmployee";
            this.lblProjectEmployee.Size = new System.Drawing.Size(182, 22);
            this.lblProjectEmployee.TabIndex = 10;
            this.lblProjectEmployee.Text = "Nhân viên của dự án:";
            // 
            // ProjectName
            // 
            this.ProjectName.Location = new System.Drawing.Point(142, 23);
            this.ProjectName.Margin = new System.Windows.Forms.Padding(2);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(273, 20);
            this.ProjectName.TabIndex = 13;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(452, 72);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 37);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(452, 21);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(88, 37);
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbLeader
            // 
            this.cbLeader.FormattingEnabled = true;
            this.cbLeader.Location = new System.Drawing.Point(142, 63);
            this.cbLeader.Margin = new System.Windows.Forms.Padding(2);
            this.cbLeader.Name = "cbLeader";
            this.cbLeader.Size = new System.Drawing.Size(273, 21);
            this.cbLeader.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mô tả";
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(142, 107);
            this.Description.Margin = new System.Windows.Forms.Padding(2);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(273, 20);
            this.Description.TabIndex = 25;
            // 
            // frmPAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(549, 368);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLeader);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.ProjectName);
            this.Controls.Add(this.lblProjectEmployee);
            this.Controls.Add(this.lblAllEmployee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNameProject);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnAddAll);
            this.Controls.Add(this.chklstSelect);
            this.Controls.Add(this.chklstList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPAdd";
            this.Text = "Thêm dự án";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chklstList;
        private System.Windows.Forms.CheckedListBox chklstSelect;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Label lblNameProject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAllEmployee;
        private System.Windows.Forms.Label lblProjectEmployee;
        private System.Windows.Forms.TextBox ProjectName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbLeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Description;
    }
}