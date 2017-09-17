namespace Friends_from_MegaVideo_player
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.Flash = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.cmbBox = new System.Windows.Forms.ComboBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zPlikuLokalnegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zInternetuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odtwórzNastęnyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odtwórzPoprzedniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sezon1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sezon2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sezon3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sezon4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sezon5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sezon6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sezon7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sezon8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sezon9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sezon10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odcSpecjalneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaznaczWszystkieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odznaczWszyskieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Stan = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnEpisodesList = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnToHTML = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.Flash)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.Stan.SuspendLayout();
            this.SuspendLayout();
            // 
            // Flash
            // 
            this.Flash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flash.Enabled = true;
            this.Flash.Location = new System.Drawing.Point(0, 24);
            this.Flash.Name = "Flash";
            this.Flash.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Flash.OcxState")));
            this.Flash.Size = new System.Drawing.Size(503, 184);
            this.Flash.TabIndex = 0;
            this.Flash.Visible = false;
            // 
            // cmbBox
            // 
            this.cmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox.FormattingEnabled = true;
            this.cmbBox.Location = new System.Drawing.Point(12, 36);
            this.cmbBox.Name = "cmbBox";
            this.cmbBox.Size = new System.Drawing.Size(479, 21);
            this.cmbBox.TabIndex = 1;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.Location = new System.Drawing.Point(12, 63);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Odtwarzaj";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(394, 8);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(97, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Strona z odcinkami";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.filtryToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(503, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwórzToolStripMenuItem,
            this.odtwórzNastęnyToolStripMenuItem,
            this.odtwórzPoprzedniToolStripMenuItem,
            this.zamknijToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zPlikuLokalnegoToolStripMenuItem,
            this.zInternetuToolStripMenuItem});
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.otwórzToolStripMenuItem.Text = "Otwórz...";
            // 
            // zPlikuLokalnegoToolStripMenuItem
            // 
            this.zPlikuLokalnegoToolStripMenuItem.Name = "zPlikuLokalnegoToolStripMenuItem";
            this.zPlikuLokalnegoToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.zPlikuLokalnegoToolStripMenuItem.Text = "Z pliku lokalnego";
            this.zPlikuLokalnegoToolStripMenuItem.Click += new System.EventHandler(this.zPlikuLokalnegoToolStripMenuItem_Click);
            // 
            // zInternetuToolStripMenuItem
            // 
            this.zInternetuToolStripMenuItem.Name = "zInternetuToolStripMenuItem";
            this.zInternetuToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.zInternetuToolStripMenuItem.Text = "Z internetu";
            // 
            // odtwórzNastęnyToolStripMenuItem
            // 
            this.odtwórzNastęnyToolStripMenuItem.Name = "odtwórzNastęnyToolStripMenuItem";
            this.odtwórzNastęnyToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.odtwórzNastęnyToolStripMenuItem.Text = "Odtwórz nastęny";
            this.odtwórzNastęnyToolStripMenuItem.Click += new System.EventHandler(this.odtwórzNastęnyToolStripMenuItem_Click);
            // 
            // odtwórzPoprzedniToolStripMenuItem
            // 
            this.odtwórzPoprzedniToolStripMenuItem.Name = "odtwórzPoprzedniToolStripMenuItem";
            this.odtwórzPoprzedniToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.odtwórzPoprzedniToolStripMenuItem.Text = "Odtwórz poprzedni";
            this.odtwórzPoprzedniToolStripMenuItem.Click += new System.EventHandler(this.odtwórzPoprzedniToolStripMenuItem_Click);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // filtryToolStripMenuItem
            // 
            this.filtryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sezon1ToolStripMenuItem,
            this.sezon2ToolStripMenuItem,
            this.sezon3ToolStripMenuItem,
            this.sezon4ToolStripMenuItem,
            this.sezon5ToolStripMenuItem,
            this.sezon6ToolStripMenuItem,
            this.sezon7ToolStripMenuItem,
            this.sezon8ToolStripMenuItem,
            this.sezon9ToolStripMenuItem,
            this.sezon10ToolStripMenuItem,
            this.odcSpecjalneToolStripMenuItem,
            this.zaznaczWszystkieToolStripMenuItem,
            this.odznaczWszyskieToolStripMenuItem});
            this.filtryToolStripMenuItem.Name = "filtryToolStripMenuItem";
            this.filtryToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.filtryToolStripMenuItem.Text = "Filtry";
            // 
            // sezon1ToolStripMenuItem
            // 
            this.sezon1ToolStripMenuItem.Checked = true;
            this.sezon1ToolStripMenuItem.CheckOnClick = true;
            this.sezon1ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sezon1ToolStripMenuItem.Name = "sezon1ToolStripMenuItem";
            this.sezon1ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.sezon1ToolStripMenuItem.Text = "Sezon 1";
            this.sezon1ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.sezon1ToolStripMenuItem_CheckedChanged);
            // 
            // sezon2ToolStripMenuItem
            // 
            this.sezon2ToolStripMenuItem.Checked = true;
            this.sezon2ToolStripMenuItem.CheckOnClick = true;
            this.sezon2ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sezon2ToolStripMenuItem.Name = "sezon2ToolStripMenuItem";
            this.sezon2ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.sezon2ToolStripMenuItem.Text = "Sezon 2";
            this.sezon2ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.sezon1ToolStripMenuItem_CheckedChanged);
            // 
            // sezon3ToolStripMenuItem
            // 
            this.sezon3ToolStripMenuItem.Checked = true;
            this.sezon3ToolStripMenuItem.CheckOnClick = true;
            this.sezon3ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sezon3ToolStripMenuItem.Name = "sezon3ToolStripMenuItem";
            this.sezon3ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.sezon3ToolStripMenuItem.Text = "Sezon 3";
            this.sezon3ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.sezon1ToolStripMenuItem_CheckedChanged);
            // 
            // sezon4ToolStripMenuItem
            // 
            this.sezon4ToolStripMenuItem.Checked = true;
            this.sezon4ToolStripMenuItem.CheckOnClick = true;
            this.sezon4ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sezon4ToolStripMenuItem.Name = "sezon4ToolStripMenuItem";
            this.sezon4ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.sezon4ToolStripMenuItem.Text = "Sezon 4";
            this.sezon4ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.sezon1ToolStripMenuItem_CheckedChanged);
            // 
            // sezon5ToolStripMenuItem
            // 
            this.sezon5ToolStripMenuItem.Checked = true;
            this.sezon5ToolStripMenuItem.CheckOnClick = true;
            this.sezon5ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sezon5ToolStripMenuItem.Name = "sezon5ToolStripMenuItem";
            this.sezon5ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.sezon5ToolStripMenuItem.Text = "Sezon 5";
            this.sezon5ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.sezon1ToolStripMenuItem_CheckedChanged);
            // 
            // sezon6ToolStripMenuItem
            // 
            this.sezon6ToolStripMenuItem.Checked = true;
            this.sezon6ToolStripMenuItem.CheckOnClick = true;
            this.sezon6ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sezon6ToolStripMenuItem.Name = "sezon6ToolStripMenuItem";
            this.sezon6ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.sezon6ToolStripMenuItem.Text = "Sezon 6";
            this.sezon6ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.sezon1ToolStripMenuItem_CheckedChanged);
            // 
            // sezon7ToolStripMenuItem
            // 
            this.sezon7ToolStripMenuItem.Checked = true;
            this.sezon7ToolStripMenuItem.CheckOnClick = true;
            this.sezon7ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sezon7ToolStripMenuItem.Name = "sezon7ToolStripMenuItem";
            this.sezon7ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.sezon7ToolStripMenuItem.Text = "Sezon 7";
            this.sezon7ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.sezon1ToolStripMenuItem_CheckedChanged);
            // 
            // sezon8ToolStripMenuItem
            // 
            this.sezon8ToolStripMenuItem.Checked = true;
            this.sezon8ToolStripMenuItem.CheckOnClick = true;
            this.sezon8ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sezon8ToolStripMenuItem.Name = "sezon8ToolStripMenuItem";
            this.sezon8ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.sezon8ToolStripMenuItem.Text = "Sezon 8";
            this.sezon8ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.sezon1ToolStripMenuItem_CheckedChanged);
            // 
            // sezon9ToolStripMenuItem
            // 
            this.sezon9ToolStripMenuItem.Checked = true;
            this.sezon9ToolStripMenuItem.CheckOnClick = true;
            this.sezon9ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sezon9ToolStripMenuItem.Name = "sezon9ToolStripMenuItem";
            this.sezon9ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.sezon9ToolStripMenuItem.Text = "Sezon 9";
            this.sezon9ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.sezon1ToolStripMenuItem_CheckedChanged);
            // 
            // sezon10ToolStripMenuItem
            // 
            this.sezon10ToolStripMenuItem.Checked = true;
            this.sezon10ToolStripMenuItem.CheckOnClick = true;
            this.sezon10ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sezon10ToolStripMenuItem.Name = "sezon10ToolStripMenuItem";
            this.sezon10ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.sezon10ToolStripMenuItem.Text = "Sezon 10";
            this.sezon10ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.sezon1ToolStripMenuItem_CheckedChanged);
            // 
            // odcSpecjalneToolStripMenuItem
            // 
            this.odcSpecjalneToolStripMenuItem.Checked = true;
            this.odcSpecjalneToolStripMenuItem.CheckOnClick = true;
            this.odcSpecjalneToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.odcSpecjalneToolStripMenuItem.Name = "odcSpecjalneToolStripMenuItem";
            this.odcSpecjalneToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.odcSpecjalneToolStripMenuItem.Text = "Odc. Specjalne";
            this.odcSpecjalneToolStripMenuItem.CheckedChanged += new System.EventHandler(this.sezon1ToolStripMenuItem_CheckedChanged);
            // 
            // zaznaczWszystkieToolStripMenuItem
            // 
            this.zaznaczWszystkieToolStripMenuItem.Name = "zaznaczWszystkieToolStripMenuItem";
            this.zaznaczWszystkieToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.zaznaczWszystkieToolStripMenuItem.Text = "Zaznacz wszystkie";
            this.zaznaczWszystkieToolStripMenuItem.Click += new System.EventHandler(this.zaznaczWszystkieToolStripMenuItem_Click);
            // 
            // odznaczWszyskieToolStripMenuItem
            // 
            this.odznaczWszyskieToolStripMenuItem.Name = "odznaczWszyskieToolStripMenuItem";
            this.odznaczWszyskieToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.odznaczWszyskieToolStripMenuItem.Text = "Odznacz wszyskie";
            this.odznaczWszyskieToolStripMenuItem.Click += new System.EventHandler(this.odznaczWszyskieToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            this.pomocToolStripMenuItem.Click += new System.EventHandler(this.pomocToolStripMenuItem_Click);
            // 
            // Stan
            // 
            this.Stan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.Stan.Location = new System.Drawing.Point(0, 186);
            this.Stan.Name = "Stan";
            this.Stan.ShowItemToolTips = true;
            this.Stan.Size = new System.Drawing.Size(503, 22);
            this.Stan.SizingGrip = false;
            this.Stan.TabIndex = 5;
            this.Stan.Text = "statusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(4, 17);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Friends - lista odcinków";
            this.openFileDialog.Filter = "Pliki xml|*.xml|Wszystkie pliki|*.*";
            this.openFileDialog.Title = "Otwórz dokument XML";
            // 
            // btnEpisodesList
            // 
            this.btnEpisodesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.btnEpisodesList.Location = new System.Drawing.Point(411, 63);
            this.btnEpisodesList.Name = "btnEpisodesList";
            this.btnEpisodesList.Size = new System.Drawing.Size(80, 23);
            this.btnEpisodesList.TabIndex = 6;
            this.btnEpisodesList.Text = "Pokaż listę odc.";
            this.btnEpisodesList.UseVisualStyleBackColor = true;
            this.btnEpisodesList.Click += new System.EventHandler(this.btnEpisodesList_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "html";
            this.saveFileDialog.FileName = "Friends Episodes";
            this.saveFileDialog.Filter = "Pliki HTML|*.html";
            this.saveFileDialog.RestoreDirectory = true;
            this.saveFileDialog.Title = "Zapisz listę odcinków jako plik HTML";
            // 
            // btnToHTML
            // 
            this.btnToHTML.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.btnToHTML.Location = new System.Drawing.Point(192, 63);
            this.btnToHTML.Name = "btnToHTML";
            this.btnToHTML.Size = new System.Drawing.Size(101, 23);
            this.btnToHTML.TabIndex = 7;
            this.btnToHTML.Text = "Zapisz listę do HTML";
            this.btnToHTML.UseVisualStyleBackColor = true;
            this.btnToHTML.Click += new System.EventHandler(this.btnToHTML_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 208);
            this.Controls.Add(this.btnToHTML);
            this.Controls.Add(this.btnEpisodesList);
            this.Controls.Add(this.Stan);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.cmbBox);
            this.Controls.Add(this.Flash);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.Text = "Przyjaciele Player";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.Shown += new System.EventHandler(this.MainFrm_Shown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainFrm_KeyUp_1);
            ((System.ComponentModel.ISupportInitialize)(this.Flash)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Stan.ResumeLayout(false);
            this.Stan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxShockwaveFlashObjects.AxShockwaveFlash Flash;
        private System.Windows.Forms.ComboBox cmbBox;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sezon1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sezon2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sezon3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sezon4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sezon5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sezon6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sezon7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sezon8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sezon9ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sezon10ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip Stan;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem zPlikuLokalnegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zInternetuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaznaczWszystkieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odznaczWszyskieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odcSpecjalneToolStripMenuItem;
        private System.Windows.Forms.Button btnEpisodesList;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnToHTML;
        private System.Windows.Forms.ToolStripMenuItem odtwórzNastęnyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odtwórzPoprzedniToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker;



    }
}

