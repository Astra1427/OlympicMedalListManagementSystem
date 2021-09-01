
namespace OlympicMedalListManagementSystem.Employee
{
    partial class EditNewsForm
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
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbGoldNews = new System.Windows.Forms.CheckBox();
            this.lSportName = new System.Windows.Forms.Label();
            this.pbSportIcon = new System.Windows.Forms.PictureBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSportIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(118, 160);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(489, 379);
            this.txtContent.TabIndex = 15;
            this.txtContent.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(118, 558);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(185, 50);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Content:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(120, 74);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(233, 26);
            this.txtTitle.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Title:";
            // 
            // cbGoldNews
            // 
            this.cbGoldNews.AutoSize = true;
            this.cbGoldNews.Location = new System.Drawing.Point(504, 126);
            this.cbGoldNews.Name = "cbGoldNews";
            this.cbGoldNews.Size = new System.Drawing.Size(103, 22);
            this.cbGoldNews.TabIndex = 20;
            this.cbGoldNews.Text = "Gold News";
            this.cbGoldNews.UseVisualStyleBackColor = true;
            // 
            // lSportName
            // 
            this.lSportName.AutoSize = true;
            this.lSportName.Location = new System.Drawing.Point(272, 126);
            this.lSportName.Name = "lSportName";
            this.lSportName.Size = new System.Drawing.Size(50, 18);
            this.lSportName.TabIndex = 19;
            this.lSportName.Text = "label4";
            // 
            // pbSportIcon
            // 
            this.pbSportIcon.Image = global::OlympicMedalListManagementSystem.Properties.Resources.乒乓球;
            this.pbSportIcon.Location = new System.Drawing.Point(215, 106);
            this.pbSportIcon.Name = "pbSportIcon";
            this.pbSportIcon.Size = new System.Drawing.Size(51, 50);
            this.pbSportIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSportIcon.TabIndex = 18;
            this.pbSportIcon.TabStop = false;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(118, 121);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(75, 23);
            this.btnChoose.TabIndex = 17;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Choose Sport:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditNewsForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 622);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbGoldNews);
            this.Controls.Add(this.lSportName);
            this.Controls.Add(this.pbSportIcon);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Name = "EditNewsForm";
            this.Text = "EditNewsForm";
            this.Load += new System.EventHandler(this.EditNewsForm_Load);
            this.Shown += new System.EventHandler(this.EditNewsForm_Shown);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtTitle, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.txtContent, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btnChoose, 0);
            this.Controls.SetChildIndex(this.pbSportIcon, 0);
            this.Controls.SetChildIndex(this.lSportName, 0);
            this.Controls.SetChildIndex(this.cbGoldNews, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbSportIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbGoldNews;
        private System.Windows.Forms.Label lSportName;
        private System.Windows.Forms.PictureBox pbSportIcon;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}