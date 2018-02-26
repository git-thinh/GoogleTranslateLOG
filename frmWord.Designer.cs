namespace GoogleTranslateLOG
{
    partial class frmWord
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
            this.listItem = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtItemSelected = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(705, 4);
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
            this.txtWord.Location = new System.Drawing.Point(499, 29);
            this.txtWord.Multiline = true;
            this.txtWord.Name = "txtWord";
            this.txtWord.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtWord.Size = new System.Drawing.Size(292, 365);
            this.txtWord.TabIndex = 17;
            this.txtWord.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtWord_MouseDoubleClick);
            // 
            // listItem
            // 
            this.listItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.listItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listItem.FormattingEnabled = true;
            this.listItem.ItemHeight = 25;
            this.listItem.Location = new System.Drawing.Point(0, 29);
            this.listItem.Name = "listItem";
            this.listItem.Size = new System.Drawing.Size(496, 365);
            this.listItem.TabIndex = 15;
            this.listItem.SelectedIndexChanged += new System.EventHandler(this.listItem_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(52, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(116, 20);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtItemSelected);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 29);
            this.panel1.TabIndex = 20;
            // 
            // txtItemSelected
            // 
            this.txtItemSelected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemSelected.BackColor = System.Drawing.SystemColors.Control;
            this.txtItemSelected.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItemSelected.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemSelected.Location = new System.Drawing.Point(394, 3);
            this.txtItemSelected.Name = "txtItemSelected";
            this.txtItemSelected.Size = new System.Drawing.Size(308, 23);
            this.txtItemSelected.TabIndex = 23;
            this.txtItemSelected.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtItemSelected.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemSelected_KeyDown);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.CustomFormat = "yyyyMMdd";
            this.dateTimePicker1.Location = new System.Drawing.Point(174, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowCheckBox = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(216, 20);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.dateTimePicker1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dateTimePicker1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "SEARCH";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(496, 29);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 365);
            this.splitter1.TabIndex = 21;
            this.splitter1.TabStop = false;
            // 
            // frmWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 394);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.listItem);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmWord";
            this.Text = "Index";
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
        private System.Windows.Forms.ListBox listItem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemSelected;
    }
}