﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleTranslateLOG
{
    public class frmWordStickBar : Form
    {
        int m_Height = Screen.PrimaryScreen.WorkingArea.Height;
        int m_Width = 9;
        double m_OpacityHide = 0.1;
        frmWordStickNote m_Note = null;

        public frmWordStickBar()
        { 
            this.TopMost = true; 
            this.FormBorderStyle = FormBorderStyle.None;
            this.Opacity = m_OpacityHide;

            this.Activated += (se, ev)=> 
            {
                this.Width = m_Width;
                this.Height = m_Height;
                this.Top = 0; 
                if (GetTaskBarLocation() == TaskBarLocation.TOP)
                    this.Top = Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.WorkingArea.Height;
                this.Left = Screen.PrimaryScreen.WorkingArea.Width - (m_Width - 5);
                this.MouseHover += FrmWordStickNote_MouseHover;

                m_Note = new frmWordStickNote();
                m_Note.Show();
            };
        }

        private void FrmWordStickNote_MouseHover(object sender, EventArgs e)
        {
            this.Width = m_Width;
            this.Left = Screen.PrimaryScreen.WorkingArea.Width - (this.Width - (m_Width - 3));
            if (this.Opacity == m_OpacityHide) {
                // show 
                this.Opacity = 1;
                m_Note.Show();
            }
            else
            {
                // hide
                this.Opacity = m_OpacityHide;
                m_Note.Hide();
            }
        }
        

        #region [ MOVE FORM ]

        ////protected override CreateParams CreateParams
        ////{
        ////    get
        ////    {
        ////        CreateParams cp = base.CreateParams;
        ////        cp.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT
        ////        return cp;
        ////    }
        ////}
        ////protected override void OnPaintBackground(PaintEventArgs e)
        ////{
        ////    //base.OnPaintBackground(e);
        ////}


        private async void FadeIn(Form o, int interval = 80)
        {
            //Object is not fully invisible. Fade it in
            while (o.Opacity < 1.0)
            {
                await Task.Delay(interval);
                o.Opacity += 0.05;
            }
            o.Opacity = 1; //make fully visible       
        }

        private async void FadeOut(Form o, int interval = 80)
        {
            //Object is fully visible. Fade it out
            while (o.Opacity > 0.0)
            {
                await Task.Delay(interval);
                o.Opacity -= 0.05;
            }
            o.Opacity = 0; //make fully invisible       
        }

        private enum TaskBarLocation { TOP, BOTTOM, LEFT, RIGHT }

        private TaskBarLocation GetTaskBarLocation()
        {
            TaskBarLocation taskBarLocation = TaskBarLocation.BOTTOM;
            bool taskBarOnTopOrBottom = (Screen.PrimaryScreen.WorkingArea.Width == Screen.PrimaryScreen.Bounds.Width);
            if (taskBarOnTopOrBottom)
            {
                if (Screen.PrimaryScreen.WorkingArea.Top > 0) taskBarLocation = TaskBarLocation.TOP;
            }
            else
            {
                if (Screen.PrimaryScreen.WorkingArea.Left > 0)
                {
                    taskBarLocation = TaskBarLocation.LEFT;
                }
                else
                {
                    taskBarLocation = TaskBarLocation.RIGHT;
                }
            }
            return taskBarLocation;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void YourLabel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion
    }
}
