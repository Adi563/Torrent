namespace Torrent.MagnetLink
{
    partial class MagnetLinkConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MagnetLinkConverter));
            this.textBoxMagnetLink = new System.Windows.Forms.TextBox();
            this.labelMagnetLink = new System.Windows.Forms.Label();
            this.labelTrackers = new System.Windows.Forms.Label();
            this.labelHash = new System.Windows.Forms.Label();
            this.textBoxHash = new System.Windows.Forms.TextBox();
            this.textBoxTrackers = new System.Windows.Forms.TextBox();
            this.groupBoxMagnetLink = new System.Windows.Forms.GroupBox();
            this.groupBoxTorrentInformation = new System.Windows.Forms.GroupBox();
            this.buttonConvertMagnetLinkToTorrentInformation = new System.Windows.Forms.Button();
            this.buttonConvertTorrentInformationToMagnetLink = new System.Windows.Forms.Button();
            this.groupBoxMagnetLink.SuspendLayout();
            this.groupBoxTorrentInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxMagnetLink
            // 
            this.textBoxMagnetLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMagnetLink.Location = new System.Drawing.Point(86, 22);
            this.textBoxMagnetLink.Name = "textBoxMagnetLink";
            this.textBoxMagnetLink.Size = new System.Drawing.Size(353, 20);
            this.textBoxMagnetLink.TabIndex = 0;
            // 
            // labelMagnetLink
            // 
            this.labelMagnetLink.AutoSize = true;
            this.labelMagnetLink.Location = new System.Drawing.Point(14, 25);
            this.labelMagnetLink.Name = "labelMagnetLink";
            this.labelMagnetLink.Size = new System.Drawing.Size(66, 13);
            this.labelMagnetLink.TabIndex = 1;
            this.labelMagnetLink.Text = "Magnet Link";
            // 
            // labelTrackers
            // 
            this.labelTrackers.AutoSize = true;
            this.labelTrackers.Location = new System.Drawing.Point(6, 72);
            this.labelTrackers.Name = "labelTrackers";
            this.labelTrackers.Size = new System.Drawing.Size(49, 13);
            this.labelTrackers.TabIndex = 3;
            this.labelTrackers.Text = "Trackers";
            // 
            // labelHash
            // 
            this.labelHash.AutoSize = true;
            this.labelHash.Location = new System.Drawing.Point(23, 39);
            this.labelHash.Name = "labelHash";
            this.labelHash.Size = new System.Drawing.Size(32, 13);
            this.labelHash.TabIndex = 4;
            this.labelHash.Text = "Hash";
            // 
            // textBoxHash
            // 
            this.textBoxHash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHash.Location = new System.Drawing.Point(61, 36);
            this.textBoxHash.Name = "textBoxHash";
            this.textBoxHash.Size = new System.Drawing.Size(378, 20);
            this.textBoxHash.TabIndex = 5;
            // 
            // textBoxTrackers
            // 
            this.textBoxTrackers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTrackers.Location = new System.Drawing.Point(61, 69);
            this.textBoxTrackers.Multiline = true;
            this.textBoxTrackers.Name = "textBoxTrackers";
            this.textBoxTrackers.Size = new System.Drawing.Size(378, 138);
            this.textBoxTrackers.TabIndex = 6;
            // 
            // groupBoxMagnetLink
            // 
            this.groupBoxMagnetLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMagnetLink.Controls.Add(this.labelMagnetLink);
            this.groupBoxMagnetLink.Controls.Add(this.textBoxMagnetLink);
            this.groupBoxMagnetLink.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMagnetLink.Name = "groupBoxMagnetLink";
            this.groupBoxMagnetLink.Size = new System.Drawing.Size(445, 48);
            this.groupBoxMagnetLink.TabIndex = 7;
            this.groupBoxMagnetLink.TabStop = false;
            this.groupBoxMagnetLink.Text = "Magnet Link";
            // 
            // groupBoxTorrentInformation
            // 
            this.groupBoxTorrentInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTorrentInformation.Controls.Add(this.labelHash);
            this.groupBoxTorrentInformation.Controls.Add(this.labelTrackers);
            this.groupBoxTorrentInformation.Controls.Add(this.textBoxTrackers);
            this.groupBoxTorrentInformation.Controls.Add(this.textBoxHash);
            this.groupBoxTorrentInformation.Location = new System.Drawing.Point(12, 119);
            this.groupBoxTorrentInformation.Name = "groupBoxTorrentInformation";
            this.groupBoxTorrentInformation.Size = new System.Drawing.Size(445, 213);
            this.groupBoxTorrentInformation.TabIndex = 8;
            this.groupBoxTorrentInformation.TabStop = false;
            this.groupBoxTorrentInformation.Text = "Torrent Information";
            // 
            // buttonConvertMagnetLinkToTorrentInformation
            // 
            this.buttonConvertMagnetLinkToTorrentInformation.Location = new System.Drawing.Point(73, 66);
            this.buttonConvertMagnetLinkToTorrentInformation.Name = "buttonConvertMagnetLinkToTorrentInformation";
            this.buttonConvertMagnetLinkToTorrentInformation.Size = new System.Drawing.Size(75, 47);
            this.buttonConvertMagnetLinkToTorrentInformation.TabIndex = 9;
            this.buttonConvertMagnetLinkToTorrentInformation.Text = "V";
            this.buttonConvertMagnetLinkToTorrentInformation.UseVisualStyleBackColor = true;
            this.buttonConvertMagnetLinkToTorrentInformation.Click += new System.EventHandler(this.buttonConvertMagnetLinkToTorrentInformation_Click);
            // 
            // buttonConvertTorrentInformationToMagnetLink
            // 
            this.buttonConvertTorrentInformationToMagnetLink.Location = new System.Drawing.Point(154, 66);
            this.buttonConvertTorrentInformationToMagnetLink.Name = "buttonConvertTorrentInformationToMagnetLink";
            this.buttonConvertTorrentInformationToMagnetLink.Size = new System.Drawing.Size(75, 47);
            this.buttonConvertTorrentInformationToMagnetLink.TabIndex = 9;
            this.buttonConvertTorrentInformationToMagnetLink.Text = "A";
            this.buttonConvertTorrentInformationToMagnetLink.UseVisualStyleBackColor = true;
            this.buttonConvertTorrentInformationToMagnetLink.Click += new System.EventHandler(this.buttonConvertTorrentInformationToMagnetLink_Click);
            // 
            // MagnetLinkConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 344);
            this.Controls.Add(this.buttonConvertTorrentInformationToMagnetLink);
            this.Controls.Add(this.buttonConvertMagnetLinkToTorrentInformation);
            this.Controls.Add(this.groupBoxTorrentInformation);
            this.Controls.Add(this.groupBoxMagnetLink);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MagnetLinkConverter";
            this.Text = "Magnet Link Editor";
            this.groupBoxMagnetLink.ResumeLayout(false);
            this.groupBoxMagnetLink.PerformLayout();
            this.groupBoxTorrentInformation.ResumeLayout(false);
            this.groupBoxTorrentInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMagnetLink;
        private System.Windows.Forms.Label labelMagnetLink;
        private System.Windows.Forms.Label labelTrackers;
        private System.Windows.Forms.Label labelHash;
        private System.Windows.Forms.TextBox textBoxHash;
        private System.Windows.Forms.TextBox textBoxTrackers;
        private System.Windows.Forms.GroupBox groupBoxMagnetLink;
        private System.Windows.Forms.GroupBox groupBoxTorrentInformation;
        private System.Windows.Forms.Button buttonConvertMagnetLinkToTorrentInformation;
        private System.Windows.Forms.Button buttonConvertTorrentInformationToMagnetLink;
    }
}

