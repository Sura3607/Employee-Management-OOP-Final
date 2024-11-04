namespace Managenment_Windows
{
    partial class frmTableSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTableSalary));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Senority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Worktime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalculatedSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.cbboxLoaiNv = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtboxSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeID,
            this.NameEmployee,
            this.Senority,
            this.Worktime,
            this.BaseSalary,
            this.CalculatedSalary});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(12, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(777, 259);
            this.dataGridView1.TabIndex = 0;
            // 
            // EmployeeID
            // 
            this.EmployeeID.HeaderText = "ID";
            this.EmployeeID.MinimumWidth = 6;
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.ReadOnly = true;
            this.EmployeeID.Width = 125;
            // 
            // NameEmployee
            // 
            this.NameEmployee.HeaderText = "Tên";
            this.NameEmployee.MinimumWidth = 6;
            this.NameEmployee.Name = "NameEmployee";
            this.NameEmployee.ReadOnly = true;
            this.NameEmployee.Width = 125;
            // 
            // Senority
            // 
            this.Senority.HeaderText = "Thâm niên";
            this.Senority.MinimumWidth = 6;
            this.Senority.Name = "Senority";
            this.Senority.ReadOnly = true;
            this.Senority.Width = 125;
            // 
            // Worktime
            // 
            this.Worktime.HeaderText = "Giờ làm";
            this.Worktime.MinimumWidth = 6;
            this.Worktime.Name = "Worktime";
            this.Worktime.ReadOnly = true;
            this.Worktime.Width = 125;
            // 
            // BaseSalary
            // 
            this.BaseSalary.HeaderText = "Lương cơ bản";
            this.BaseSalary.MinimumWidth = 6;
            this.BaseSalary.Name = "BaseSalary";
            this.BaseSalary.ReadOnly = true;
            this.BaseSalary.Width = 125;
            // 
            // CalculatedSalary
            // 
            this.CalculatedSalary.HeaderText = "Lương";
            this.CalculatedSalary.MinimumWidth = 6;
            this.CalculatedSalary.Name = "CalculatedSalary";
            this.CalculatedSalary.ReadOnly = true;
            this.CalculatedSalary.Width = 125;
            // 
            // btnTroLai
            // 
            this.btnTroLai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTroLai.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroLai.Location = new System.Drawing.Point(617, 365);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(157, 40);
            this.btnTroLai.TabIndex = 1;
            this.btnTroLai.Text = "Trở lại";
            this.btnTroLai.UseVisualStyleBackColor = false;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLoadData.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadData.Location = new System.Drawing.Point(417, 365);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(166, 40);
            this.btnLoadData.TabIndex = 2;
            this.btnLoadData.Text = "Tải dữ liệu";
            this.btnLoadData.UseVisualStyleBackColor = false;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // cbboxLoaiNv
            // 
            this.cbboxLoaiNv.AllowDrop = true;
            this.cbboxLoaiNv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxLoaiNv.FormattingEnabled = true;
            this.cbboxLoaiNv.Items.AddRange(new object[] {
            "Full time ",
            "Part time",
            "All"});
            this.cbboxLoaiNv.Location = new System.Drawing.Point(385, 33);
            this.cbboxLoaiNv.Name = "cbboxLoaiNv";
            this.cbboxLoaiNv.Size = new System.Drawing.Size(121, 24);
            this.cbboxLoaiNv.TabIndex = 4;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(12, 36);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(56, 16);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "Từ khóa";
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.Location = new System.Drawing.Point(91, 33);
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.Size = new System.Drawing.Size(271, 22);
            this.txtboxSearch.TabIndex = 6;
            // 
            // frmTableSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtboxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.cbboxLoaiNv);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTableSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng lương";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Senority;
        private System.Windows.Forms.DataGridViewTextBoxColumn Worktime;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalculatedSalary;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.ComboBox cbboxLoaiNv;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtboxSearch;
    }
}