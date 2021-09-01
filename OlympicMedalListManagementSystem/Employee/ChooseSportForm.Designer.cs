
namespace OlympicMedalListManagementSystem.Employee
{
    partial class ChooseSportForm
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
            this.flpSports = new System.Windows.Forms.FlowLayoutPanel();
            this.lDemo = new System.Windows.Forms.Label();
            this.flpSports.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpSports
            // 
            this.flpSports.AutoScroll = true;
            this.flpSports.Controls.Add(this.lDemo);
            this.flpSports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSports.Location = new System.Drawing.Point(0, 65);
            this.flpSports.Name = "flpSports";
            this.flpSports.Size = new System.Drawing.Size(865, 488);
            this.flpSports.TabIndex = 1;
            // 
            // lDemo
            // 
            this.lDemo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(85)))), ((int)(((byte)(179)))));
            this.lDemo.Font = new System.Drawing.Font("Arial", 20F);
            this.lDemo.ForeColor = System.Drawing.Color.White;
            this.lDemo.Image = global::OlympicMedalListManagementSystem.Properties.Resources.乒乓球;
            this.lDemo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lDemo.Location = new System.Drawing.Point(3, 0);
            this.lDemo.Name = "lDemo";
            this.lDemo.Size = new System.Drawing.Size(169, 199);
            this.lDemo.TabIndex = 0;
            this.lDemo.Text = "label1";
            this.lDemo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lDemo.Visible = false;
            // 
            // ChooseSportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 553);
            this.Controls.Add(this.flpSports);
            this.Name = "ChooseSportForm";
            this.Text = "ChooseSportForm";
            this.Load += new System.EventHandler(this.ChooseSportForm_Load);
            this.Controls.SetChildIndex(this.flpSports, 0);
            this.flpSports.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpSports;
        private System.Windows.Forms.Label lDemo;
    }
}