using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleTranslateLOG
{
    public partial class frmMain : Form
    {
        //const string __TRAN = "ja/en";
        const string __TRAN = "en/vi";

        #region [ EVENT CLIPBOARD ] 

        string[] formatsAll = new string[]
        {
            DataFormats.Bitmap,
            DataFormats.CommaSeparatedValue,
            DataFormats.Dib,
            DataFormats.Dif,
            DataFormats.EnhancedMetafile,
            DataFormats.FileDrop,
            DataFormats.Html,
            DataFormats.Locale,
            DataFormats.MetafilePict,
            DataFormats.OemText,
            DataFormats.Palette,
            DataFormats.PenData,
            DataFormats.Riff,
            DataFormats.Rtf,
            DataFormats.Serializable,
            DataFormats.StringFormat,
            DataFormats.SymbolicLink,
            DataFormats.Text,
            DataFormats.Tiff,
            DataFormats.UnicodeText,
            DataFormats.WaveAudio
        };

        string[] formatsAllDesc = new String[]
        {
            "Bitmap",
            "CommaSeparatedValue",
            "Dib",
            "Dif",
            "EnhancedMetafile",
            "FileDrop",
            "Html",
            "Locale",
            "MetafilePict",
            "OemText",
            "Palette",
            "PenData",
            "Riff",
            "Rtf",
            "Serializable",
            "StringFormat",
            "SymbolicLink",
            "Text",
            "Tiff",
            "UnicodeText",
            "WaveAudio"
        };

        IntPtr _ClipboardViewerNext;

        /// <summary>
        /// Register this form as a Clipboard Viewer application
        /// </summary>
        private void RegisterClipboardViewer()
        {
            _ClipboardViewerNext = User32.SetClipboardViewer(this.Handle);
        }

        /// <summary>
        /// Remove this form from the Clipboard Viewer list
        /// </summary>
        private void UnregisterClipboardViewer()
        {
            User32.ChangeClipboardChain(this.Handle, _ClipboardViewerNext);
        }

        protected override void WndProc(ref Message m)
        {
            switch ((Msgs)m.Msg)
            {
                //
                // The WM_DRAWCLIPBOARD message is sent to the first window 
                // in the clipboard viewer chain when the content of the 
                // clipboard changes. This enables a clipboard viewer 
                // window to display the new content of the clipboard. 
                //
                case Msgs.WM_DRAWCLIPBOARD:

                    Debug.WriteLine("WindowProc DRAWCLIPBOARD: " + m.Msg, "WndProc");

                    GetClipboardData();

                    //
                    // Each window that receives the WM_DRAWCLIPBOARD message 
                    // must call the SendMessage function to pass the message 
                    // on to the next window in the clipboard viewer chain.
                    //
                    User32.SendMessage(_ClipboardViewerNext, m.Msg, m.WParam, m.LParam);
                    break;


                //
                // The WM_CHANGECBCHAIN message is sent to the first window 
                // in the clipboard viewer chain when a window is being 
                // removed from the chain. 
                //
                case Msgs.WM_CHANGECBCHAIN:
                    Debug.WriteLine("WM_CHANGECBCHAIN: lParam: " + m.LParam, "WndProc");

                    // When a clipboard viewer window receives the WM_CHANGECBCHAIN message, 
                    // it should call the SendMessage function to pass the message to the 
                    // next window in the chain, unless the next window is the window 
                    // being removed. In this case, the clipboard viewer should save 
                    // the handle specified by the lParam parameter as the next window in the chain. 

                    //
                    // wParam is the Handle to the window being removed from 
                    // the clipboard viewer chain 
                    // lParam is the Handle to the next window in the chain 
                    // following the window being removed. 
                    if (m.WParam == _ClipboardViewerNext)
                    {
                        //
                        // If wParam is the next clipboard viewer then it
                        // is being removed so update pointer to the next
                        // window in the clipboard chain
                        //
                        _ClipboardViewerNext = m.LParam;
                    }
                    else
                    {
                        User32.SendMessage(_ClipboardViewerNext, m.Msg, m.WParam, m.LParam);
                    }
                    break;

                default:
                    //
                    // Let the form process the messages that we are
                    // not interested in
                    //
                    base.WndProc(ref m);
                    break;

            }

        }


        /// <summary>
        /// Show the clipboard contents in the window 
        /// and show the notification balloon if a link is found
        /// </summary>
        private void GetClipboardData()
        {
            if (m_AllowCopy == false) return;

            //
            // Data on the clipboard uses the 
            // IDataObject interface
            //
            IDataObject iData = new DataObject();
            string strTextData = "";

            try
            {
                iData = Clipboard.GetDataObject();
            }
            catch (System.Runtime.InteropServices.ExternalException externEx)
            {
                // Copying a field definition in Access 2002 causes this sometimes?
                Debug.WriteLine("InteropServices.ExternalException: {0}", externEx.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

            // 
            // Get RTF if it is present
            //
            if (iData.GetDataPresent(DataFormats.Rtf))
            {
                strTextData = (string)iData.GetData(DataFormats.Rtf);

                if (iData.GetDataPresent(DataFormats.Text))
                {
                    RichTextBox rtf = new RichTextBox();
                    rtf.Rtf = strTextData;
                    strTextData = rtf.Text;
                }
            }
            else
            {
                // 
                // Get Text if it is present
                //
                if (iData.GetDataPresent(DataFormats.Text))
                {
                    //strTextData = (string)iData.GetData(DataFormats.Text);
                    strTextData = (string)iData.GetData(DataFormats.UnicodeText);
                }
                else
                {
                    //
                    // Only show RTF or TEXT
                    //
                    //strTextData  = "(cannot display this format)";
                }
            }

            if (checkAllowRUN.Checked)
            {
                // do something with strTextData
                //strTextData = formatText(strTextData);
                //if (!string.IsNullOrEmpty(strTextData) && strTextData != m_SearchText)
                //{
                //    SearchType type = SearchType.EN_VI;
                //    search_Online(strTextData, type);
                //}

                strTextData = formatText(strTextData);
                if (!string.IsNullOrEmpty(strTextData))
                {
                    SearchType type = SearchType.EN_VI;
                    search_Online(strTextData, type);
                }
            }
        }

        #endregion

        #region [ MOVE FORM ]

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

        #region [ UI ]

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

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterClipboardViewer();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            init();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uiPanelHeader_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int iHeight = (int)this.Tag;
            if (uiPanelHeader.Tag.ToString() == "Hide")
            {
                uiPanelHeader.Tag = "Show";
                this.Tag = this.Height;
            }
            else
            {
                uiPanelHeader.Tag = "Hide";
                this.Tag = m_FormHeightMin;
            }

            this.Height = iHeight;
            this.Top = Screen.PrimaryScreen.WorkingArea.Height - this.Height;

            TaskBarLocation bar = GetTaskBarLocation();
            int iHeightTaskBar = Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.WorkingArea.Height;
            if (bar == TaskBarLocation.TOP) this.Top = this.Top + iHeightTaskBar;
        }


        private void btnLangType_Click(object sender, EventArgs e)
        {
            if (btnLangType.Text == "E-V")
            {
                btnLangType.Text = "V-E";
                search_SwitchType(SearchType.VI_EN);
            }
            else
            {
                btnLangType.Text = "E-V";
                search_SwitchType(SearchType.EN_VI);
            }
        }
        // Hides script errors without hiding other dialog boxes.
        private void SuppressScriptErrorsOnly(WebBrowser browser)
        {
            // Ensure that ScriptErrorsSuppressed is set to false.
            browser.ScriptErrorsSuppressed = false;

            // Handle DocumentCompleted to gain access to the Document object.
            browser.DocumentCompleted +=
                new WebBrowserDocumentCompletedEventHandler(
                    browser_DocumentCompleted);
        }

        private void browser_DocumentCompleted(object sender,
            WebBrowserDocumentCompletedEventArgs e)
        {
            ((WebBrowser)sender).Document.Window.Error +=
                new HtmlElementErrorEventHandler(Window_Error);
        }

        private void Window_Error(object sender,
            HtmlElementErrorEventArgs e)
        {
            // Ignore the error and suppress the error dialog box. 
            e.Handled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearSearch();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string url = WebUtility.UrlDecode(e.Url.ToString());
            if (url == m_UrlEV || url == m_UrlVE)
                m_SearchInited = true;
            else
            {
                string data = url.Split('/').Last();
                search_Complete(data);
            }
        }

        #endregion

        bool m_AutoSaveWord = false;
        static string m_FolderRoot = AppDomain.CurrentDomain.BaseDirectory + @"Mr.Thinh.EL\";
        static string m_File_Word_En = AppDomain.CurrentDomain.BaseDirectory + @"Mr.Thinh.EL\w-" + __TRAN.Split('/')[0] + ".txt";
        static string m_File_Word_Vi = AppDomain.CurrentDomain.BaseDirectory + @"Mr.Thinh.EL\w-" + __TRAN.Split('/')[1] + ".txt";
        static string m_File_Tag = AppDomain.CurrentDomain.BaseDirectory + @"Mr.Thinh.EL\tag.txt";
        static string m_File_Word_Date = AppDomain.CurrentDomain.BaseDirectory + @"Mr.Thinh.EL\w-" + __TRAN.Replace('/','.') + "-" + DateTime.Now.ToString("yyyyMMdd") + ".txt";

        bool m_AllowCopy = false;
        bool m_SearchInited = false;
        const string m_UrlEV = "https://translate.google.com/#" + __TRAN + "/";
        const string m_UrlVE = "https://translate.google.com/#vi/en/";
        int m_FormHeightMin = 69;
        SearchType m_SearchType = SearchType.EN_VI;
        string m_SearchText = string.Empty;
        string m_SearchMean = string.Empty;

        List<string> m_Word_En = new List<string>();
        List<string> m_Word_Vi = new List<string>();
        Dictionary<string, List<string>> m_Tags = new Dictionary<string, List<string>>() { };
        List<string> m_TagList = new List<string>() { };

        private void init()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            this.Text = "Mr.Thinh learn English";

            uiPanelHeader.Tag = "Hide";
            this.Tag = m_FormHeightMin;
            this.Left = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            this.TopMost = true;

            this.Top = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            TaskBarLocation bar = GetTaskBarLocation();
            int iHeightTaskBar = Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.WorkingArea.Height;
            if (bar == TaskBarLocation.TOP) this.Top = this.Top + iHeightTaskBar;

            panelConfig.Visible = false;

            // TAG 
            if (!Directory.Exists(m_FolderRoot)) Directory.CreateDirectory(m_FolderRoot);

            m_AutoSaveWord = chkConfig_AutoSaveWord.Checked;

            SuppressScriptErrorsOnly(webBrowser1);
            webBrowser1.Navigate(m_UrlEV);


            if (!File.Exists(m_File_Word_En)) File.Create(m_File_Word_En);
            if (!File.Exists(m_File_Word_Vi)) File.Create(m_File_Word_Vi);
            if (!File.Exists(m_File_Tag)) File.Create(m_File_Tag);
            if (!File.Exists(m_File_Word_Date)) File.Create(m_File_Word_Date);

            //new Thread(() =>
            //{
            m_Word_En = File.ReadAllLines(m_File_Word_En).ToList();
            m_Word_Vi = File.ReadAllLines(m_File_Word_Vi).ToList();
            tag_Load();
            //}).Start();

            //show_Word();

            // Config at posision last of function
            RegisterClipboardViewer();
            m_AllowCopy = true;
        }

        private string formatText(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                text = text.Trim();
                if (text[0] == '-') text = text.Substring(1, text.Length - 1).Trim();

                //text = text.Replace("/", " - ").Trim();
                //RegexOptions options = RegexOptions.None;
                //Regex regex = new Regex("[ ]{2,}", options);
                //text = regex.Replace(text, " ");

                //foreach (KeyValuePair<string, string> kv in __word_fix.MapWordReplace)
                //    text = text.Replace(kv.Key, kv.Value);

                ////text = text.Replace(" ", "%20");
                //text = string.Join("\n",
                //    text.Trim().Split(new string[] { "\n", "\r", "\t" }, StringSplitOptions.None)
                //    .Select(x => x.Trim())
                //    .Where(x => x != string.Empty)
                //    .ToArray());
                //text = new String(text.Where(c => Char.IsNumber(c) || Char.IsLetter(c) ||
                //c == '|' || c == '\'' || c == ';' || c == '-' ||
                //c == '(' || c == ')' || c == ','
                //|| c == ' ' || c == '.' || c == '\n').ToArray());

                //char ce = text[text.Length - 1];
                //if (ce == '|' || ce == '\'' || ce == ';' || ce == '-' || ce == '(' || ce == ')' || ce == ',' || ce == '.')
                //    text = text.Substring(0, text.Length - 1);

                return text.Trim();
            }
            return string.Empty;
        }

        #region [ SEARCH ... ]

        private void clearSearch()
        {
            m_SearchInited = false;
            switch (m_SearchType)
            {
                case SearchType.EN_VI:
                    webBrowser1.Navigate(m_UrlEV);
                    break;
                case SearchType.VI_EN:
                    webBrowser1.Navigate(m_UrlVE);
                    break;
            }
            m_SearchText = string.Empty;
        }

        private void search_SwitchType(SearchType type)
        {
            m_SearchInited = false;
            m_SearchType = type;
            m_SearchText = string.Empty;
            m_SearchMean = string.Empty;

            switch (type)
            {
                case SearchType.EN_VI:
                    webBrowser1.Navigate(m_UrlEV);
                    break;
                case SearchType.VI_EN:
                    webBrowser1.Navigate(m_UrlVE);
                    break;
            }
        }

        private void search_Online(string text, SearchType type)
        {
            if (m_SearchInited && m_SearchText != text)
            {
                string url = m_UrlEV + WebUtility.UrlEncode(text); ;
                webBrowser1.Navigate(url);
            }
        }

        private System.Windows.Forms.Timer time = new System.Windows.Forms.Timer();
        private void search_Complete(string text)
        {
            if (text == m_SearchText) return;

            m_SearchMean = string.Empty;
            m_SearchText = text;

            time.Enabled = true;
            time.Interval = 1000;
            time.Tick += (se, ev) =>
            {
                time.Stop();
                m_SearchMean = webBrowser1.Document.GetElementById("result_box").InnerText.Trim();
                webBrowser1.Document.GetElementsByTagName("HTML")[0].ScrollTop = 0;
                m_AllowCopy = false;
                //Clipboard.SetText(m_SearchText + Environment.NewLine + Environment.NewLine + m_SearchMean);
                Clipboard.SetText("- " + m_SearchMean);
                m_AllowCopy = true;
                if (m_AutoSaveWord) word_Save();
            };
            time.Start();
        }

        #endregion

        #region [ WORD ]

        void show_Word()
        {
            var ft = new frmWord(m_Word_En, this.Height, m_FolderRoot);
            ft.SelectEvent += (data, ev) =>
            {
                string tag = data == null ? "" : data.ToString();

            };
            ft.ShowDialog();
        }

        private void word_Save()
        {
            if (__TRAN == "ja/en") return;

            if (m_SearchText == string.Empty || m_Word_En.IndexOf(m_SearchText) != -1) return;

            using (FileStream fs = new FileStream(m_File_Word_En, FileMode.Append, FileAccess.Write))
            {
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                string en = m_SearchText.Replace("\n", " ").Trim();
                sw.WriteLine(en);
                sw.Flush();
            }

            using (FileStream fs = new FileStream(m_File_Word_Vi, FileMode.Append, FileAccess.Write))
            {
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                string vi = m_SearchMean.Replace("\n", " ").Replace("\r", string.Empty).Trim();
                sw.WriteLine(vi);
                sw.Flush();
            }

            m_Word_En.Add(m_SearchText);
            m_Word_Vi.Add(m_SearchMean);

            try
            {
                using (FileStream fs = new FileStream(m_File_Word_Date, FileMode.Append, FileAccess.Write))
                {
                    StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                    string s = m_SearchText.Replace("\n", " ").Trim() + " = " + m_SearchMean.Replace("\n", " ").Replace("\r", string.Empty).Trim();
                    sw.WriteLine(s);
                    sw.Flush();
                }
            }
            catch { }

            //string en = m_SearchText.Replace("\n", " ").Trim();
            //File.AppendAllText(m_File_Word_En, Environment.NewLine + en);
            //string vi = m_SearchMean.Replace("\n", " ").Trim();
            //File.AppendAllText(m_File_Word_Vi, Environment.NewLine + vi);
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            show_Word();
        }

        private void txtWordIndex_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            show_Word();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtEditSearch.Visible == false)
            {
                txtEditSearch.Visible = true;
                txtEditMean.Visible = true;
                txtEditSearch.Text = m_SearchText;
                txtEditMean.Text = m_SearchMean;
            }
            else
            {
                txtEditSearch.Visible = false;
                txtEditMean.Visible = false;
            }
        }

        private void txtEditSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEditSearch.Visible = false;
                txtEditMean.Visible = false;
                search_Online(txtEditSearch.Text, m_SearchType);
            }
        }


        #endregion

        #region [ TAG ]

        private void tag_Load()
        {
            m_TagList = File.ReadAllLines(m_File_Tag).Where(x => x.Trim() != string.Empty).ToList();

            string[] keys = m_TagList.Select(x => x.Split('=')[0].Trim()).Where(x => x.Trim() != string.Empty).ToArray();
            foreach (string tag in keys)
            {
                List<string> list = new List<string>() { };
                string fi = Path.Combine(m_FolderRoot, "tag." + tag + ".txt");
                if (File.Exists(fi))
                    list = File.ReadAllLines(fi).ToList();
                m_Tags.Add(tag, list);
            }
        }

        private void lblTagCaption_Click(object sender, EventArgs e)
        {
            tag_Show();
        }

        private void tag_Show()
        {
            var ft = new frmTag(m_TagList, m_Tags, this.Height);
            ft.PropertyChanged += (se, ev) =>
            {
                string tag = ft.TagSelected;
                lblTagCaption.Text = tag.Split('=')[0].Trim();
            };
            ft.ShowDialog();
        }

        private void btnTagAddNew_Click(object sender, EventArgs e)
        {
            if (m_SearchText != "" && !m_Tags.ContainsKey(m_SearchText))
            {
                m_Tags.Add(m_SearchText, new List<string>() { });

                string s = m_SearchText.Replace("\n", " ").Trim() + " = " + m_SearchMean.Replace("\n", " ").Replace("\r", string.Empty).Trim();
                m_TagList.Insert(0, s);
                File.WriteAllLines(m_File_Tag, m_TagList, Encoding.UTF8);
            }
        }


        #endregion

        #region [ CONFIG ]

        private void btnConfigClose_Click(object sender, EventArgs e)
        {
            panelConfig.Visible = false;
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            panelConfig.Visible = true;
        }

        #endregion

        #region [ INDEX ]

        //void index

        #endregion

        private void checkAllowRUN_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAllowRUN.Checked) {
                this.Opacity = 1;
                this.TopMost = true;
            } else {
                this.Opacity = 0.5;
                this.TopMost = true;
            }
        }
    }
}
