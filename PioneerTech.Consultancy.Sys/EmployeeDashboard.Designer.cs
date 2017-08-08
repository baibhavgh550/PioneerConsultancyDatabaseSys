namespace PioneerTech.Consultancy.Sys
{
    partial class EmployeeDashboard
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
            this.gridViewEmployee = new System.Windows.Forms.DataGridView();
            this.gridViewCompany = new System.Windows.Forms.DataGridView();
            this.gridViewProject = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CompanyDetails = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProject)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewEmployee
            // 
            this.gridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewEmployee.Location = new System.Drawing.Point(10, 27);
            this.gridViewEmployee.Name = "gridViewEmployee";
            this.gridViewEmployee.Size = new System.Drawing.Size(460, 129);
            this.gridViewEmployee.TabIndex = 0;
            this.gridViewEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewEmployee_CellContentClick);
            // 
            // gridViewCompany
            // 
            this.gridViewCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewCompany.Location = new System.Drawing.Point(11, 178);
            this.gridViewCompany.Name = "gridViewCompany";
            this.gridViewCompany.Size = new System.Drawing.Size(459, 134);
            this.gridViewCompany.TabIndex = 1;
            // 
            // gridViewProject
            // 
            this.gridViewProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewProject.Location = new System.Drawing.Point(11, 337);
            this.gridViewProject.Name = "gridViewProject";
            this.gridViewProject.Size = new System.Drawing.Size(459, 133);
            this.gridViewProject.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // CompanyDetails
            // 
            this.CompanyDetails.AutoSize = true;
            this.CompanyDetails.Location = new System.Drawing.Point(12, 162);
            this.CompanyDetails.Name = "CompanyDetails";
            this.CompanyDetails.Size = new System.Drawing.Size(86, 13);
            this.CompanyDetails.TabIndex = 5;
            this.CompanyDetails.Text = "Company Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Project Details";
            // 
            // EmployeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(483, 466);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CompanyDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridViewProject);
            this.Controls.Add(this.gridViewCompany);
            this.Controls.Add(this.gridViewEmployee);
            this.Name = "EmployeeDashboard";
            this.Text = "EmployeeDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewEmployee;
        private System.Windows.Forms.DataGridView gridViewCompany;
        private System.Windows.Forms.DataGridView gridViewProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CompanyDetails;
        private System.Windows.Forms.Label label3;
    }
}