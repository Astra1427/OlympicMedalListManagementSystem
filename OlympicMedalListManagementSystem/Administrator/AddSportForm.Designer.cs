
namespace OlympicMedalListManagementSystem.Administrator
{
    partial class AddSportForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIcon = new System.Windows.Forms.TextBox();
            this.txtSportName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(129, 400);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 38);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(129, 353);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(75, 23);
            this.btnChoose.TabIndex = 12;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // pbIcon
            // 
            this.pbIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbIcon.Image = global::OlympicMedalListManagementSystem.Properties.Resources.olympic_games;
            this.pbIcon.Location = new System.Drawing.Point(129, 153);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(199, 194);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 11;
            this.pbIcon.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Icon:";
            // 
            // txtIcon
            // 
            this.txtIcon.Location = new System.Drawing.Point(129, 117);
            this.txtIcon.Name = "txtIcon";
            this.txtIcon.ReadOnly = true;
            this.txtIcon.Size = new System.Drawing.Size(199, 26);
            this.txtIcon.TabIndex = 8;
            this.txtIcon.Text = "Olympic.png";
            // 
            // txtSportName
            // 
            this.txtSportName.Location = new System.Drawing.Point(129, 77);
            this.txtSportName.Name = "txtSportName";
            this.txtSportName.Size = new System.Drawing.Size(199, 26);
            this.txtSportName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sport Name:";
            // 
            // AddSportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 450);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIcon);
            this.Controls.Add(this.txtSportName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddSportForm";
            this.Text = "AddSportForm";
            this.Load += new System.EventHandler(this.AddSportForm_Load);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtSportName, 0);
            this.Controls.SetChildIndex(this.txtIcon, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.pbIcon, 0);
            this.Controls.SetChildIndex(this.btnChoose, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIcon;
        private System.Windows.Forms.TextBox txtSportName;
        private System.Windows.Forms.Label label1;
    }
}