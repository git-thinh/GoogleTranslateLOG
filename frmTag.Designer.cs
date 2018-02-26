namespace GoogleTranslateLOG
{
    partial class frmTag
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.lblTagSelect = new System.Windows.Forms.Label();
            this.listTag = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(700, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(40, 22);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(746, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(42, 22);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtWord
            // 
            this.txtWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWord.Location = new System.Drawing.Point(280, 29);
            this.txtWord.Multiline = true;
            this.txtWord.Name = "txtWord";
            this.txtWord.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtWord.Size = new System.Drawing.Size(511, 365);
            this.txtWord.TabIndex = 17;
            this.txtWord.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtWord_MouseDoubleClick);
            // 
            // lblTagSelect
            // 
            this.lblTagSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTagSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagSelect.Location = new System.Drawing.Point(280, 6);
            this.lblTagSelect.Name = "lblTagSelect";
            this.lblTagSelect.Size = new System.Drawing.Size(414, 19);
            this.lblTagSelect.TabIndex = 16;
            this.lblTagSelect.Text = "...";
            this.lblTagSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listTag
            // 
            this.listTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listTag.Dock = System.Windows.Forms.DockStyle.Left;
            this.listTag.FormattingEnabled = true;
            this.listTag.Location = new System.Drawing.Point(0, 29);
            this.listTag.Name = "listTag";
            this.listTag.Size = new System.Drawing.Size(280, 365);
            this.listTag.TabIndex = 15;
            this.listTag.SelectedIndexChanged += new System.EventHandler(this.listTag_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(12, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(268, 20);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lblTagSelect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 29);
            this.panel1.TabIndex = 20;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(280, 29);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 365);
            this.splitter1.TabIndex = 21;
            this.splitter1.TabStop = false;
            // 
            // frmTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 394);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.listTag);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmTag";
            this.Text = "Tags";
            this.Load += new System.EventHandler(this.frmTag_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Label lblTagSelect;
        private System.Windows.Forms.ListBox listTag;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
    }
}