
namespace OlympicMedalListManagementSystem.Administrator
{
    partial class AddCountryForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.pbFlag = new System.Windows.Forms.PictureBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.txtFlag = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            
            ((System.ComponentModel.ISupportInitialize)(this.pbFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Country Name:";
            // 
            // txtCountryName
            // 
            this.txtCountryName.Location = new System.Drawing.Point(138, 78);
            this.txtCountryName.Name = "txtCountryName";
            this.txtCountryName.Size = new System.Drawing.Size(302, 26);
            this.txtCountryName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Flag:";
            // 
            // pbFlag
            // 
            this.pbFlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFlag.Image = global::OlympicMedalListManagementSystem.Properties.Resources.olympic_games;
            this.pbFlag.Location = new System.Drawing.Point(138, 154);
            this.pbFlag.Name = "pbFlag";
            this.pbFlag.Size = new System.Drawing.Size(302, 169);
            this.pbFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFlag.TabIndex = 5;
            this.pbFlag.TabStop = false;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(138, 329);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(75, 23);
            this.btnChoose.TabIndex = 6;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // txtFlag
            // 
            this.txtFlag.Location = new System.Drawing.Point(138, 122);
            this.txtFlag.Name = "txtFlag";
            this.txtFlag.ReadOnly = true;
            this.txtFlag.Size = new System.Drawing.Size(302, 26);
            this.txtFlag.TabIndex = 3;
            this.txtFlag.Text = "Olympic.png";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(138, 371);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 31);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddCountryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 430);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.pbFlag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFlag);
            this.Controls.Add(this.txtCountryName);
            this.Controls.Add(this.label1);
            this.Name = "AddCountryForm";
            this.Text = "AddCountryForm";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtCountryName, 0);
            this.Controls.SetChildIndex(this.txtFlag, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.pbFlag, 0);
            this.Controls.SetChildIndex(this.btnChoose, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbFlag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCountryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbFlag;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.TextBox txtFlag;
        private System.Windows.Forms.Button btnAdd;
    }
}