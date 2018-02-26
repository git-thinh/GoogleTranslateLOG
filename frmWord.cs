using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleTranslateLOG
{
    public partial class frmWord : Form, INotifyPropertyChanged
    {
        int m_Height = 0;
        List<String> m_Word_En;
        bool m_SearchAll = true;
        string m_FolderRoot = "";
        string[] m_SearchResult = new string[] { };

        public event EventHandler SelectEvent;

        #region [ EVENT ]

        public frmWord(List<String> word_En, int iHeightMain, string pathRoot)
        {
            m_FolderRoot = pathRoot;
            m_Word_En = word_En;

            InitializeComponent();

            this.Text = "Words";
            m_Height = Screen.PrimaryScreen.WorkingArea.Height - iHeightMain;
        }

        private void frmTag_Load(object sender, EventArgs e)
        {
            this.Top = 45;
            this.Height = m_Height - this.Top;
            this.Left = 0;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;

            m_SearchResult = m_Word_En.ToArray();
            word_Display();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string key = txtSearch.Text.Trim().ToLower();
            m_SearchResult = m_Word_En.Where(x => x.ToLower().Contains(key)).ToArray();
            word_Display();
        }

        private void listItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            word_SelectChanged();
        }

        private void txtWord_MouseDoubleClick(object sender, MouseEventArgs e)
        { 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            word_UpdateChanged(); 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        { 
        }

        private void txtSearch_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //txtSearch.Text = "";
            //listIndex.DataSource = m_Word_En;
        }
        
        private void dateTimePicker1_MouseUp(object sender, MouseEventArgs e)
        {
            if (m_SearchAll && dateTimePicker1.Checked)
            {
                m_SearchAll = false;

                string[] words = new string[] { };
                string date = dateTimePicker1.Value.ToString("yyyyMMdd");
                string fi = Path.Combine(m_FolderRoot, "w-" + date + ".txt");
                if (File.Exists(fi))
                    words = File.ReadAllLines(fi).Select(x => x.Split('=')[0].Trim()).ToArray();
                m_SearchResult = words;

                word_Display();
            }
            else
            {
                if (m_SearchAll == false && dateTimePicker1.Checked == false)
                {
                    m_SearchAll = true;
                    m_SearchResult = m_Word_En.ToArray();
                    word_Display();
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Checked) word_Display();
        }

        private void txtItemSelected_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                word_UpdateChanged();
            }
        }

        #endregion

        #region [ METHOD ]

        public event PropertyChangedEventHandler PropertyChanged;
        private string _itemSelected = "";
        public string ItemSelected
        {
            get { return _itemSelected; }
            set
            {
                if (value != _itemSelected)
                {
                    this._itemSelected = value;
                    if (this.PropertyChanged != null)
                    {
                        this.PropertyChanged(this, new PropertyChangedEventArgs("ItemSelected"));
                    }
                }
            }
        }

        void word_Display()
        {
            listItem.DataSource = m_SearchResult;

            //string tag = listIndex.SelectedItem.ToString();
            //lblSelect.Text = tag;
            //string key = tag.Split('=')[0].Trim();
            //List<string> list = new List<string>() { };
            //if (m_Tags.ContainsKey(key))
            //{
            //    list = m_Tags[key];
            //    txtWord.Text = string.Join(Environment.NewLine, list);
            //    ItemSelected = tag;
            //}
        }

        void word_SelectChanged() {
            string tag = listItem.SelectedItem == null ? "" : listItem.SelectedItem.ToString();
            if (tag == "") return;

            txtItemSelected.Text = tag;
            EventHandler handler = SelectEvent;
            if (handler != null) handler(tag, new EventArgs()); 
        }

        void word_UpdateChanged() {

        }

        #endregion

    }
}
