
namespace OlympicMedalListManagementSystem.Administrator
{
    partial class ManageCountryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCountryName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvDatas = new System.Windows.Forms.DataGridView();
            this.btnAddCountry = new System.Windows.Forms.Button();
            this.btnMangeAthlete = new System.Windows.Forms.Button();
            this.btnEditCountry = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Country Name:";
            // 
            // txtCountryName
            // 
            this.txtCountryName.Location = new System.Drawing.Point(129, 83);
            this.txtCountryName.Name = "txtCountryName";
            this.txtCountryName.Size = new System.Drawing.Size(187, 26);
            this.txtCountryName.TabIndex = 2;
            this.txtCountryName.TextChanged += new System.EventHandler(this.txtCountryName_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(335, 79);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 32);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvDatas
            // 
            this.dgvDatas.AllowUserToAddRows = false;
            this.dgvDatas.AllowUserToDeleteRows = false;
            this.dgvDatas.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatas.Location = new System.Drawing.Point(0, 131);
            this.dgvDatas.MultiSelect = false;
            this.dgvDatas.Name = "dgvDatas";
            this.dgvDatas.ReadOnly = true;
            this.dgvDatas.RowTemplate.Height = 100;
            this.dgvDatas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatas.Size = new System.Drawing.Size(811, 398);
            this.dgvDatas.TabIndex = 4;
            // 
            // btnAddCountry
            // 
            this.btnAddCountry.Location = new System.Drawing.Point(12, 535);
            this.btnAddCountry.Name = "btnAddCountry";
            this.btnAddCountry.Size = new System.Drawing.Size(111, 32);
            this.btnAddCountry.TabIndex = 5;
            this.btnAddCountry.Text = "Add Country";
            this.btnAddCountry.UseVisualStyleBackColor = true;
            this.btnAddCountry.Click += new System.EventHandler(this.btnAddCountry_Click);
            // 
            // btnMangeAthlete
            // 
            this.btnMangeAthlete.Location = new System.Drawing.Point(281, 537);
            this.btnMangeAthlete.Name = "btnMangeAthlete";
            this.btnMangeAthlete.Size = new System.Drawing.Size(417, 32);
            this.btnMangeAthlete.TabIndex = 5;
            this.btnMangeAthlete.Text = "Manage Athlete";
            this.btnMangeAthlete.UseVisualStyleBackColor = true;
            this.btnMangeAthlete.Visible = false;
            this.btnMangeAthlete.Click += new System.EventHandler(this.btnMangeAthlete_Click);
            // 
            // btnEditCountry
            // 
            this.btnEditCountry.Location = new System.Drawing.Point(129, 535);
            this.btnEditCountry.Name = "btnEditCountry";
            this.btnEditCountry.Size = new System.Drawing.Size(111, 32);
            this.btnEditCountry.TabIndex = 5;
            this.btnEditCountry.Text = "Edit Country";
            this.btnEditCountry.UseVisualStyleBackColor = true;
            this.btnEditCountry.Click += new System.EventHandler(this.btnEditCountry_Click);
            // 
            // ManageCountryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 581);
            this.Controls.Add(this.btnMangeAthlete);
            this.Controls.Add(this.btnEditCountry);
            this.Controls.Add(this.btnAddCountry);
            this.Controls.Add(this.dgvDatas);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCountryName);
            this.Controls.Add(this.label1);
            this.Name = "ManageCountryForm";
            this.Text = "ManageCountryForm";
            this.Load += new System.EventHandler(this.ManageCountryForm_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtCountryName, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.dgvDatas, 0);
            this.Controls.SetChildIndex(this.btnAddCountry, 0);
            this.Controls.SetChildIndex(this.btnEditCountry, 0);
            this.Controls.SetChildIndex(this.btnMangeAthlete, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCountryName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvDatas;
        private System.Windows.Forms.Button btnAddCountry;
        private System.Windows.Forms.Button btnMangeAthlete;
        private System.Windows.Forms.Button btnEditCountry;
    }
}