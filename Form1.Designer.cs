namespace Newsfeed_Manager
{
    partial class base_window
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(base_window));
            this.kategorien_panel = new System.Windows.Forms.Panel();
            this.kategorien_header_panel = new System.Windows.Forms.Panel();
            this.kategorie_label = new System.Windows.Forms.Label();
            this.kategorien_burger_button = new System.Windows.Forms.Button();
            this.new_kategorien_button = new System.Windows.Forms.LinkLabel();
            this.Beitrag_hinzufuegen_panel = new System.Windows.Forms.Panel();
            this.neuen_beitrag_hinzufuegen_panel = new System.Windows.Forms.Label();
            this.news_panel = new System.Windows.Forms.Panel();
            this.subkategorien_panel = new System.Windows.Forms.Panel();
            this.neue_kategorie_panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TollStripDownButton1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.binaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabelFiller = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mySQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorien_panel.SuspendLayout();
            this.kategorien_header_panel.SuspendLayout();
            this.Beitrag_hinzufuegen_panel.SuspendLayout();
            this.neue_kategorie_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kategorien_panel
            // 
            this.kategorien_panel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.kategorien_panel.Controls.Add(this.kategorien_header_panel);
            resources.ApplyResources(this.kategorien_panel, "kategorien_panel");
            this.kategorien_panel.Name = "kategorien_panel";
            // 
            // kategorien_header_panel
            // 
            this.kategorien_header_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kategorien_header_panel.Controls.Add(this.kategorie_label);
            this.kategorien_header_panel.Controls.Add(this.kategorien_burger_button);
            resources.ApplyResources(this.kategorien_header_panel, "kategorien_header_panel");
            this.kategorien_header_panel.Name = "kategorien_header_panel";
            // 
            // kategorie_label
            // 
            resources.ApplyResources(this.kategorie_label, "kategorie_label");
            this.kategorie_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kategorie_label.Name = "kategorie_label";
            // 
            // kategorien_burger_button
            // 
            resources.ApplyResources(this.kategorien_burger_button, "kategorien_burger_button");
            this.kategorien_burger_button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.kategorien_burger_button.Name = "kategorien_burger_button";
            this.kategorien_burger_button.UseVisualStyleBackColor = true;
            // 
            // new_kategorien_button
            // 
            this.new_kategorien_button.ActiveLinkColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.new_kategorien_button, "new_kategorien_button");
            this.new_kategorien_button.LinkColor = System.Drawing.Color.Black;
            this.new_kategorien_button.LinkVisited = true;
            this.new_kategorien_button.Name = "new_kategorien_button";
            this.new_kategorien_button.TabStop = true;
            this.new_kategorien_button.VisitedLinkColor = System.Drawing.Color.Black;
            this.new_kategorien_button.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.new_kategorien_button_LinkClicked);
            // 
            // Beitrag_hinzufuegen_panel
            // 
            this.Beitrag_hinzufuegen_panel.Controls.Add(this.neuen_beitrag_hinzufuegen_panel);
            resources.ApplyResources(this.Beitrag_hinzufuegen_panel, "Beitrag_hinzufuegen_panel");
            this.Beitrag_hinzufuegen_panel.Name = "Beitrag_hinzufuegen_panel";
            // 
            // neuen_beitrag_hinzufuegen_panel
            // 
            resources.ApplyResources(this.neuen_beitrag_hinzufuegen_panel, "neuen_beitrag_hinzufuegen_panel");
            this.neuen_beitrag_hinzufuegen_panel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.neuen_beitrag_hinzufuegen_panel.Name = "neuen_beitrag_hinzufuegen_panel";
            this.neuen_beitrag_hinzufuegen_panel.Click += new System.EventHandler(this.neuen_beitrag_hinzufuegen_panel_Click);
            // 
            // news_panel
            // 
            resources.ApplyResources(this.news_panel, "news_panel");
            this.news_panel.Name = "news_panel";
            // 
            // subkategorien_panel
            // 
            this.subkategorien_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.subkategorien_panel, "subkategorien_panel");
            this.subkategorien_panel.Name = "subkategorien_panel";
            // 
            // neue_kategorie_panel
            // 
            this.neue_kategorie_panel.Controls.Add(this.new_kategorien_button);
            resources.ApplyResources(this.neue_kategorie_panel, "neue_kategorie_panel");
            this.neue_kategorie_panel.Name = "neue_kategorie_panel";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.subkategorien_panel);
            this.panel1.Controls.Add(this.kategorien_panel);
            this.panel1.Controls.Add(this.neue_kategorie_panel);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TollStripDownButton1,
            this.toolStripDropDownButton1,
            this.toolStripStatusLabelFiller,
            this.toolStripStatusLabel3});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // TollStripDownButton1
            // 
            this.TollStripDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TollStripDownButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TollStripDownButton1.LinkColor = System.Drawing.Color.Black;
            this.TollStripDownButton1.Name = "TollStripDownButton1";
            resources.ApplyResources(this.TollStripDownButton1, "TollStripDownButton1");
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binaryToolStripMenuItem,
            this.xMLToolStripMenuItem,
            this.textToolStripMenuItem,
            this.sQLiteToolStripMenuItem,
            this.msSQLToolStripMenuItem,
            this.mySQLToolStripMenuItem});
            resources.ApplyResources(this.toolStripDropDownButton1, "toolStripDropDownButton1");
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            // 
            // binaryToolStripMenuItem
            // 
            this.binaryToolStripMenuItem.Name = "binaryToolStripMenuItem";
            resources.ApplyResources(this.binaryToolStripMenuItem, "binaryToolStripMenuItem");
            this.binaryToolStripMenuItem.Click += new System.EventHandler(this.binaryToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            resources.ApplyResources(this.xMLToolStripMenuItem, "xMLToolStripMenuItem");
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.xMLToolStripMenuItem_Click);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            resources.ApplyResources(this.textToolStripMenuItem, "textToolStripMenuItem");
            this.textToolStripMenuItem.Click += new System.EventHandler(this.textToolStripMenuItem_Click);
            // 
            // sQLiteToolStripMenuItem
            // 
            this.sQLiteToolStripMenuItem.Name = "sQLiteToolStripMenuItem";
            resources.ApplyResources(this.sQLiteToolStripMenuItem, "sQLiteToolStripMenuItem");
            this.sQLiteToolStripMenuItem.Click += new System.EventHandler(this.sQLiteToolStripMenuItem_Click);
            // 
            // msSQLToolStripMenuItem
            // 
            this.msSQLToolStripMenuItem.Name = "msSQLToolStripMenuItem";
            resources.ApplyResources(this.msSQLToolStripMenuItem, "msSQLToolStripMenuItem");
            this.msSQLToolStripMenuItem.Click += new System.EventHandler(this.msSQLToolStripMenuItem_Click);
            // 
            // toolStripStatusLabelFiller
            // 
            this.toolStripStatusLabelFiller.Name = "toolStripStatusLabelFiller";
            resources.ApplyResources(this.toolStripStatusLabelFiller, "toolStripStatusLabelFiller");
            this.toolStripStatusLabelFiller.Spring = true;
            // 
            // toolStripStatusLabel3
            // 
            resources.ApplyResources(this.toolStripStatusLabel3, "toolStripStatusLabel3");
            this.toolStripStatusLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Click += new System.EventHandler(this.alleaenderungenspeichern_clickevent);
            // 
            // mySQLToolStripMenuItem
            // 
            this.mySQLToolStripMenuItem.Name = "mySQLToolStripMenuItem";
            resources.ApplyResources(this.mySQLToolStripMenuItem, "mySQLToolStripMenuItem");
            this.mySQLToolStripMenuItem.Click += new System.EventHandler(this.mySQLToolStripMenuItem_Click);
            // 
            // base_window
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.news_panel);
            this.Controls.Add(this.Beitrag_hinzufuegen_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "base_window";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.kategorien_panel.ResumeLayout(false);
            this.kategorien_header_panel.ResumeLayout(false);
            this.kategorien_header_panel.PerformLayout();
            this.Beitrag_hinzufuegen_panel.ResumeLayout(false);
            this.neue_kategorie_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel kategorien_panel;
        private System.Windows.Forms.Panel kategorien_header_panel;
        private System.Windows.Forms.Label kategorie_label;
        private System.Windows.Forms.Panel Beitrag_hinzufuegen_panel;
        private System.Windows.Forms.Label neuen_beitrag_hinzufuegen_panel;
        private System.Windows.Forms.Panel news_panel;
        private System.Windows.Forms.LinkLabel new_kategorien_button;
        private System.Windows.Forms.Button kategorien_burger_button;
        private System.Windows.Forms.Panel subkategorien_panel;
        private System.Windows.Forms.Panel neue_kategorie_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TollStripDownButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem binaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFiller;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripMenuItem sQLiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msSQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mySQLToolStripMenuItem;
    }
}

