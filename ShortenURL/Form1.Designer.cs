namespace ShortenURL
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonShorten = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemServiceList = new System.Windows.Forms.ToolStripMenuItem();
            this.itemIsgd = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSupr = new System.Windows.Forms.ToolStripMenuItem();
            this.itemTinyURL = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemTrim = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // textURL
            // 
            this.textURL.Location = new System.Drawing.Point(3, 16);
            this.textURL.Multiline = true;
            this.textURL.Name = "textURL";
            this.textURL.Size = new System.Drawing.Size(399, 111);
            this.textURL.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL to Shorten";
            // 
            // buttonShorten
            // 
            this.buttonShorten.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonShorten.Location = new System.Drawing.Point(0, 132);
            this.buttonShorten.Name = "buttonShorten";
            this.buttonShorten.Size = new System.Drawing.Size(404, 23);
            this.buttonShorten.TabIndex = 2;
            this.buttonShorten.Text = "Shorten";
            this.buttonShorten.UseVisualStyleBackColor = true;
            this.buttonShorten.Click += new System.EventHandler(this.buttonShorten_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuMain;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "ShortenURL";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuMain
            // 
            this.contextMenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemServiceList,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.contextMenuMain.Name = "contextMenuMain";
            this.contextMenuMain.Size = new System.Drawing.Size(153, 76);
            // 
            // itemServiceList
            // 
            this.itemServiceList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemIsgd,
            this.itemSupr,
            this.itemTinyURL,
            this.itemTrim});
            this.itemServiceList.Name = "itemServiceList";
            this.itemServiceList.Size = new System.Drawing.Size(152, 22);
            this.itemServiceList.Text = "Services";
            // 
            // itemIsgd
            // 
            this.itemIsgd.Checked = true;
            this.itemIsgd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.itemIsgd.Name = "itemIsgd";
            this.itemIsgd.Size = new System.Drawing.Size(152, 22);
            this.itemIsgd.Text = "Is.gd";
            this.itemIsgd.Click += new System.EventHandler(this.itemIsgd_Click);
            // 
            // itemSupr
            // 
            this.itemSupr.Name = "itemSupr";
            this.itemSupr.Size = new System.Drawing.Size(152, 22);
            this.itemSupr.Text = "Su.pr";
            this.itemSupr.Click += new System.EventHandler(this.itemSupr_Click);
            // 
            // itemTinyURL
            // 
            this.itemTinyURL.Name = "itemTinyURL";
            this.itemTinyURL.Size = new System.Drawing.Size(152, 22);
            this.itemTinyURL.Text = "TinyURL";
            this.itemTinyURL.Click += new System.EventHandler(this.itemTinyURL_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // itemTrim
            // 
            this.itemTrim.Name = "itemTrim";
            this.itemTrim.Size = new System.Drawing.Size(152, 22);
            this.itemTrim.Text = "tr.im";
            this.itemTrim.Click += new System.EventHandler(this.itemTrim_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonShorten;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 155);
            this.Controls.Add(this.buttonShorten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textURL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ShortenURL";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonShorten;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuMain;
        private System.Windows.Forms.ToolStripMenuItem itemServiceList;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemIsgd;
        private System.Windows.Forms.ToolStripMenuItem itemTinyURL;
        private System.Windows.Forms.ToolStripMenuItem itemSupr;
        private System.Windows.Forms.ToolStripMenuItem itemTrim;
    }
}

