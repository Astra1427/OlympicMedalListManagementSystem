using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlympicMedalListManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool IsExit { get; set;}
        public bool IsNoTips = true;
        public bool IsShowOwner = true;

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsNoTips)
            {
                if (IsExit)
                {
                    Application.ExitThread();
                    Application.Exit();
                }
                else
                {
                    if (this.Owner!=null&&IsShowOwner)
                    {
                        Owner.Show();
                    }
                }
                return;
            }

            if (MessageBox.Show("Are you sure close?", "Tips", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (IsExit)
                {
                    Application.ExitThread();
                    Application.Exit();
                }
                else
                {
                    if (this.Owner != null && IsShowOwner)
                    {
                        Owner.Show();
                    }
                }
            }
            else
            {
                e.Cancel = true;
            }

        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pTitleBar_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        public bool IsLeftMouseDown = false;
        public Point LeftMouseDownPoint { get; set; }

        private void pTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            IsLeftMouseDown = e.Button == MouseButtons.Left;
            LeftMouseDownPoint = e.Location;
            
            //this.Location = new Point(Control.MousePosition.X-e.X, Control.MousePosition.Y-e.Y);
        }

        private void pTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsLeftMouseDown && LeftMouseDownPoint != default)
            {

                if (this.WindowState == FormWindowState.Maximized)
                {
                    LeftMouseDownPoint = new Point(30,10);
                }
                else
                {
                    this.Location = new Point(Control.MousePosition.X - LeftMouseDownPoint.X, Control.MousePosition.Y - LeftMouseDownPoint.Y);
                }
                //this.Location = new Point(this.Location.X + e.X - LeftMouseDownPoint.X,this.Location.Y + e.Y-LeftMouseDownPoint.Y);
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            IsLeftMouseDown = e.Button == MouseButtons.Left;
            LeftMouseDownPoint = default;
            this.Location = new Point(
                this.Location.X,this.Location.Y < 0 ? 
                0
                :
                (this.Location.Y+this.Height > Screen.PrimaryScreen.Bounds.Y+Screen.PrimaryScreen.Bounds.Height ? Screen.PrimaryScreen.Bounds.Y + Screen.PrimaryScreen.Bounds.Height-this.Height : this.Location.Y)
                );
            if (Control.MousePosition.Y == 0)
            {
                this.WindowState = FormWindowState.Maximized;
            }

        }
    }
}
