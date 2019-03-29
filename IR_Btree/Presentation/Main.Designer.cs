namespace IR_Btree_Indexer
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addADocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseDocumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wildBtn = new System.Windows.Forms.Button();
            this.wordBtn = new System.Windows.Forms.Button();
            this.wildText = new System.Windows.Forms.TextBox();
            this.wordText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resultsText = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusPcName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnClearRes = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.documentsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // documentsToolStripMenuItem
            // 
            this.documentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addADocumentToolStripMenuItem,
            this.browseDocumentsToolStripMenuItem});
            this.documentsToolStripMenuItem.Name = "documentsToolStripMenuItem";
            this.documentsToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.documentsToolStripMenuItem.Text = "Documents";
            // 
            // addADocumentToolStripMenuItem
            // 
            this.addADocumentToolStripMenuItem.Name = "addADocumentToolStripMenuItem";
            this.addADocumentToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.addADocumentToolStripMenuItem.Text = "Add a document";
            this.addADocumentToolStripMenuItem.Click += new System.EventHandler(this.addADocumentToolStripMenuItem_Click);
            // 
            // browseDocumentsToolStripMenuItem
            // 
            this.browseDocumentsToolStripMenuItem.Name = "browseDocumentsToolStripMenuItem";
            this.browseDocumentsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.browseDocumentsToolStripMenuItem.Text = "Browse documents";
            this.browseDocumentsToolStripMenuItem.Click += new System.EventHandler(this.browseDocumentsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.wildBtn);
            this.groupBox1.Controls.Add(this.wordBtn);
            this.groupBox1.Controls.Add(this.wildText);
            this.groupBox1.Controls.Add(this.wordText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 110);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search in documents";
            // 
            // wildBtn
            // 
            this.wildBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.wildBtn.Location = new System.Drawing.Point(402, 72);
            this.wildBtn.Name = "wildBtn";
            this.wildBtn.Size = new System.Drawing.Size(102, 23);
            this.wildBtn.TabIndex = 3;
            this.wildBtn.Text = "Inquiry";
            this.wildBtn.UseVisualStyleBackColor = true;
            this.wildBtn.Click += new System.EventHandler(this.wildBtn_Click);
            // 
            // wordBtn
            // 
            this.wordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.wordBtn.Location = new System.Drawing.Point(402, 31);
            this.wordBtn.Name = "wordBtn";
            this.wordBtn.Size = new System.Drawing.Size(102, 23);
            this.wordBtn.TabIndex = 1;
            this.wordBtn.Text = "Search";
            this.wordBtn.UseVisualStyleBackColor = true;
            this.wordBtn.Click += new System.EventHandler(this.wordBtn_Click);
            // 
            // wildText
            // 
            this.wildText.Location = new System.Drawing.Point(175, 72);
            this.wildText.Name = "wildText";
            this.wildText.Size = new System.Drawing.Size(221, 23);
            this.wildText.TabIndex = 2;
            // 
            // wordText
            // 
            this.wordText.Location = new System.Drawing.Point(175, 31);
            this.wordText.Name = "wordText";
            this.wordText.Size = new System.Drawing.Size(221, 23);
            this.wordText.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Wild-Card Query:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search for a specific word:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resultsText);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(659, 241);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // resultsText
            // 
            this.resultsText.BackColor = System.Drawing.Color.White;
            this.resultsText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.resultsText.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.resultsText.Location = new System.Drawing.Point(3, 22);
            this.resultsText.Multiline = true;
            this.resultsText.Name = "resultsText";
            this.resultsText.ReadOnly = true;
            this.resultsText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resultsText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultsText.Size = new System.Drawing.Size(653, 216);
            this.resultsText.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusPcName,
            this.toolStripStatusLabel2,
            this.toolStripStatusDateTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 400);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(684, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusPcName
            // 
            this.toolStripStatusPcName.Name = "toolStripStatusPcName";
            this.toolStripStatusPcName.Size = new System.Drawing.Size(57, 17);
            this.toolStripStatusPcName.Text = "PC Name";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // toolStripStatusDateTime
            // 
            this.toolStripStatusDateTime.Name = "toolStripStatusDateTime";
            this.toolStripStatusDateTime.Size = new System.Drawing.Size(34, 17);
            this.toolStripStatusDateTime.Text = "Time";
            // 
            // btnClearRes
            // 
            this.btnClearRes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearRes.Location = new System.Drawing.Point(567, 400);
            this.btnClearRes.Name = "btnClearRes";
            this.btnClearRes.Size = new System.Drawing.Size(102, 20);
            this.btnClearRes.TabIndex = 3;
            this.btnClearRes.Text = "Clear Results";
            this.btnClearRes.UseVisualStyleBackColor = true;
            this.btnClearRes.Click += new System.EventHandler(this.btnClearRes_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 422);
            this.Controls.Add(this.btnClearRes);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "B-Tree indexer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addADocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseDocumentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox wordText;
        private System.Windows.Forms.Button wordBtn;
        private System.Windows.Forms.Button wildBtn;
        private System.Windows.Forms.TextBox wildText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusPcName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusDateTime;
        private System.Windows.Forms.TextBox resultsText;
        private System.Windows.Forms.Button btnClearRes;
    }
}