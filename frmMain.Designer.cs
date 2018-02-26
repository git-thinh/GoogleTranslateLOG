namespace GoogleTranslateLOG
{
    partial class frmMain
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.uiPanelHeader = new System.Windows.Forms.Panel();
            this.checkAllowRUN = new System.Windows.Forms.CheckBox();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnWord = new System.Windows.Forms.Button();
            this.btnTopic = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnTagAddNew = new System.Windows.Forms.Button();
            this.btnLangType = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panelConfig = new System.Windows.Forms.Panel();
            this.chkConfig_AutoSaveWord = new System.Windows.Forms.CheckBox();
            this.btnConfigClose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTagCaption = new System.Windows.Forms.Label();
            this.lblWordTypeCaption = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtEditSearch = new System.Windows.Forms.TextBox();
            this.txtEditMean = new System.Windows.Forms.TextBox();
            this.lblWordIndex = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.uiPanelHeader.SuspendLayout();
            this.panelConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(-27, -204);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(828, 447);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Url = new System.Uri("http://ip", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // uiPanelHeader
            // 
            this.uiPanelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiPanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uiPanelHeader.Controls.Add(this.checkAllowRUN);
            this.uiPanelHeader.Controls.Add(this.btnConfig);
            this.uiPanelHeader.Controls.Add(this.btnWord);
            this.uiPanelHeader.Controls.Add(this.btnTopic);
            this.uiPanelHeader.Controls.Add(this.btnClose);
            this.uiPanelHeader.Controls.Add(this.btnTagAddNew);
            this.uiPanelHeader.Location = new System.Drawing.Point(756, 0);
            this.uiPanelHeader.Name = "uiPanelHeader";
            this.uiPanelHeader.Size = new System.Drawing.Size(44, 169);
            this.uiPanelHeader.TabIndex = 2;
            this.uiPanelHeader.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.uiPanelHeader_MouseDoubleClick);
            this.uiPanelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.YourLabel_MouseDown);
            // 
            // checkAllowRUN
            // 
            this.checkAllowRUN.AutoSize = true;
            this.checkAllowRUN.Checked = true;
            this.checkAllowRUN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAllowRUN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkAllowRUN.Location = new System.Drawing.Point(3, 51);
            this.checkAllowRUN.Name = "checkAllowRUN";
            this.checkAllowRUN.Size = new System.Drawing.Size(47, 17);
            this.checkAllowRUN.TabIndex = 23;
            this.checkAllowRUN.Text = "RUN";
            this.checkAllowRUN.UseVisualStyleBackColor = true;
            this.checkAllowRUN.CheckedChanged += new System.EventHandler(this.checkAllowRUN_CheckedChanged);
            // 
            // btnConfig
            // 
            this.btnConfig.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConfig.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.Location = new System.Drawing.Point(1, 146);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(43, 22);
            this.btnConfig.TabIndex = 11;
            this.btnConfig.Text = "Config";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnWord
            // 
            this.btnWord.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnWord.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWord.Location = new System.Drawing.Point(1, 102);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(43, 22);
            this.btnWord.TabIndex = 10;
            this.btnWord.Text = "Word";
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // btnTopic
            // 
            this.btnTopic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTopic.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopic.Location = new System.Drawing.Point(1, 125);
            this.btnTopic.Name = "btnTopic";
            this.btnTopic.Size = new System.Drawing.Size(43, 22);
            this.btnTopic.TabIndex = 9;
            this.btnTopic.Text = "Topic";
            this.btnTopic.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClose.Location = new System.Drawing.Point(2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnTagAddNew
            // 
            this.btnTagAddNew.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTagAddNew.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTagAddNew.Location = new System.Drawing.Point(2, 25);
            this.btnTagAddNew.Name = "btnTagAddNew";
            this.btnTagAddNew.Size = new System.Drawing.Size(41, 24);
            this.btnTagAddNew.TabIndex = 11;
            this.btnTagAddNew.Text = "+Tag";
            this.btnTagAddNew.UseVisualStyleBackColor = true;
            this.btnTagAddNew.Click += new System.EventHandler(this.btnTagAddNew_Click);
            // 
            // btnLangType
            // 
            this.btnLangType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLangType.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLangType.Location = new System.Drawing.Point(351, 24);
            this.btnLangType.Name = "btnLangType";
            this.btnLangType.Size = new System.Drawing.Size(35, 22);
            this.btnLangType.TabIndex = 3;
            this.btnLangType.Text = "E-V";
            this.btnLangType.UseVisualStyleBackColor = true;
            this.btnLangType.Click += new System.EventHandler(this.btnLangType_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1, 169);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(800, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1, 169);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(799, 1);
            this.label3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Location = new System.Drawing.Point(1, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(799, 1);
            this.label4.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(352, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(34, 25);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "X";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(352, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 165);
            this.label5.TabIndex = 8;
            // 
            // panelConfig
            // 
            this.panelConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelConfig.Controls.Add(this.chkConfig_AutoSaveWord);
            this.panelConfig.Controls.Add(this.btnConfigClose);
            this.panelConfig.Controls.Add(this.label7);
            this.panelConfig.Controls.Add(this.label6);
            this.panelConfig.Location = new System.Drawing.Point(12, 24);
            this.panelConfig.Name = "panelConfig";
            this.panelConfig.Size = new System.Drawing.Size(186, 121);
            this.panelConfig.TabIndex = 12;
            // 
            // chkConfig_AutoSaveWord
            // 
            this.chkConfig_AutoSaveWord.AutoSize = true;
            this.chkConfig_AutoSaveWord.Checked = true;
            this.chkConfig_AutoSaveWord.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkConfig_AutoSaveWord.Location = new System.Drawing.Point(8, 44);
            this.chkConfig_AutoSaveWord.Name = "chkConfig_AutoSaveWord";
            this.chkConfig_AutoSaveWord.Size = new System.Drawing.Size(105, 17);
            this.chkConfig_AutoSaveWord.TabIndex = 16;
            this.chkConfig_AutoSaveWord.Text = "Auto save words";
            this.chkConfig_AutoSaveWord.UseVisualStyleBackColor = true;
            // 
            // btnConfigClose
            // 
            this.btnConfigClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnConfigClose.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigClose.Location = new System.Drawing.Point(135, 88);
            this.btnConfigClose.Name = "btnConfigClose";
            this.btnConfigClose.Size = new System.Drawing.Size(37, 22);
            this.btnConfigClose.TabIndex = 15;
            this.btnConfigClose.Text = "Close";
            this.btnConfigClose.UseVisualStyleBackColor = true;
            this.btnConfigClose.Click += new System.EventHandler(this.btnConfigClose_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(0, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 1);
            this.label7.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "CONFIG";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTagCaption
            // 
            this.lblTagCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTagCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagCaption.ForeColor = System.Drawing.Color.Red;
            this.lblTagCaption.Location = new System.Drawing.Point(298, 145);
            this.lblTagCaption.Name = "lblTagCaption";
            this.lblTagCaption.Size = new System.Drawing.Size(340, 22);
            this.lblTagCaption.TabIndex = 15;
            this.lblTagCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTagCaption.Click += new System.EventHandler(this.lblTagCaption_Click);
            // 
            // lblWordTypeCaption
            // 
            this.lblWordTypeCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblWordTypeCaption.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordTypeCaption.Location = new System.Drawing.Point(636, 145);
            this.lblWordTypeCaption.Name = "lblWordTypeCaption";
            this.lblWordTypeCaption.Size = new System.Drawing.Size(121, 23);
            this.lblWordTypeCaption.TabIndex = 16;
            this.lblWordTypeCaption.Text = "Verb, Noun";
            this.lblWordTypeCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(351, 45);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(35, 25);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtEditSearch
            // 
            this.txtEditSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEditSearch.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditSearch.Location = new System.Drawing.Point(1, 2);
            this.txtEditSearch.Multiline = true;
            this.txtEditSearch.Name = "txtEditSearch";
            this.txtEditSearch.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEditSearch.Size = new System.Drawing.Size(351, 141);
            this.txtEditSearch.TabIndex = 18;
            this.txtEditSearch.Visible = false;
            this.txtEditSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEditSearch_KeyDown);
            // 
            // txtEditMean
            // 
            this.txtEditMean.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEditMean.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditMean.Location = new System.Drawing.Point(386, 2);
            this.txtEditMean.Multiline = true;
            this.txtEditMean.Name = "txtEditMean";
            this.txtEditMean.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEditMean.Size = new System.Drawing.Size(368, 140);
            this.txtEditMean.TabIndex = 19;
            this.txtEditMean.Visible = false;
            // 
            // lblWordIndex
            // 
            this.lblWordIndex.BackColor = System.Drawing.SystemColors.Control;
            this.lblWordIndex.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordIndex.ForeColor = System.Drawing.Color.Red;
            this.lblWordIndex.Location = new System.Drawing.Point(36, 146);
            this.lblWordIndex.Name = "lblWordIndex";
            this.lblWordIndex.Size = new System.Drawing.Size(228, 20);
            this.lblWordIndex.TabIndex = 20;
            this.lblWordIndex.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtWordIndex_MouseDoubleClick);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Location = new System.Drawing.Point(1, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(301, 22);
            this.label8.TabIndex = 21;
            this.label8.Text = "Index:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(267, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Tag:";
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 169);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTagCaption);
            this.Controls.Add(this.lblWordIndex);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblWordTypeCaption);
            this.Controls.Add(this.panelConfig);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiPanelHeader);
            this.Controls.Add(this.txtEditMean);
            this.Controls.Add(this.txtEditSearch);
            this.Controls.Add(this.btnLangType);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.webBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.uiPanelHeader.ResumeLayout(false);
            this.uiPanelHeader.PerformLayout();
            this.panelConfig.ResumeLayout(false);
            this.panelConfig.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel uiPanelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLangType;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTopic;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Button btnTagAddNew;
        private System.Windows.Forms.Panel panelConfig;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConfigClose;
        private System.Windows.Forms.CheckBox chkConfig_AutoSaveWord;
        private System.Windows.Forms.Label lblTagCaption;
        private System.Windows.Forms.Label lblWordTypeCaption;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtEditSearch;
        private System.Windows.Forms.TextBox txtEditMean;
        private System.Windows.Forms.Label lblWordIndex;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkAllowRUN;
    }
}

