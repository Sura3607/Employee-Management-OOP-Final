namespace Managenment_Windows
{
    partial class frmPayroll
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LoaiNhanVien = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTuKhoa = new System.Windows.Forms.Label();
            this.btnLoadEmployData = new System.Windows.Forms.Button();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Worktime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeID,
            this.Name,
            this.Position,
            this.Worktime,
            this.BaseSalary,
            this.Salary});
            this.dataGridView1.Location = new System.Drawing.Point(25, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(744, 287);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // LoaiNhanVien
            // 
            this.LoaiNhanVien.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LoaiNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LoaiNhanVien.FormattingEnabled = true;
            this.LoaiNhanVien.Items.AddRange(new object[] {
            "Full time",
            "Part time",
            "All"});
            this.LoaiNhanVien.Location = new System.Drawing.Point(322, 45);
            this.LoaiNhanVien.Name = "LoaiNhanVien";
            this.LoaiNhanVien.Size = new System.Drawing.Size(131, 24);
            this.LoaiNhanVien.TabIndex = 3;
            this.LoaiNhanVien.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(87, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(217, 22);
            this.txtSearch.TabIndex = 4;
            // 
            // lblTuKhoa
            // 
            this.lblTuKhoa.AutoSize = true;
            this.lblTuKhoa.Location = new System.Drawing.Point(22, 45);
            this.lblTuKhoa.Name = "lblTuKhoa";
            this.lblTuKhoa.Size = new System.Drawing.Size(59, 16);
            this.lblTuKhoa.TabIndex = 5;
            this.lblTuKhoa.Text = "Từ khóa ";
            this.lblTuKhoa.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLoadEmployData
            // 
            this.btnLoadEmployData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLoadEmployData.Location = new System.Drawing.Point(613, 381);
            this.btnLoadEmployData.Name = "btnLoadEmployData";
            this.btnLoadEmployData.Size = new System.Drawing.Size(156, 48);
            this.btnLoadEmployData.TabIndex = 6;
            this.btnLoadEmployData.Text = "Tải dữ liệu";
            this.btnLoadEmployData.UseVisualStyleBackColor = false;
            this.btnLoadEmployData.Click += new System.EventHandler(this.btnLoadEmployData_Click);
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "ID";
            this.EmployeeID.HeaderText = "ID";
            this.EmployeeID.MinimumWidth = 6;
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.ReadOnly = true;
            this.EmployeeID.Width = 75;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Tên";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 150;
            // 
            // Position
            // 
            this.Position.DataPropertyName = "Senority";
            this.Position.HeaderText = "Thâm niên";
            this.Position.MinimumWidth = 6;
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            this.Position.Width = 90;
            // 
            // Worktime
            // 
            this.Worktime.DataPropertyName = "Worktime";
            this.Worktime.HeaderText = "Giờ làm";
            this.Worktime.MinimumWidth = 6;
            this.Worktime.Name = "Worktime";
            this.Worktime.ReadOnly = true;
            this.Worktime.Width = 90;
            // 
            // BaseSalary
            // 
            this.BaseSalary.DataPropertyName = "Salary";
            this.BaseSalary.HeaderText = "Lương cơ bản";
            this.BaseSalary.MinimumWidth = 6;
            this.BaseSalary.Name = "BaseSalary";
            this.BaseSalary.ReadOnly = true;
            this.BaseSalary.Width = 90;
            // 
            // Salary
            // 
            this.Salary.HeaderText = "Mức lương";
            this.Salary.MinimumWidth = 6;
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            this.Salary.Width = 90;
            // 
            // frmPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoadEmployData);
            this.Controls.Add(this.lblTuKhoa);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.LoaiNhanVien);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmPayroll";
            this.Text = "frmPayroll";
            this.Load += new System.EventHandler(this.frmPayroll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox LoaiNhanVien;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblTuKhoa;
        private System.Windows.Forms.Button btnLoadEmployData;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Worktime;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
    }
}