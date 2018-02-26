using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleTranslateLOG
{
    public class frmWordSlide : Form
    {
        Panel m_move;
        TransparentPanel m_box;
        BorderLabel m_lblWord;
        int iBoxWidth = 5;
        int iMainWidth = Screen.PrimaryScreen.WorkingArea.Width;

        public frmWordSlide()
        { 
            this.TopMost = true;
            this.TransparencyKey = Color.Black;
            this.BackColor = Color.Black;
            this.FormBorderStyle = FormBorderStyle.None;
            //this.Opacity = 0;

            this.Activated += (se, ev)=> 
            {
                m_move = new Panel() {
                    BackColor = Color.OrangeRed,
                    Width = iBoxWidth,
                    Dock = DockStyle.Right
                };
                m_move.MouseMove += YourLabel_MouseDown;

                m_box = new TransparentPanel() { Dock = DockStyle.Fill , BorderStyle = BorderStyle.None };
                m_lblWord = new BorderLabel() { Text = "Hello Vietnam = Xin chào Việt Nam",
                    TextAlign = ContentAlignment.MiddleRight,
                    ForeColor = Color.Red,
                    BorderColor = Color.White,
                    Font = new Font("Arial", 27, FontStyle.Regular),                    
                    AutoSize = false, Dock = DockStyle.Fill };

                m_box.Controls.AddRange(new Control[] { m_lblWord, new Label() { AutoSize = false, Width = 200, Dock = DockStyle.Right } });
                m_lblWord.MouseMove += YourLabel_MouseDown;
                
                this.Controls.AddRange(new Control[] {m_box , m_move });
                this.Width = iMainWidth;
                this.Height = 44;
                this.Top = 0; //Screen.PrimaryScreen.WorkingArea.Height - 44;
                if (GetTaskBarLocation() == TaskBarLocation.TOP)
                    this.Top = Screen.PrimaryScreen.Bounds.Height - (Screen.PrimaryScreen.WorkingArea.Height + 7);

                this.Left = Screen.PrimaryScreen.WorkingArea.Width - this.Width;

                m_move.MouseDoubleClick += new MouseEventHandler(m_box_MouseDoubleClick);
                m_lblWord.MouseMove += M_lblWord_MouseMove;
                m_lblWord.MouseLeave += M_lblWord_MouseLeave;
                 
            };
        }

        private void M_lblWord_MouseLeave(object sender, EventArgs e)
        {
            this.AllowTransparency = true;
            this.TransparencyKey = Color.Black;
            this.BackColor = Color.Black;
        }

        private void M_lblWord_MouseMove(object sender, MouseEventArgs e)
        {
            this.AllowTransparency = false;
        }

        void m_box_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (this.Width == iMainWidth)
            {
                this.Width = iBoxWidth;
            }
            else {
                this.Width = iMainWidth;
            }
            this.Left = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
        }

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

        #region [ MOVE FORM ]

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
