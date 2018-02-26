using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleTranslateLOG
{
    public class frmWordStickNote : Form
    {
        const int m_FormTranslate = 199;
        int m_Height = Screen.PrimaryScreen.WorkingArea.Height - m_FormTranslate;
        int m_Width = Screen.PrimaryScreen.WorkingArea.Width / 5;
        double m_OpacityHide = 0.1;
        FlowLayoutPanel m_Box;

        public frmWordStickNote()
        {
            this.BackColor = Color.Black;
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Opacity = 1;

            m_Box = new FlowLayoutPanel() { FlowDirection = FlowDirection.TopDown, Dock = DockStyle.Fill, AutoScroll = true, WrapContents = false };
            this.Controls.Add(m_Box);

            this.Activated += (se, ev) =>
            {
                this.Width = m_Width;
                this.Height = m_Height;
                this.Top = 0;
                if (GetTaskBarLocation() == TaskBarLocation.TOP)
                    this.Top = Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.WorkingArea.Height;
                this.Left = Screen.PrimaryScreen.WorkingArea.Width - (m_Width + 9);

                m_Box.MouseHover += onMouseHover;
                m_Box.MouseLeave += onMouseLeave;
                m_Box.MouseMove += YourLabel_MouseDown;

                this.MouseWheel += new MouseEventHandler(OnMouseWheel);

                string[] lines = File.ReadAllLines(@"D:\_EL\GoogleTranslateLOG\bin\Debug\Mr.Thinh.EL\w-20170914.txt");
                foreach (string line in lines)
                {
                    string[] a = line.Split('=');
                    if (a.Length > 1)
                        AddItem(a[0].Trim(), a[1].Trim());
                }

                for (int i = 0; i < 99; i++)
                    AddItem("Text " + i, "Mean " + i);
            };
        }
        private void OnMouseWheel(object sender, MouseEventArgs e)
        {
            m_Box.Focus();
        }

        private void onMouseLeave(object sender, EventArgs e)
        {
            //this.Opacity = m_OpacityHide;
        }

        private void onMouseHover(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        public void AddItem(string word, string mean)
        {
            int width = m_Width - 99;

            GrowLabel l1 = new GrowLabel()
            {
                Text = word,
                Font = new Font("Arial", 15, FontStyle.Italic),
                AutoSize = false,
                Width = width,
                Margin = new Padding(0, 10, 0, 0),
                ForeColor = Color.Black, 
                BackColor = Color.White,
                MaximumSize = new Size(width, 299)
            };
            GrowLabel l2 = new GrowLabel()
            {
                Text = mean,
                Font = new Font("Arial", 15, FontStyle.Italic),
                AutoSize = false,
                Width = width,
                Margin = new Padding(0, 2, 0, 0),
                ForeColor = Color.Black,
                BackColor = Color.White, 
            };

            l1.MouseHover += onMouseHover;
            l1.MouseLeave += onMouseLeave;

            l2.MouseHover += onMouseHover;
            l2.MouseLeave += onMouseLeave;

            m_Box.Controls.Add(l1);
            m_Box.Controls.Add(l2);
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
