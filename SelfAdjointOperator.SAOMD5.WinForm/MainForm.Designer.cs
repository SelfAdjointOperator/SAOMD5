namespace SelfAdjointOperator.SAOMD5.WinForm
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LabelSHA512Hash = new System.Windows.Forms.Label();
            this.LabelSHA512 = new System.Windows.Forms.Label();
            this.LabelFilenameValue = new System.Windows.Forms.Label();
            this.LabelFilename = new System.Windows.Forms.Label();
            this.LabelSHA256Hash = new System.Windows.Forms.Label();
            this.LabelSHA256 = new System.Windows.Forms.Label();
            this.LabelMD5Hash = new System.Windows.Forms.Label();
            this.LabelMD5 = new System.Windows.Forms.Label();
            this.MainTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.AutoSize = true;
            this.MainTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.MainTableLayoutPanel.ColumnCount = 2;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.MainTableLayoutPanel.Controls.Add(this.LabelSHA512Hash, 1, 3);
            this.MainTableLayoutPanel.Controls.Add(this.LabelSHA512, 0, 3);
            this.MainTableLayoutPanel.Controls.Add(this.LabelFilenameValue, 1, 0);
            this.MainTableLayoutPanel.Controls.Add(this.LabelFilename, 0, 0);
            this.MainTableLayoutPanel.Controls.Add(this.LabelSHA256Hash, 1, 2);
            this.MainTableLayoutPanel.Controls.Add(this.LabelSHA256, 0, 2);
            this.MainTableLayoutPanel.Controls.Add(this.LabelMD5Hash, 1, 1);
            this.MainTableLayoutPanel.Controls.Add(this.LabelMD5, 0, 1);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 4;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(782, 193);
            this.MainTableLayoutPanel.TabIndex = 1;
            // 
            // LabelSHA512Hash
            // 
            this.LabelSHA512Hash.AutoSize = true;
            this.LabelSHA512Hash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelSHA512Hash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelSHA512Hash.Location = new System.Drawing.Point(162, 143);
            this.LabelSHA512Hash.Name = "LabelSHA512Hash";
            this.LabelSHA512Hash.Size = new System.Drawing.Size(615, 48);
            this.LabelSHA512Hash.TabIndex = 10;
            this.LabelSHA512Hash.Text = "Click To Get Hash";
            this.LabelSHA512Hash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelSHA512Hash.Click += new System.EventHandler(this.LabelSHA512Hash_Click);
            // 
            // LabelSHA512
            // 
            this.LabelSHA512.AutoSize = true;
            this.LabelSHA512.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelSHA512.Location = new System.Drawing.Point(5, 143);
            this.LabelSHA512.Name = "LabelSHA512";
            this.LabelSHA512.Size = new System.Drawing.Size(149, 48);
            this.LabelSHA512.TabIndex = 9;
            this.LabelSHA512.Text = "SHA512:";
            this.LabelSHA512.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelFilenameValue
            // 
            this.LabelFilenameValue.AutoSize = true;
            this.LabelFilenameValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelFilenameValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelFilenameValue.Location = new System.Drawing.Point(162, 2);
            this.LabelFilenameValue.Name = "LabelFilenameValue";
            this.LabelFilenameValue.Size = new System.Drawing.Size(615, 45);
            this.LabelFilenameValue.TabIndex = 8;
            this.LabelFilenameValue.Text = "Getting Filename...";
            this.LabelFilenameValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelFilename
            // 
            this.LabelFilename.AutoSize = true;
            this.LabelFilename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelFilename.Location = new System.Drawing.Point(5, 2);
            this.LabelFilename.Name = "LabelFilename";
            this.LabelFilename.Size = new System.Drawing.Size(149, 45);
            this.LabelFilename.TabIndex = 7;
            this.LabelFilename.Text = "Filename:";
            this.LabelFilename.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelSHA256Hash
            // 
            this.LabelSHA256Hash.AutoSize = true;
            this.LabelSHA256Hash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelSHA256Hash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelSHA256Hash.Location = new System.Drawing.Point(162, 96);
            this.LabelSHA256Hash.Name = "LabelSHA256Hash";
            this.LabelSHA256Hash.Size = new System.Drawing.Size(615, 45);
            this.LabelSHA256Hash.TabIndex = 6;
            this.LabelSHA256Hash.Text = "Click To Get Hash";
            this.LabelSHA256Hash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelSHA256Hash.Click += new System.EventHandler(this.LabelSHA256Hash_Click);
            // 
            // LabelSHA256
            // 
            this.LabelSHA256.AutoSize = true;
            this.LabelSHA256.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelSHA256.Location = new System.Drawing.Point(5, 96);
            this.LabelSHA256.Name = "LabelSHA256";
            this.LabelSHA256.Size = new System.Drawing.Size(149, 45);
            this.LabelSHA256.TabIndex = 5;
            this.LabelSHA256.Text = "SHA256:";
            this.LabelSHA256.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelMD5Hash
            // 
            this.LabelMD5Hash.AutoSize = true;
            this.LabelMD5Hash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelMD5Hash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelMD5Hash.Location = new System.Drawing.Point(162, 49);
            this.LabelMD5Hash.Name = "LabelMD5Hash";
            this.LabelMD5Hash.Size = new System.Drawing.Size(615, 45);
            this.LabelMD5Hash.TabIndex = 3;
            this.LabelMD5Hash.Text = "Getting Hash...";
            this.LabelMD5Hash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelMD5
            // 
            this.LabelMD5.AutoSize = true;
            this.LabelMD5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelMD5.Location = new System.Drawing.Point(5, 49);
            this.LabelMD5.Name = "LabelMD5";
            this.LabelMD5.Size = new System.Drawing.Size(149, 45);
            this.LabelMD5.TabIndex = 4;
            this.LabelMD5.Text = "MD5:";
            this.LabelMD5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 193);
            this.Controls.Add(this.MainTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAOMD5";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.MainTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.Label LabelMD5Hash;
        private System.Windows.Forms.Label LabelMD5;
        private System.Windows.Forms.Label LabelSHA256Hash;
        private System.Windows.Forms.Label LabelSHA256;
        private System.Windows.Forms.Label LabelFilenameValue;
        private System.Windows.Forms.Label LabelFilename;
        private System.Windows.Forms.Label LabelSHA512;
        private System.Windows.Forms.Label LabelSHA512Hash;
    }
}

