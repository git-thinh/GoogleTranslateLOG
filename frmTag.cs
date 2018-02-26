using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleTranslateLOG
{
    public partial class frmTag : Form, INotifyPropertyChanged
    {
        public frmTag(List<String> tagList, Dictionary<string, List<string>> tags, int iHeightMain)
        {
            m_TagList = tagList;
            m_Tags = tags;

            InitializeComponent();

            m_Height = Screen.PrimaryScreen.WorkingArea.Height - iHeightMain;
        }

        int m_Height = 0;
        private List<String> m_TagList;
        private Dictionary<string, List<string>> m_Tags;

        private void frmTag_Load(object sender, EventArgs e)
        {
            this.Top = 45;
            this.Height = m_Height - this.Top;
            this.Left = 0;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;

            listTag.DataSource = m_TagList;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string key = txtSearch.Text.Trim().ToLower();
            var a = m_TagList.Where(x => x.ToLower().Contains(key)).ToArray();
            listTag.DataSource = a;
            if (a.Length > 0)
            {
                listTag.SelectedIndex = 0;
                wordDisplay();
            }
        }

        private void listTag_SelectedIndexChanged(object sender, EventArgs e)
        {
            wordDisplay();
        }

        private void txtWord_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = "";
            listTag.DataSource = m_TagList;
        }

        void wordDisplay()
        {
            string tag = listTag.SelectedItem.ToString();
            lblTagSelect.Text = tag;
            string key = tag.Split('=')[0].Trim();
            List<string> list = new List<string>() { };
            if (m_Tags.ContainsKey(key))
            {
                list = m_Tags[key];
                txtWord.Text = string.Join(Environment.NewLine, list);
                TagSelected = tag;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private string _tagSelected = "";
        public string TagSelected
        {
            get { return _tagSelected; }
            set
            {
                if (value != _tagSelected)
                {
                    this._tagSelected = value;
                    if (this.PropertyChanged != null)
                    {
                        this.PropertyChanged(this, new PropertyChangedEventArgs("TagSelected"));
                    }
                }
            }
        }
    }
}
