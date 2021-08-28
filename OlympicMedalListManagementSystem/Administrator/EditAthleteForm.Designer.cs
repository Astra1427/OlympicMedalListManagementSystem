
namespace OlympicMedalListManagementSystem.Administrator
{
    partial class EditAthleteForm
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
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.pbFlag = new System.Windows.Forms.PictureBox();
            this.pbPortrait = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPortrait = new System.Windows.Forms.TextBox();
            this.txtAthleteName = new System.Windows.Forms.TextBox();
            this.lCountryName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortrait)).BeginInit();
            this.SuspendLayout();
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(262, 158);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(79, 22);
            this.rbFemale.TabIndex = 30;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(193, 158);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(60, 22);
            this.rbMale.TabIndex = 31;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.CustomFormat = "yyyy-MM-dd";
            this.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthdate.Location = new System.Drawing.Point(191, 185);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(200, 26);
            this.dtpBirthdate.TabIndex = 29;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(193, 460);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 31);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Save";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(193, 426);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(75, 23);
            this.btnChoose.TabIndex = 27;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // pbFlag
            // 
            this.pbFlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFlag.Image = global::OlympicMedalListManagementSystem.Properties.Resources.olympic_games;
            this.pbFlag.Location = new System.Drawing.Point(440, 71);
            this.pbFlag.Name = "pbFlag";
            this.pbFlag.Size = new System.Drawing.Size(55, 46);
            this.pbFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFlag.TabIndex = 25;
            this.pbFlag.TabStop = false;
            // 
            // pbPortrait
            // 
            this.pbPortrait.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPortrait.Image = global::OlympicMedalListManagementSystem.Properties.Resources.olympic_games;
            this.pbPortrait.Location = new System.Drawing.Point(193, 251);
            this.pbPortrait.Name = "pbPortrait";
            this.pbPortrait.Size = new System.Drawing.Size(148, 169);
            this.pbPortrait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPortrait.TabIndex = 26;
            this.pbPortrait.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Portrait:";
            // 
            // txtPortrait
            // 
            this.txtPortrait.Location = new System.Drawing.Point(191, 219);
            this.txtPortrait.Name = "txtPortrait";
            this.txtPortrait.ReadOnly = true;
            this.txtPortrait.Size = new System.Drawing.Size(302, 26);
            this.txtPortrait.TabIndex = 22;
            this.txtPortrait.Text = "Olympic.png";
            // 
            // txtAthleteName
            // 
            this.txtAthleteName.Location = new System.Drawing.Point(193, 120);
            this.txtAthleteName.Name = "txtAthleteName";
            this.txtAthleteName.Size = new System.Drawing.Size(302, 26);
            this.txtAthleteName.TabIndex = 23;
            // 
            // lCountryName
            // 
            this.lCountryName.AutoSize = true;
            this.lCountryName.Location = new System.Drawing.Point(190, 87);
            this.lCountryName.Name = "lCountryName";
            this.lCountryName.Size = new System.Drawing.Size(111, 18);
            this.lCountryName.TabIndex = 17;
            this.lCountryName.Text = "Country Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Country Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Birthdate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Sex:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Athlete Name:";
            // 
            // EditAthleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 511);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.dtpBirthdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.pbFlag);
            this.Controls.Add(this.pbPortrait);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPortrait);
            this.Controls.Add(this.txtAthleteName);
            this.Controls.Add(this.lCountryName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "EditAthleteForm";
            this.Text = "EditAthleteForm";
            this.Load += new System.EventHandler(this.EditAthleteForm_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lCountryName, 0);
            this.Controls.SetChildIndex(this.txtAthleteName, 0);
            this.Controls.SetChildIndex(this.txtPortrait, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.pbPortrait, 0);
            this.Controls.SetChildIndex(this.pbFlag, 0);
            this.Controls.SetChildIndex(this.btnChoose, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.dtpBirthdate, 0);
            this.Controls.SetChildIndex(this.rbMale, 0);
            this.Controls.SetChildIndex(this.rbFemale, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortrait)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.PictureBox pbFlag;
        private System.Windows.Forms.PictureBox pbPortrait;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPortrait;
        private System.Windows.Forms.TextBox txtAthleteName;
        private System.Windows.Forms.Label lCountryName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}