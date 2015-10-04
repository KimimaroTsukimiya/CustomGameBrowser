namespace CustomGamesBrowser {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
			this.openVPKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changelogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dummyBtn = new MetroFramework.Controls.MetroRadioButton();
			this.versionLink = new MetroFramework.Controls.MetroLink();
			this.panel1 = new MetroFramework.Controls.MetroPanel();
			this.htmlToolTip1 = new MetroFramework.Drawing.Html.HtmlToolTip();
			this.refreshBtn = new System.Windows.Forms.PictureBox();
			this.totalSizeLabel1 = new MetroFramework.Controls.MetroLabel();
			this.metroContextMenu1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.refreshBtn)).BeginInit();
			this.SuspendLayout();
			// 
			// metroContextMenu1
			// 
			this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openVPKToolStripMenuItem,
            this.changelogToolStripMenuItem,
            this.deleteToolStripMenuItem});
			this.metroContextMenu1.Name = "metroContextMenu1";
			this.metroContextMenu1.Size = new System.Drawing.Size(133, 70);
			// 
			// openVPKToolStripMenuItem
			// 
			this.openVPKToolStripMenuItem.Name = "openVPKToolStripMenuItem";
			this.openVPKToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.openVPKToolStripMenuItem.Text = "Open VPK";
			this.openVPKToolStripMenuItem.ToolTipText = "Opens the VPK for this custom game\r\n(requires a VPK opener, like GCFScape).";
			this.openVPKToolStripMenuItem.Click += new System.EventHandler(this.openVPKToolStripMenuItem_Click);
			// 
			// changelogToolStripMenuItem
			// 
			this.changelogToolStripMenuItem.Name = "changelogToolStripMenuItem";
			this.changelogToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.changelogToolStripMenuItem.Text = "Changelog";
			this.changelogToolStripMenuItem.ToolTipText = "Opens the changelog for this custom game.";
			this.changelogToolStripMenuItem.Click += new System.EventHandler(this.changelogToolStripMenuItem_Click);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.ToolTipText = "Deletes this custom game from your computer.\r\nNote: This is pointless if you\'re s" +
    "till subscribed to it.";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
			// 
			// dummyBtn
			// 
			this.dummyBtn.AutoSize = true;
			this.dummyBtn.Location = new System.Drawing.Point(376, 0);
			this.dummyBtn.Name = "dummyBtn";
			this.dummyBtn.Size = new System.Drawing.Size(127, 15);
			this.dummyBtn.TabIndex = 37;
			this.dummyBtn.Text = "metroRadioButton1";
			this.dummyBtn.UseSelectable = true;
			this.dummyBtn.Visible = false;
			// 
			// versionLink
			// 
			this.versionLink.Cursor = System.Windows.Forms.Cursors.Hand;
			this.versionLink.Location = new System.Drawing.Point(272, 32);
			this.versionLink.Name = "versionLink";
			this.versionLink.Size = new System.Drawing.Size(44, 20);
			this.versionLink.TabIndex = 39;
			this.versionLink.Text = "v1.0.0";
			this.versionLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.htmlToolTip1.SetToolTip(this.versionLink, "Opens changelog on GitHub");
			this.versionLink.UseSelectable = true;
			this.versionLink.Click += new System.EventHandler(this.versionLink_Click);
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.HorizontalScrollbar = true;
			this.panel1.HorizontalScrollbarBarColor = true;
			this.panel1.HorizontalScrollbarHighlightOnWheel = false;
			this.panel1.HorizontalScrollbarSize = 10;
			this.panel1.Location = new System.Drawing.Point(4, 56);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(676, 616);
			this.panel1.TabIndex = 40;
			this.panel1.Theme = MetroFramework.MetroThemeStyle.Light;
			this.panel1.VerticalScrollbar = true;
			this.panel1.VerticalScrollbarBarColor = true;
			this.panel1.VerticalScrollbarHighlightOnWheel = true;
			this.panel1.VerticalScrollbarSize = 10;
			// 
			// htmlToolTip1
			// 
			this.htmlToolTip1.AutoPopDelay = 10000;
			this.htmlToolTip1.InitialDelay = 150;
			this.htmlToolTip1.OwnerDraw = true;
			this.htmlToolTip1.ReshowDelay = 100;
			// 
			// refreshBtn
			// 
			this.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.refreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("refreshBtn.Image")));
			this.refreshBtn.Location = new System.Drawing.Point(232, 676);
			this.refreshBtn.Name = "refreshBtn";
			this.refreshBtn.Size = new System.Drawing.Size(20, 20);
			this.refreshBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.refreshBtn.TabIndex = 42;
			this.refreshBtn.TabStop = false;
			this.htmlToolTip1.SetToolTip(this.refreshBtn, "Refresh");
			this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
			// 
			// totalSizeLabel1
			// 
			this.totalSizeLabel1.AutoSize = true;
			this.totalSizeLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.totalSizeLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.totalSizeLabel1.Location = new System.Drawing.Point(256, 672);
			this.totalSizeLabel1.Name = "totalSizeLabel1";
			this.totalSizeLabel1.Size = new System.Drawing.Size(87, 25);
			this.totalSizeLabel1.TabIndex = 43;
			this.totalSizeLabel1.Text = "Total size:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(686, 698);
			this.Controls.Add(this.totalSizeLabel1);
			this.Controls.Add(this.refreshBtn);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.versionLink);
			this.Controls.Add(this.dummyBtn);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Resizable = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Style = MetroFramework.MetroColorStyle.Red;
			this.Text = "Installed Custom Games";
			this.metroContextMenu1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.refreshBtn)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		public MetroFramework.Controls.MetroRadioButton dummyBtn;
		private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
		private System.Windows.Forms.ToolStripMenuItem openVPKToolStripMenuItem;
		private MetroFramework.Controls.MetroLink versionLink;
		private MetroFramework.Controls.MetroPanel panel1;
		public MetroFramework.Drawing.Html.HtmlToolTip htmlToolTip1;
		private System.Windows.Forms.PictureBox refreshBtn;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changelogToolStripMenuItem;
		public MetroFramework.Controls.MetroLabel totalSizeLabel1;
	}
}

