
namespace OlympicMedalListManagementSystem.Employee
{
    partial class AddMedalForm
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
            this.lAthleteName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSport = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMedalType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.pbPortrait = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortrait)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Athlete Name:";
            // 
            // lAthleteName
            // 
            this.lAthleteName.AutoSize = true;
            this.lAthleteName.Location = new System.Drawing.Point(135, 86);
            this.lAthleteName.Name = "lAthleteName";
            this.lAthleteName.Size = new System.Drawing.Size(50, 18);
            this.lAthleteName.TabIndex = 1;
            this.lAthleteName.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sport Name:";
            // 
            // cbSport
            // 
            this.cbSport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSport.FormattingEnabled = true;
            this.cbSport.Location = new System.Drawing.Point(135, 131);
            this.cbSport.Name = "cbSport";
            this.cbSport.Size = new System.Drawing.Size(196, 26);
            this.cbSport.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Medal Type:";
            // 
            // cbMedalType
            // 
            this.cbMedalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedalType.FormattingEnabled = true;
            this.cbMedalType.Items.AddRange(new object[] {
            "Gold Medal",
            "Silver Medal",
            "Bronze Medal"});
            this.cbMedalType.Location = new System.Drawing.Point(135, 167);
            this.cbMedalType.Name = "cbMedalType";
            this.cbMedalType.Size = new System.Drawing.Size(196, 26);
            this.cbMedalType.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Time:";
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(135, 203);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(196, 26);
            this.dtpTime.TabIndex = 3;
            // 
            // pbPortrait
            // 
            this.pbPortrait.Location = new System.Drawing.Point(282, 72);
            this.pbPortrait.Name = "pbPortrait";
            this.pbPortrait.Size = new System.Drawing.Size(49, 53);
            this.pbPortrait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPortrait.TabIndex = 4;
            this.pbPortrait.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(135, 260);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddMedalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 507);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pbPortrait);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.cbMedalType);
            this.Controls.Add(this.cbSport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lAthleteName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AddMedalForm";
            this.Text = "AddMedalForm";
            this.Load += new System.EventHandler(this.AddMedalForm_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lAthleteName, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.cbSport, 0);
            this.Controls.SetChildIndex(this.cbMedalType, 0);
            this.Controls.SetChildIndex(this.dtpTime, 0);
            this.Controls.SetChildIndex(this.pbPortrait, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbPortrait)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lAthleteName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMedalType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.PictureBox pbPortrait;
        private System.Windows.Forms.Button btnAdd;
    }
}