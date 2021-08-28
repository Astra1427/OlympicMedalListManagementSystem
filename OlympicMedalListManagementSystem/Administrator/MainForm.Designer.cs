
namespace OlympicMedalListManagementSystem.Administrator
{
    partial class MainForm
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
            this.btnManageCountry = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSportEventManage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageCountry
            // 
            this.btnManageCountry.Location = new System.Drawing.Point(255, 155);
            this.btnManageCountry.Name = "btnManageCountry";
            this.btnManageCountry.Size = new System.Drawing.Size(277, 41);
            this.btnManageCountry.TabIndex = 1;
            this.btnManageCountry.Text = "Country Manage";
            this.btnManageCountry.UseVisualStyleBackColor = true;
            this.btnManageCountry.Click += new System.EventHandler(this.btnManageCountry_Click);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(255, 337);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(277, 41);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lWelcome
            // 
            this.lWelcome.AutoSize = true;
            this.lWelcome.Location = new System.Drawing.Point(69, 88);
            this.lWelcome.Name = "lWelcome";
            this.lWelcome.Size = new System.Drawing.Size(50, 18);
            this.lWelcome.TabIndex = 2;
            this.lWelcome.Text = "label1";
            // 
            // btnLogout
            // 
            this.btnLogout.ForeColor = System.Drawing.Color.Blue;
            this.btnLogout.Location = new System.Drawing.Point(255, 280);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(277, 41);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSportEventManage
            // 
            this.btnSportEventManage.Location = new System.Drawing.Point(255, 213);
            this.btnSportEventManage.Name = "btnSportEventManage";
            this.btnSportEventManage.Size = new System.Drawing.Size(277, 41);
            this.btnSportEventManage.TabIndex = 1;
            this.btnSportEventManage.Text = "Sport Event Manage";
            this.btnSportEventManage.UseVisualStyleBackColor = true;
            this.btnSportEventManage.Click += new System.EventHandler(this.btnSportEventManage_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lWelcome);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSportEventManage);
            this.Controls.Add(this.btnManageCountry);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Controls.SetChildIndex(this.btnManageCountry, 0);
            this.Controls.SetChildIndex(this.btnSportEventManage, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.btnLogout, 0);
            this.Controls.SetChildIndex(this.lWelcome, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManageCountry;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSportEventManage;
    }
}