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
			this.dummyBtn = new MetroFramework.Controls.MetroRadioButton();
			this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
			this.versionLink = new MetroFramework.Controls.MetroLink();
			this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
			this.metroContextMenu1.SuspendLayout();
			this.SuspendLayout();
			// 
			// metroContextMenu1
			// 
			this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openVPKToolStripMenuItem});
			this.metroContextMenu1.Name = "metroContextMenu1";
			this.metroContextMenu1.Size = new System.Drawing.Size(128, 26);
			// 
			// openVPKToolStripMenuItem
			// 
			this.openVPKToolStripMenuItem.Name = "openVPKToolStripMenuItem";
			this.openVPKToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
			this.openVPKToolStripMenuItem.Text = "Open VPK";
			this.openVPKToolStripMenuItem.ToolTipText = "Opens the VPK for this custom game\r\n(requires a VPK opener, like GCFScape).";
			this.openVPKToolStripMenuItem.Click += new System.EventHandler(this.openVPKToolStripMenuItem_Click);
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
			// metroToolTip1
			// 
			this.metroToolTip1.AutoPopDelay = 5000;
			this.metroToolTip1.InitialDelay = 200;
			this.metroToolTip1.ReshowDelay = 100;
			this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroToolTip1.StyleManager = null;
			this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Default;
			// 
			// versionLink
			// 
			this.versionLink.Cursor = System.Windows.Forms.Cursors.Hand;
			this.versionLink.Location = new System.Drawing.Point(276, 30);
			this.versionLink.Name = "versionLink";
			this.versionLink.Size = new System.Drawing.Size(75, 23);
			this.versionLink.TabIndex = 39;
			this.versionLink.Text = "metroLink1";
			this.versionLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.versionLink.UseSelectable = true;
			this.versionLink.Click += new System.EventHandler(this.versionLink_Click);
			// 
			// metroPanel1
			// 
			this.metroPanel1.AutoScroll = true;
			this.metroPanel1.HorizontalScrollbar = true;
			this.metroPanel1.HorizontalScrollbarBarColor = true;
			this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
			this.metroPanel1.HorizontalScrollbarSize = 10;
			this.metroPanel1.Location = new System.Drawing.Point(8, 52);
			this.metroPanel1.Name = "metroPanel1";
			this.metroPanel1.Size = new System.Drawing.Size(676, 620);
			this.metroPanel1.TabIndex = 40;
			this.metroPanel1.VerticalScrollbar = true;
			this.metroPanel1.VerticalScrollbarBarColor = true;
			this.metroPanel1.VerticalScrollbarHighlightOnWheel = true;
			this.metroPanel1.VerticalScrollbarSize = 10;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(691, 686);
			this.Controls.Add(this.metroPanel1);
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
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		public MetroFramework.Controls.MetroRadioButton dummyBtn;
		private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
		private System.Windows.Forms.ToolStripMenuItem openVPKToolStripMenuItem;
		private MetroFramework.Controls.MetroLink versionLink;
		public MetroFramework.Components.MetroToolTip metroToolTip1;
		private MetroFramework.Controls.MetroPanel metroPanel1;
	}
}

