
namespace OlympicMedalListManagementSystem.Administrator
{
    partial class ManageAthletesForm
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
            this.dgvDatas = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtCountryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddAthlete = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnEditAthlete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatas
            // 
            this.dgvDatas.AllowUserToAddRows = false;
            this.dgvDatas.AllowUserToDeleteRows = false;
            this.dgvDatas.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatas.Location = new System.Drawing.Point(0, 143);
            this.dgvDatas.MultiSelect = false;
            this.dgvDatas.Name = "dgvDatas";
            this.dgvDatas.ReadOnly = true;
            this.dgvDatas.RowTemplate.Height = 100;
            this.dgvDatas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatas.Size = new System.Drawing.Size(925, 426);
            this.dgvDatas.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(335, 91);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 32);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtCountryName
            // 
            this.txtCountryName.Location = new System.Drawing.Point(129, 95);
            this.txtCountryName.Name = "txtCountryName";
            this.txtCountryName.Size = new System.Drawing.Size(187, 26);
            this.txtCountryName.TabIndex = 6;
            this.txtCountryName.TextChanged += new System.EventHandler(this.txtCountryName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Athlete Name:";
            // 
            // AddAthlete
            // 
            this.AddAthlete.Location = new System.Drawing.Point(15, 586);
            this.AddAthlete.Name = "AddAthlete";
            this.AddAthlete.Size = new System.Drawing.Size(109, 32);
            this.AddAthlete.TabIndex = 7;
            this.AddAthlete.Text = "Add Athlete";
            this.AddAthlete.UseVisualStyleBackColor = true;
            this.AddAthlete.Click += new System.EventHandler(this.AddAthlete_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(240, 586);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(204, 32);
            this.btnImport.TabIndex = 7;
            this.btnImport.Text = "Import data from csv";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnEditAthlete
            // 
            this.btnEditAthlete.Location = new System.Drawing.Point(125, 586);
            this.btnEditAthlete.Name = "btnEditAthlete";
            this.btnEditAthlete.Size = new System.Drawing.Size(109, 32);
            this.btnEditAthlete.TabIndex = 7;
            this.btnEditAthlete.Text = "Edit Athlete";
            this.btnEditAthlete.UseVisualStyleBackColor = true;
            this.btnEditAthlete.Click += new System.EventHandler(this.btnEditAthlete_Click);
            // 
            // ManageAthletesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 630);
            this.Controls.Add(this.dgvDatas);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnEditAthlete);
            this.Controls.Add(this.AddAthlete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCountryName);
            this.Controls.Add(this.label1);
            this.Name = "ManageAthletesForm";
            this.Text = "ManageAthletesForm";
            this.Load += new System.EventHandler(this.ManageAthletesForm_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtCountryName, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.AddAthlete, 0);
            this.Controls.SetChildIndex(this.btnEditAthlete, 0);
            this.Controls.SetChildIndex(this.btnImport, 0);
            this.Controls.SetChildIndex(this.dgvDatas, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatas;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtCountryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddAthlete;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnEditAthlete;
    }
}