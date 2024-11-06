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
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(957, 458);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.btnTroLai.Location = new System.Drawing.Point(796, 488);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(157, 40);
            this.btnTroLai.TabIndex = 1;
            this.btnTroLai.Text = "Trở lại";
            this.btnTroLai.UseVisualStyleBackColor = false;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // frmTableSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(981, 553);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTableSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng lương";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

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
    }
}