
namespace OlympicMedalListManagementSystem.Employee
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
            this.lWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMedalList = new System.Windows.Forms.Button();
            this.btnNewsList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.Size = new System.Drawing.Size(178, 27);
            this.lTitle.Text = "Main-Employee";
            // 
            // lWelcome
            // 
            this.lWelcome.AutoSize = true;
            this.lWelcome.Location = new System.Drawing.Point(68, 92);
            this.lWelcome.Name = "lWelcome";
            this.lWelcome.Size = new System.Drawing.Size(50, 18);
            this.lWelcome.TabIndex = 6;
            this.lWelcome.Text = "label1";
            // 
            // btnLogout
            // 
            this.btnLogout.ForeColor = System.Drawing.Color.Blue;
            this.btnLogout.Location = new System.Drawing.Point(254, 280);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(277, 41);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "注销";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(254, 337);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(277, 41);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMedalList
            // 
            this.btnMedalList.Location = new System.Drawing.Point(254, 159);
            this.btnMedalList.Name = "btnMedalList";
            this.btnMedalList.Size = new System.Drawing.Size(277, 41);
            this.btnMedalList.TabIndex = 5;
            this.btnMedalList.Text = "奖牌榜";
            this.btnMedalList.UseVisualStyleBackColor = true;
            this.btnMedalList.Click += new System.EventHandler(this.btnMedalList_Click);
            // 
            // btnNewsList
            // 
            this.btnNewsList.Location = new System.Drawing.Point(254, 221);
            this.btnNewsList.Name = "btnNewsList";
            this.btnNewsList.Size = new System.Drawing.Size(277, 41);
            this.btnNewsList.TabIndex = 5;
            this.btnNewsList.Text = "新闻列表";
            this.btnNewsList.UseVisualStyleBackColor = true;
            this.btnNewsList.Click += new System.EventHandler(this.btnNewsList_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lWelcome);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewsList);
            this.Controls.Add(this.btnMedalList);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Controls.SetChildIndex(this.btnMedalList, 0);
            this.Controls.SetChildIndex(this.btnNewsList, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.btnLogout, 0);
            this.Controls.SetChildIndex(this.lWelcome, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMedalList;
        private System.Windows.Forms.Button btnNewsList;
    }
}