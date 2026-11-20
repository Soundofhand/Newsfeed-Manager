namespace Newsfeed_Manager
{
    partial class subkategorie_control
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.subkategorie_control_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(18, 57);
            this.panel1.TabIndex = 0;
            // 
            // subkategorie_control_label
            // 
            this.subkategorie_control_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.subkategorie_control_label.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subkategorie_control_label.ForeColor = System.Drawing.Color.Red;
            this.subkategorie_control_label.Location = new System.Drawing.Point(18, 0);
            this.subkategorie_control_label.Name = "subkategorie_control_label";
            this.subkategorie_control_label.Size = new System.Drawing.Size(375, 57);
            this.subkategorie_control_label.TabIndex = 0;
            this.subkategorie_control_label.Text = "subkategorie";
            this.subkategorie_control_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subkategorie_control_label.Click += new System.EventHandler(this.subkategorie_control_label_Click);
            // 
            // subkategorie_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.subkategorie_control_label);
            this.Controls.Add(this.panel1);
            this.Name = "subkategorie_control";
            this.Size = new System.Drawing.Size(393, 57);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label subkategorie_control_label;
    }
}
