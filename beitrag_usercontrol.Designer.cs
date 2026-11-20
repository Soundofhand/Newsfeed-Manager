namespace Newsfeed_Manager
{
    partial class beitrag_usercontrol
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.table_Layout_base_panel = new System.Windows.Forms.TableLayoutPanel();
            this.feed_change_link_label = new System.Windows.Forms.LinkLabel();
            this.feed_title_label = new System.Windows.Forms.Label();
            this.feed_content_label = new System.Windows.Forms.Label();
            this.table_Layout_base_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // table_Layout_base_panel
            // 
            this.table_Layout_base_panel.ColumnCount = 2;
            this.table_Layout_base_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.38095F));
            this.table_Layout_base_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.61905F));
            this.table_Layout_base_panel.Controls.Add(this.feed_change_link_label, 1, 0);
            this.table_Layout_base_panel.Controls.Add(this.feed_title_label, 0, 0);
            this.table_Layout_base_panel.Controls.Add(this.feed_content_label, 0, 1);
            this.table_Layout_base_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_Layout_base_panel.Location = new System.Drawing.Point(0, 0);
            this.table_Layout_base_panel.Name = "table_Layout_base_panel";
            this.table_Layout_base_panel.RowCount = 2;
            this.table_Layout_base_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.27027F));
            this.table_Layout_base_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.72973F));
            this.table_Layout_base_panel.Size = new System.Drawing.Size(420, 148);
            this.table_Layout_base_panel.TabIndex = 0;
            // 
            // feed_change_link_label
            // 
            this.feed_change_link_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.feed_change_link_label.Location = new System.Drawing.Point(307, 0);
            this.feed_change_link_label.Name = "feed_change_link_label";
            this.feed_change_link_label.Size = new System.Drawing.Size(110, 29);
            this.feed_change_link_label.TabIndex = 1;
            this.feed_change_link_label.TabStop = true;
            this.feed_change_link_label.Text = "linkLabel1";
            // 
            // feed_title_label
            // 
            this.feed_title_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.feed_title_label.Location = new System.Drawing.Point(3, 0);
            this.feed_title_label.Name = "feed_title_label";
            this.feed_title_label.Size = new System.Drawing.Size(298, 29);
            this.feed_title_label.TabIndex = 0;
            this.feed_title_label.Text = "label1";
            // 
            // feed_content_label
            // 
            this.table_Layout_base_panel.SetColumnSpan(this.feed_content_label, 2);
            this.feed_content_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.feed_content_label.Location = new System.Drawing.Point(3, 29);
            this.feed_content_label.Name = "feed_content_label";
            this.feed_content_label.Size = new System.Drawing.Size(414, 119);
            this.feed_content_label.TabIndex = 2;
            this.feed_content_label.Text = "label2";
            // 
            // beitrag_usercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table_Layout_base_panel);
            this.Name = "beitrag_usercontrol";
            this.Size = new System.Drawing.Size(420, 148);
            this.table_Layout_base_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel table_Layout_base_panel;
        private System.Windows.Forms.LinkLabel feed_change_link_label;
        private System.Windows.Forms.Label feed_title_label;
        private System.Windows.Forms.Label feed_content_label;
    }
}
