
namespace OlympicMedalListManagementSystem.Employee
{
    partial class MedalListForm
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
            this.dgvCountries = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAthletes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.pMiddleLine = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddMedal = new System.Windows.Forms.Button();
            this.txtCountryName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearchCountry = new System.Windows.Forms.Button();
            this.btnSearchAthlete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAthlete = new System.Windows.Forms.TextBox();
            this.btnLimitSwitch = new System.Windows.Forms.Button();
            this.lTotalNumbersAthletes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAthletes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCountries
            // 
            this.dgvCountries.BackgroundColor = System.Drawing.Color.White;
            this.dgvCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCountries.Location = new System.Drawing.Point(15, 154);
            this.dgvCountries.MultiSelect = false;
            this.dgvCountries.Name = "dgvCountries";
            this.dgvCountries.RowTemplate.Height = 100;
            this.dgvCountries.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCountries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCountries.Size = new System.Drawing.Size(610, 565);
            this.dgvCountries.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Country Medal List";
            // 
            // dgvAthletes
            // 
            this.dgvAthletes.BackgroundColor = System.Drawing.Color.White;
            this.dgvAthletes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAthletes.Location = new System.Drawing.Point(658, 194);
            this.dgvAthletes.MultiSelect = false;
            this.dgvAthletes.Name = "dgvAthletes";
            this.dgvAthletes.RowTemplate.Height = 75;
            this.dgvAthletes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAthletes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAthletes.Size = new System.Drawing.Size(610, 525);
            this.dgvAthletes.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(655, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Athlete Medal List";
            // 
            // pMiddleLine
            // 
            this.pMiddleLine.BackColor = System.Drawing.Color.LightGray;
            this.pMiddleLine.Location = new System.Drawing.Point(640, -61);
            this.pMiddleLine.Name = "pMiddleLine";
            this.pMiddleLine.Size = new System.Drawing.Size(1, 800);
            this.pMiddleLine.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(0, 738);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1290, 1);
            this.panel2.TabIndex = 4;
            // 
            // btnAddMedal
            // 
            this.btnAddMedal.Location = new System.Drawing.Point(12, 754);
            this.btnAddMedal.Name = "btnAddMedal";
            this.btnAddMedal.Size = new System.Drawing.Size(107, 34);
            this.btnAddMedal.TabIndex = 5;
            this.btnAddMedal.Text = "Add Medal";
            this.btnAddMedal.UseVisualStyleBackColor = true;
            this.btnAddMedal.Click += new System.EventHandler(this.btnAddMedal_Click);
            // 
            // txtCountryName
            // 
            this.txtCountryName.Location = new System.Drawing.Point(129, 118);
            this.txtCountryName.Name = "txtCountryName";
            this.txtCountryName.Size = new System.Drawing.Size(273, 26);
            this.txtCountryName.TabIndex = 12;
            this.txtCountryName.TextChanged += new System.EventHandler(this.txtCountryName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Country Name:";
            // 
            // btnSearchCountry
            // 
            this.btnSearchCountry.Location = new System.Drawing.Point(405, 113);
            this.btnSearchCountry.Name = "btnSearchCountry";
            this.btnSearchCountry.Size = new System.Drawing.Size(86, 34);
            this.btnSearchCountry.TabIndex = 5;
            this.btnSearchCountry.Text = "Search";
            this.btnSearchCountry.UseVisualStyleBackColor = true;
            this.btnSearchCountry.Click += new System.EventHandler(this.btnSearchCountry_Click);
            // 
            // btnSearchAthlete
            // 
            this.btnSearchAthlete.Location = new System.Drawing.Point(1048, 113);
            this.btnSearchAthlete.Name = "btnSearchAthlete";
            this.btnSearchAthlete.Size = new System.Drawing.Size(86, 34);
            this.btnSearchAthlete.TabIndex = 5;
            this.btnSearchAthlete.Text = "Search";
            this.btnSearchAthlete.UseVisualStyleBackColor = true;
            this.btnSearchAthlete.Click += new System.EventHandler(this.btnSearchAthlete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(655, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Athlete Name:";
            // 
            // txtAthlete
            // 
            this.txtAthlete.Location = new System.Drawing.Point(772, 118);
            this.txtAthlete.Name = "txtAthlete";
            this.txtAthlete.Size = new System.Drawing.Size(273, 26);
            this.txtAthlete.TabIndex = 12;
            this.txtAthlete.TextChanged += new System.EventHandler(this.txtAthlete_TextChanged);
            // 
            // btnLimitSwitch
            // 
            this.btnLimitSwitch.BackColor = System.Drawing.Color.White;
            this.btnLimitSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimitSwitch.Location = new System.Drawing.Point(627, 215);
            this.btnLimitSwitch.Name = "btnLimitSwitch";
            this.btnLimitSwitch.Size = new System.Drawing.Size(29, 23);
            this.btnLimitSwitch.TabIndex = 13;
            this.btnLimitSwitch.Text = ">";
            this.btnLimitSwitch.UseVisualStyleBackColor = false;
            this.btnLimitSwitch.Click += new System.EventHandler(this.btnLimitSwitch_Click);
            // 
            // lTotalNumbersAthletes
            // 
            this.lTotalNumbersAthletes.AutoSize = true;
            this.lTotalNumbersAthletes.Location = new System.Drawing.Point(655, 154);
            this.lTotalNumbersAthletes.Name = "lTotalNumbersAthletes";
            this.lTotalNumbersAthletes.Size = new System.Drawing.Size(244, 18);
            this.lTotalNumbersAthletes.TabIndex = 11;
            this.lTotalNumbersAthletes.Text = "The total numbers of athletes is 10";
            // 
            // MedalListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.btnLimitSwitch);
            this.Controls.Add(this.txtAthlete);
            this.Controls.Add(this.txtCountryName);
            this.Controls.Add(this.lTotalNumbersAthletes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSearchAthlete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearchCountry);
            this.Controls.Add(this.btnAddMedal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAthletes);
            this.Controls.Add(this.dgvCountries);
            this.Controls.Add(this.pMiddleLine);
            this.Name = "MedalListForm";
            this.Text = "MedalListForm";
            this.Load += new System.EventHandler(this.MedalListForm_Load);
            this.Controls.SetChildIndex(this.pMiddleLine, 0);
            this.Controls.SetChildIndex(this.dgvCountries, 0);
            this.Controls.SetChildIndex(this.dgvAthletes, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.btnAddMedal, 0);
            this.Controls.SetChildIndex(this.btnSearchCountry, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btnSearchAthlete, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.lTotalNumbersAthletes, 0);
            this.Controls.SetChildIndex(this.txtCountryName, 0);
            this.Controls.SetChildIndex(this.txtAthlete, 0);
            this.Controls.SetChildIndex(this.btnLimitSwitch, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAthletes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCountries;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAthletes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pMiddleLine;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddMedal;
        private System.Windows.Forms.TextBox txtCountryName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearchCountry;
        private System.Windows.Forms.Button btnSearchAthlete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAthlete;
        private System.Windows.Forms.Button btnLimitSwitch;
        private System.Windows.Forms.Label lTotalNumbersAthletes;
    }
}