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
			this.mt1 = new MetroFramework.Controls.MetroTile();
			this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
			this.openVPKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ps1 = new MetroFramework.Controls.MetroProgressSpinner();
			this.mt2 = new MetroFramework.Controls.MetroTile();
			this.ps2 = new MetroFramework.Controls.MetroProgressSpinner();
			this.mt3 = new MetroFramework.Controls.MetroTile();
			this.ps3 = new MetroFramework.Controls.MetroProgressSpinner();
			this.mt4 = new MetroFramework.Controls.MetroTile();
			this.ps4 = new MetroFramework.Controls.MetroProgressSpinner();
			this.mt5 = new MetroFramework.Controls.MetroTile();
			this.ps5 = new MetroFramework.Controls.MetroProgressSpinner();
			this.mt10 = new MetroFramework.Controls.MetroTile();
			this.ps10 = new MetroFramework.Controls.MetroProgressSpinner();
			this.mt9 = new MetroFramework.Controls.MetroTile();
			this.ps9 = new MetroFramework.Controls.MetroProgressSpinner();
			this.mt8 = new MetroFramework.Controls.MetroTile();
			this.ps8 = new MetroFramework.Controls.MetroProgressSpinner();
			this.mt7 = new MetroFramework.Controls.MetroTile();
			this.ps7 = new MetroFramework.Controls.MetroProgressSpinner();
			this.mt6 = new MetroFramework.Controls.MetroTile();
			this.ps6 = new MetroFramework.Controls.MetroProgressSpinner();
			this.mt15 = new MetroFramework.Controls.MetroTile();
			this.ps15 = new MetroFramework.Controls.MetroProgressSpinner();
			this.mt14 = new MetroFramework.Controls.MetroTile();
			this.ps14 = new MetroFramework.Controls.MetroProgressSpinner();
			this.mt13 = new MetroFramework.Controls.MetroTile();
			this.ps13 = new MetroFramework.Controls.MetroProgressSpinner();
			this.mt12 = new MetroFramework.Controls.MetroTile();
			this.ps12 = new MetroFramework.Controls.MetroProgressSpinner();
			this.mt11 = new MetroFramework.Controls.MetroTile();
			this.ps11 = new MetroFramework.Controls.MetroProgressSpinner();
			this.mt20 = new MetroFramework.Controls.MetroTile();
			this.ps20 = new MetroFramework.Controls.MetroProgressSpinner();
			this.mt19 = new MetroFramework.Controls.MetroTile();
			this.ps19 = new MetroFramework.Controls.MetroProgressSpinner();
			this.mt18 = new MetroFramework.Controls.MetroTile();
			this.ps18 = new MetroFramework.Controls.MetroProgressSpinner();
			this.mt17 = new MetroFramework.Controls.MetroTile();
			this.ps17 = new MetroFramework.Controls.MetroProgressSpinner();
			this.mt16 = new MetroFramework.Controls.MetroTile();
			this.ps16 = new MetroFramework.Controls.MetroProgressSpinner();
			this.nextBtn = new MetroFramework.Controls.MetroButton();
			this.backBtn = new MetroFramework.Controls.MetroButton();
			this.dummyBtn = new MetroFramework.Controls.MetroRadioButton();
			this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
			this.versionLink = new MetroFramework.Controls.MetroLink();
			this.mt1.SuspendLayout();
			this.metroContextMenu1.SuspendLayout();
			this.mt2.SuspendLayout();
			this.mt3.SuspendLayout();
			this.mt4.SuspendLayout();
			this.mt5.SuspendLayout();
			this.mt10.SuspendLayout();
			this.mt9.SuspendLayout();
			this.mt8.SuspendLayout();
			this.mt7.SuspendLayout();
			this.mt6.SuspendLayout();
			this.mt15.SuspendLayout();
			this.mt14.SuspendLayout();
			this.mt13.SuspendLayout();
			this.mt12.SuspendLayout();
			this.mt11.SuspendLayout();
			this.mt20.SuspendLayout();
			this.mt19.SuspendLayout();
			this.mt18.SuspendLayout();
			this.mt17.SuspendLayout();
			this.mt16.SuspendLayout();
			this.SuspendLayout();
			// 
			// mt1
			// 
			this.mt1.ActiveControl = null;
			this.mt1.ContextMenuStrip = this.metroContextMenu1;
			this.mt1.Controls.Add(this.ps1);
			this.mt1.Location = new System.Drawing.Point(16, 60);
			this.mt1.Name = "mt1";
			this.mt1.Size = new System.Drawing.Size(128, 116);
			this.mt1.Style = MetroFramework.MetroColorStyle.Blue;
			this.mt1.TabIndex = 3;
			this.mt1.Text = "mt1";
			this.mt1.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.mt1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroToolTip1.SetToolTip(this.mt1, "Left-click to open the Steam Workshop page for this\r\ncustom game. Right-click for" +
        " more options.");
			this.mt1.UseSelectable = true;
			this.mt1.Visible = false;
			this.mt1.Click += new System.EventHandler(this.onTileClick);
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
			// ps1
			// 
			this.ps1.Location = new System.Drawing.Point(40, 40);
			this.ps1.Maximum = 100;
			this.ps1.Name = "ps1";
			this.ps1.Size = new System.Drawing.Size(40, 40);
			this.ps1.TabIndex = 37;
			this.metroToolTip1.SetToolTip(this.ps1, "Left-click to open the Steam Workshop page for this\r\ncustom game. Right-click for" +
        " more options.");
			this.ps1.UseSelectable = true;
			this.ps1.Value = 80;
			this.ps1.Visible = false;
			// 
			// mt2
			// 
			this.mt2.ActiveControl = null;
			this.mt2.ContextMenuStrip = this.metroContextMenu1;
			this.mt2.Controls.Add(this.ps2);
			this.mt2.Location = new System.Drawing.Point(148, 60);
			this.mt2.Name = "mt2";
			this.mt2.Size = new System.Drawing.Size(128, 116);
			this.mt2.Style = MetroFramework.MetroColorStyle.Yellow;
			this.mt2.TabIndex = 4;
			this.mt2.Text = "mt2";
			this.mt2.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.mt2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroToolTip1.SetToolTip(this.mt2, "Left-click to open the Steam Workshop page for this\r\ncustom game. Right-click for" +
        " more options.");
			this.mt2.UseSelectable = true;
			this.mt2.Visible = false;
			this.mt2.Click += new System.EventHandler(this.onTileClick);
			// 
			// ps2
			// 
			this.ps2.Location = new System.Drawing.Point(44, 38);
			this.ps2.Maximum = 100;
			this.ps2.Name = "ps2";
			this.ps2.Size = new System.Drawing.Size(40, 40);
			this.ps2.Style = MetroFramework.MetroColorStyle.Yellow;
			this.ps2.TabIndex = 38;
			this.metroToolTip1.SetToolTip(this.ps2, "Left-click to open the Steam Workshop page for this\r\ncustom game. Right-click for" +
        " more options.");
			this.ps2.UseSelectable = true;
			this.ps2.Value = 80;
			this.ps2.Visible = false;
			// 
			// mt3
			// 
			this.mt3.ActiveControl = null;
			this.mt3.ContextMenuStrip = this.metroContextMenu1;
			this.mt3.Controls.Add(this.ps3);
			this.mt3.Location = new System.Drawing.Point(280, 60);
			this.mt3.Name = "mt3";
			this.mt3.Size = new System.Drawing.Size(128, 116);
			this.mt3.Style = MetroFramework.MetroColorStyle.Red;
			this.mt3.TabIndex = 5;
			this.mt3.Text = "mt3";
			this.mt3.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.mt3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroToolTip1.SetToolTip(this.mt3, "Left-click to open the Steam Workshop page for this\r\ncustom game. Right-click for" +
        " more options.");
			this.mt3.UseSelectable = true;
			this.mt3.Visible = false;
			this.mt3.Click += new System.EventHandler(this.onTileClick);
			// 
			// ps3
			// 
			this.ps3.Location = new System.Drawing.Point(44, 38);
			this.ps3.Maximum = 100;
			this.ps3.Name = "ps3";
			this.ps3.Size = new System.Drawing.Size(40, 40);
			this.ps3.Style = MetroFramework.MetroColorStyle.Red;
			this.ps3.TabIndex = 38;
			this.metroToolTip1.SetToolTip(this.ps3, "Left-click to open the Steam Workshop page for this\r\ncustom game. Right-click for" +
        " more options.");
			this.ps3.UseSelectable = true;
			this.ps3.Value = 80;
			this.ps3.Visible = false;
			// 
			// mt4
			// 
			this.mt4.ActiveControl = null;
			this.mt4.ContextMenuStrip = this.metroContextMenu1;
			this.mt4.Controls.Add(this.ps4);
			this.mt4.Location = new System.Drawing.Point(412, 60);
			this.mt4.Name = "mt4";
			this.mt4.Size = new System.Drawing.Size(128, 116);
			this.mt4.Style = MetroFramework.MetroColorStyle.Purple;
			this.mt4.TabIndex = 6;
			this.mt4.Text = "mt4";
			this.mt4.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.mt4.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroToolTip1.SetToolTip(this.mt4, "Left-click to open the Steam Workshop page for this\r\ncustom game. Right-click for" +
        " more options.");
			this.mt4.UseSelectable = true;
			this.mt4.Visible = false;
			this.mt4.Click += new System.EventHandler(this.onTileClick);
			// 
			// ps4
			// 
			this.ps4.Location = new System.Drawing.Point(44, 38);
			this.ps4.Maximum = 100;
			this.ps4.Name = "ps4";
			this.ps4.Size = new System.Drawing.Size(40, 40);
			this.ps4.Style = MetroFramework.MetroColorStyle.Purple;
			this.ps4.TabIndex = 38;
			this.metroToolTip1.SetToolTip(this.ps4, "Left-click to open the Steam Workshop page for this\r\ncustom game. Right-click for" +
        " more options.");
			this.ps4.UseSelectable = true;
			this.ps4.Value = 80;
			this.ps4.Visible = false;
			// 
			// mt5
			// 
			this.mt5.ActiveControl = null;
			this.mt5.ContextMenuStrip = this.metroContextMenu1;
			this.mt5.Controls.Add(this.ps5);
			this.mt5.Location = new System.Drawing.Point(544, 60);
			this.mt5.Name = "mt5";
			this.mt5.Size = new System.Drawing.Size(128, 116);
			this.mt5.Style = MetroFramework.MetroColorStyle.Magenta;
			this.mt5.TabIndex = 19;
			this.mt5.Text = "mt5";
			this.mt5.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.mt5.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroToolTip1.SetToolTip(this.mt5, "Left-click to open the Steam Workshop page for this\r\ncustom game. Right-click for" +
        " more options.");
			this.mt5.UseSelectable = true;
			this.mt5.Visible = false;
			this.mt5.Click += new System.EventHandler(this.onTileClick);
			// 
			// ps5
			// 
			this.ps5.Location = new System.Drawing.Point(44, 38);
			this.ps5.Maximum = 100;
			this.ps5.Name = "ps5";
			this.ps5.Size = new System.Drawing.Size(40, 40);
			this.ps5.Style = MetroFramework.MetroColorStyle.Magenta;
			this.ps5.TabIndex = 38;
			this.metroToolTip1.SetToolTip(this.ps5, "Left-click to open the Steam Workshop page for this\r\ncustom game. Right-click for" +
        " more options.");
			this.ps5.UseSelectable = true;
			this.ps5.Value = 80;
			this.ps5.Visible = false;
			// 
			// mt10
			// 
			this.mt10.ActiveControl = null;
			this.mt10.ContextMenuStrip = this.metroContextMenu1;
			this.mt10.Controls.Add(this.ps10);
			this.mt10.Location = new System.Drawing.Point(544, 180);
			this.mt10.Name = "mt10";
			this.mt10.Size = new System.Drawing.Size(128, 116);
			this.mt10.Style = MetroFramework.MetroColorStyle.Lime;
			this.mt10.TabIndex = 24;
			this.mt10.Text = "metroTile1";
			this.mt10.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.mt10.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroToolTip1.SetToolTip(this.mt10, "Left-click to open the Steam Workshop page for this\r\ncustom game. Right-click for" +
        " more options.");
			this.mt10.UseSelectable = true;
			this.mt10.Visible = false;
			this.mt10.Click += new System.EventHandler(this.onTileClick);
			// 
			// ps10
			// 
			this.ps10.Location = new System.Drawing.Point(44, 38);
			this.ps10.Maximum = 100;
			this.ps10.Name = "ps10";
			this.ps10.Size = new System.Drawing.Size(40, 40);
			this.ps10.Style = MetroFramework.MetroColorStyle.Lime;
			this.ps10.TabIndex = 38;
			this.metroToolTip1.SetToolTip(this.ps10, "Left-click to open the Steam Workshop page for this\r\ncustom game. Right-click for" +
        " more options.");
			this.ps10.UseSelectable = true;
			this.ps10.Value = 80;
			this.ps10.Visible = false;
			// 
			// mt9
			// 
			this.mt9.ActiveControl = null;
			this.mt9.ContextMenuStrip = this.metroContextMenu1;
			this.mt9.Controls.Add(this.ps9);
			this.mt9.Location = new System.Drawing.Point(412, 180);
			this.mt9.Name = "mt9";
			this.mt9.Size = new System.Drawing.Size(128, 116);
			this.mt9.Style = MetroFramework.MetroColorStyle.Teal;
			this.mt9.TabIndex = 23;
			this.mt9.Text = "metroTile2";
			this.mt9.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.mt9.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroToolTip1.SetToolTip(this.mt9, "Left-click to open the Steam Workshop page for this\r\ncustom game. Right-click for" +
        " more options.");
			this.mt9.UseSelectable = true;
			this.mt9.Visible = false;
			this.mt9.Click += new System.EventHandler(this.onTileClick);
			// 
			// ps9
			// 
			this.ps9.Location = new System.Drawing.Point(44, 38);
			this.ps9.Maximum = 100;
			this.ps9.Name = "ps9";
			this.ps9.Size = new System.Drawing.Size(40, 40);
			this.ps9.Style = MetroFramework.MetroColorStyle.Teal;
			this.ps9.TabIndex = 38;
			this.metroToolTip1.SetToolTip(this.ps9, "Left-click to open the Steam Workshop page for this\r\ncustom game. Right-click for" +
        " more options.");
			this.ps9.UseSelectable = true;
			this.ps9.Value = 80;
			this.ps9.Visible = false;
			// 
			// mt8
			// 
			this.mt8.ActiveControl = null;
			this.mt8.ContextMenuStrip = this.metroContextMenu1;
			this.mt8.Controls.Add(this.ps8);
			this.mt8.Location = new System.Drawing.Point(280, 180);
			this.mt8.Name = "mt8";
			this.mt8.Size = new System.Drawing.Size(128, 116);
			this.mt8.Style = MetroFramework.MetroColorStyle.Orange;
			this.mt8.TabIndex = 22;
			this.mt8.Text = "metroTile3";
			this.mt8.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.mt8.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroToolTip1.SetToolTip(this.mt8, "Left-click to open the Steam Workshop page for this\r\ncustom game. Right-click for" +
        " more options.");
			this.mt8.UseSelectable = true;
			this.mt8.Visible = false;
			this.mt8.Click += new System.EventHandler(this.onTileClick);
			// 
			// ps8
			// 
			this.ps8.Location = new System.Drawing.Point(44, 38);
			this.ps8.Maximum = 100;
			this.ps8.Name = "ps8";
			this.ps8.Size = new System.Drawing.Size(40, 40);
			this.ps8.Style = MetroFramework.MetroColorStyle.Orange;
			this.ps8.TabIndex = 38;
			this.metroToolTip1.SetToolTip(this.ps8, "Left-click to open the Steam Workshop page for this\r\ncustom game. Right-click for" +
        " more options.");
			this.ps8.UseSelectable = true;
			this.ps8.Value = 80;
			this.ps8.Visible = false;
			// 
			// mt7
			// 
			this.mt7.ActiveControl = null;
			this.mt7.ContextMenuStrip = this.metroContextMenu1;
			this.mt7.Controls.Add(this.ps7);
			this.mt7.Location = new System.Drawing.Point(148, 180);
			this.mt7.Name = "mt7";
			this.mt7.Size = new System.Drawing.Size(128, 116);
			this.mt7.Style = MetroFramework.MetroColorStyle.Brown;
			this.mt7.TabIndex = 21;
			this.mt7.Text = "metroTile4";
			this.mt7.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.mt7.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroToolTip1.SetToolTip(this.mt7, "Left-click to open the Steam Workshop page for this\r\ncustom game. Right-click for" +
        " more options.");
			this.mt7.UseSelectable = true;
			this.mt7.Visible = false;
			this.mt7.Click += new System.EventHandler(this.onTileClick);
			// 
			// ps7
			// 
			this.ps7.Location = new System.Drawing.Point(44, 38);
			this.ps7.Maximum = 100;
			this.ps7.Name = "ps7";
			this.ps7.Size = new System.Drawing.Size(40, 40);
			this.ps7.Style = MetroFramework.MetroColorStyle.Brown;
			this.ps7.TabIndex = 38;
			this.metroToolTip1.SetToolTip(this.ps7, "Left-click to open the Steam Workshop page for this\r\ncustom game. Right-click for" +
        " more options.");
			this.ps7.UseSelectable = true;
			this.ps7.Value = 80;
			this.ps7.Visible = false;
			// 
			// mt6
			// 
			this.mt6.ActiveControl = null;
			this.mt6.ContextMenuStrip = this.metroContextMenu1;
			this.mt6.Controls.Add(this.ps6);
			this.mt6.Location = new System.Drawing.Point(16, 180);
			this.mt6.Name = "mt6";
			this.mt6.Size = new System.Drawing.Size(128, 116);
			this.mt6.Style = MetroFramework.MetroColorStyle.Pink;
			this.mt6.TabIndex = 20;
			this.mt6.Text = "mt6";
			this.mt6.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.mt6.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroToolTip1.SetToolTip(this.mt6, "Left-click to open the Steam Workshop page for this\r\ncustom game. Right-click for" +
        " more options.");
			this.mt6.UseSelectable = true;
			this.mt6.Visible = false;
			this.mt6.Click += new System.EventHandler(this.onTileClick);
			// 
			// ps6
			// 
			this.ps6.Location = new System.Drawing.Point(44, 38);
			this.ps6.Maximum = 100;
			this.ps6.Name = "ps6";
			this.ps6.Size = new System.Drawing.Size(40, 40);
			this.ps6.Style = MetroFramework.MetroColorStyle.Pink;
			this.ps6.TabIndex = 38;
			this.metroToolTip1.SetToolTip(this.ps6, "Left-click to open the Steam Workshop page for this\r\ncustom game. Right-click for" +
        " more options.");
			this.ps6.UseSelectable = true;
			this.ps6.Value = 80;
			this.ps6.Visible = false;
			// 
			// mt15
			// 
			this.mt15.ActiveControl = null;
			this.mt15.ContextMenuStrip = this.metroContextMenu1;
			this.mt15.Controls.Add(this.ps15);
			this.mt15.Location = new System.Drawing.Point(544, 300);
			this.mt15.Name = "mt15";
			this.mt15.Size = new System.Drawing.Size(128, 116);
			this.mt15.Style = MetroFramework.MetroColorStyle.Red;
			this.mt15.TabIndex = 29;
			this.mt15.Text = "metroTile1";
			this.mt15.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.mt15.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroToolTip1.SetToolTip(this.mt15, "Left-click to open the Steam Workshop page for this\r\ncustom game. Right-click for" +
        " more options.");
			this.mt15.UseSelectable = true;
			this.mt15.Visible = false;
			this.mt15.Click += new System.EventHandler(this.onTileClick);
			// 
			// ps15
			// 
			this.ps15.Location = new System.Drawing.Point(44, 38);
			this.ps15.Maximum = 100;
			this.ps15.Name = "ps15";
			this.ps15.Size = new System.Drawing.Size(40, 40);
			this.ps15.Style = MetroFramework.MetroColorStyle.Red;
			this.ps15.TabIndex = 38;
			this.metroToolTip1.SetToolTip(this.ps15, "Left-click to open the Steam Workshop page for this\r\ncustom game. Right-click for" +
        " more options.");
			this.ps15.UseSelectable = true;
			this.ps15.Value = 80;
			this.ps15.Visible = false;
			// 
			// mt14
			// 
			this.mt14.ActiveControl = null;
			this.mt14.ContextMenuStrip = this.metroContextMenu1;
			this.mt14.Controls.Add(this.ps14);
			this.mt14.Location = new System.Drawing.Point(412, 300);
			this.mt14.Name = "mt14";
			this.mt14.Size = new System.Drawing.Size(128, 116);
			this.mt14.Style = MetroFramework.MetroColorStyle.Yellow;
			this.mt14.TabIndex = 28;
			this.mt14.Text = "metroTile2";
			this.mt14.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.mt14.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroToolTip1.SetToolTip(this.mt14, "Left-click to open the Steam Workshop page for this\r\ncustom game. Right-click for" +
        " more options.");
			this.mt14.UseSelectable = true;
			this.mt14.Visible = false;
			this.mt14.Click += new System.EventHandler(this.onTileClick);
			// 
			// ps14
			// 
			this.ps14.Location = new System.Drawing.Point(44, 38);
			this.ps14.Maximum = 100;
			this.ps14.Name = "ps14";
			this.ps14.Size = new System.Drawing.Size(40, 40);
			this.ps14.Style = MetroFramework.MetroColorStyle.Yellow;
			this.ps14.TabIndex = 38;
			this.metroToolTip1.SetToolTip(this.ps14, "Left-click to open the Steam Workshop page for this\r\ncustom game. Right-click for" +
        " more options.");
			this.ps14.UseSelectable = true;
			this.ps14.Value = 80;
			this.ps14.Visible = false;
			// 
			// mt13
			// 
			this.mt13.ActiveControl = null;
			this.mt13.ContextMenuStrip = this.metroContextMenu1;
			this.mt13.Controls.Add(this.ps13);
			this.mt13.Location = new System.Drawing.Point(280, 300);
			this.mt13.Name = "mt13";
			this.mt13.Size = new System.Drawing.Size(128, 116);
			this.mt13.Style = MetroFramework.MetroColorStyle.Black;
			this.mt13.TabIndex = 27;
			this.mt13.Text = "metroTile3";
			this.mt13.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.mt13.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroToolTip1.SetToolTip(this.mt13, "Left-click to open the Steam Workshop page for this\r\ncustom game. Right-click for" +
        " more options.");
			this.mt13.UseSelectable = true;
			this.mt13.Visible = false;
			this.mt13.Click += new System.EventHandler(this.onTileClick);
			// 
			// ps13
			// 
			this.ps13.Location = new System.Drawing.Point(44, 38);
			this.ps13.Maximum = 100;
			this.ps13.Name = "ps13";
			this.ps13.Size = new System.Drawing.Size(40, 40);
			this.ps13.Style = MetroFramework.MetroColorStyle.Black;
			this.ps13.TabIndex = 38;
			this.metroToolTip1.SetToolTip(this.ps13, "Left-click to open the Steam Workshop page for this\r\ncustom game. Right-click for" +
        " more options.");
			this.ps13.UseSelectable = true;
			this.ps13.Value = 80;
			this.ps13.Visible = false;
			// 
			// mt12
			// 
			this.mt12.ActiveControl = null;
			this.mt12.ContextMenuStrip = this.metroContextMenu1;
			this.mt12.Controls.Add(this.ps12);
			this.mt12.Location = new System.Drawing.Point(148, 300);
			this.mt12.Name = "mt12";
			this.mt12.Size = new System.Drawing.Size(128, 116);
			this.mt12.Style = MetroFramework.MetroColorStyle.Blue;
			this.mt12.TabIndex = 26;
			this.mt12.Text = "metroTile4";
			this.mt12.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.mt12.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroToolTip1.SetToolTip(this.mt12, "Left-click to open the Steam Workshop page for this\r\ncustom game. Right-click for" +
        " more options.");
			this.mt12.UseSelectable = true;
			this.mt12.Visible = false;
			this.mt12.Click += new System.EventHandler(this.onTileClick);
			// 
			// ps12
			// 
			this.ps12.Location = new System.Drawing.Point(44, 38);
			this.ps12.Maximum = 100;
			this.ps12.Name = "ps12";
			this.ps12.Size = new System.Drawing.Size(40, 40);
			this.ps12.Style = MetroFramework.MetroColorStyle.Blue;
			this.ps12.TabIndex = 38;
			this.metroToolTip1.SetToolTip(this.ps12, "Left-click to open the Steam Workshop page for this\r\ncustom game. Right-click for" +
        " more options.");
			this.ps12.UseSelectable = true;
			this.ps12.Value = 80;
			this.ps12.Visible = false;
			// 
			// mt11
			// 
			this.mt11.ActiveControl = null;
			this.mt11.ContextMenuStrip = this.metroContextMenu1;
			this.mt11.Controls.Add(this.ps11);
			this.mt11.Location = new System.Drawing.Point(16, 300);
			this.mt11.Name = "mt11";
			this.mt11.Size = new System.Drawing.Size(128, 116);
			this.mt11.Style = MetroFramework.MetroColorStyle.Silver;
			this.mt11.TabIndex = 25;
			this.mt11.Text = "metroTile5";
			this.mt11.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.mt11.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroToolTip1.SetToolTip(this.mt11, "Left-click to open the Steam Workshop page for this\r\ncustom game. Right-click for" +
        " more options.");
			this.mt11.UseSelectable = true;
			this.mt11.Visible = false;
			this.mt11.Click += new System.EventHandler(this.onTileClick);
			// 
			// ps11
			// 
			this.ps11.Location = new System.Drawing.Point(44, 38);
			this.ps11.Maximum = 100;
			this.ps11.Name = "ps11";
			this.ps11.Size = new System.Drawing.Size(40, 40);
			this.ps11.Style = MetroFramework.MetroColorStyle.Silver;
			this.ps11.TabIndex = 38;
			this.metroToolTip1.SetToolTip(this.ps11, "Left-click to open the Steam Workshop page for this\r\ncustom game. Right-click for" +
        " more options.");
			this.ps11.UseSelectable = true;
			this.ps11.Value = 80;
			this.ps11.Visible = false;
			// 
			// mt20
			// 
			this.mt20.ActiveControl = null;
			this.mt20.ContextMenuStrip = this.metroContextMenu1;
			this.mt20.Controls.Add(this.ps20);
			this.mt20.Location = new System.Drawing.Point(544, 420);
			this.mt20.Name = "mt20";
			this.mt20.Size = new System.Drawing.Size(128, 116);
			this.mt20.Style = MetroFramework.MetroColorStyle.Pink;
			this.mt20.TabIndex = 34;
			this.mt20.Text = "metroTile1";
			this.mt20.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.mt20.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroToolTip1.SetToolTip(this.mt20, "Left-click to open the Steam Workshop page for this\r\ncustom game. Right-click for" +
        " more options.");
			this.mt20.UseSelectable = true;
			this.mt20.Visible = false;
			this.mt20.Click += new System.EventHandler(this.onTileClick);
			// 
			// ps20
			// 
			this.ps20.Location = new System.Drawing.Point(44, 38);
			this.ps20.Maximum = 100;
			this.ps20.Name = "ps20";
			this.ps20.Size = new System.Drawing.Size(40, 40);
			this.ps20.Style = MetroFramework.MetroColorStyle.Pink;
			this.ps20.TabIndex = 38;
			this.metroToolTip1.SetToolTip(this.ps20, "Left-click to open the Steam Workshop page for this\r\ncustom game. Right-click for" +
        " more options.");
			this.ps20.UseSelectable = true;
			this.ps20.Value = 80;
			this.ps20.Visible = false;
			// 
			// mt19
			// 
			this.mt19.ActiveControl = null;
			this.mt19.ContextMenuStrip = this.metroContextMenu1;
			this.mt19.Controls.Add(this.ps19);
			this.mt19.Location = new System.Drawing.Point(412, 420);
			this.mt19.Name = "mt19";
			this.mt19.Size = new System.Drawing.Size(128, 116);
			this.mt19.Style = MetroFramework.MetroColorStyle.Lime;
			this.mt19.TabIndex = 33;
			this.mt19.Text = "metroTile2";
			this.mt19.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.mt19.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroToolTip1.SetToolTip(this.mt19, "Left-click to open the Steam Workshop page for this\r\ncustom game. Right-click for" +
        " more options.");
			this.mt19.UseSelectable = true;
			this.mt19.Visible = false;
			this.mt19.Click += new System.EventHandler(this.onTileClick);
			// 
			// ps19
			// 
			this.ps19.Location = new System.Drawing.Point(44, 38);
			this.ps19.Maximum = 100;
			this.ps19.Name = "ps19";
			this.ps19.Size = new System.Drawing.Size(40, 40);
			this.ps19.Style = MetroFramework.MetroColorStyle.Lime;
			this.ps19.TabIndex = 38;
			this.metroToolTip1.SetToolTip(this.ps19, "Left-click to open the Steam Workshop page for this\r\ncustom game. Right-click for" +
        " more options.");
			this.ps19.UseSelectable = true;
			this.ps19.Value = 80;
			this.ps19.Visible = false;
			// 
			// mt18
			// 
			this.mt18.ActiveControl = null;
			this.mt18.ContextMenuStrip = this.metroContextMenu1;
			this.mt18.Controls.Add(this.ps18);
			this.mt18.Location = new System.Drawing.Point(280, 420);
			this.mt18.Name = "mt18";
			this.mt18.Size = new System.Drawing.Size(128, 116);
			this.mt18.Style = MetroFramework.MetroColorStyle.Brown;
			this.mt18.TabIndex = 32;
			this.mt18.Text = "metroTile3";
			this.mt18.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.mt18.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroToolTip1.SetToolTip(this.mt18, "Left-click to open the Steam Workshop page for this\r\ncustom game. Right-click for" +
        " more options.");
			this.mt18.UseSelectable = true;
			this.mt18.Visible = false;
			this.mt18.Click += new System.EventHandler(this.onTileClick);
			// 
			// ps18
			// 
			this.ps18.Location = new System.Drawing.Point(44, 38);
			this.ps18.Maximum = 100;
			this.ps18.Name = "ps18";
			this.ps18.Size = new System.Drawing.Size(40, 40);
			this.ps18.Style = MetroFramework.MetroColorStyle.Brown;
			this.ps18.TabIndex = 38;
			this.metroToolTip1.SetToolTip(this.ps18, "Left-click to open the Steam Workshop page for this\r\ncustom game. Right-click for" +
        " more options.");
			this.ps18.UseSelectable = true;
			this.ps18.Value = 80;
			this.ps18.Visible = false;
			// 
			// mt17
			// 
			this.mt17.ActiveControl = null;
			this.mt17.ContextMenuStrip = this.metroContextMenu1;
			this.mt17.Controls.Add(this.ps17);
			this.mt17.Location = new System.Drawing.Point(148, 420);
			this.mt17.Name = "mt17";
			this.mt17.Size = new System.Drawing.Size(128, 116);
			this.mt17.Style = MetroFramework.MetroColorStyle.Green;
			this.mt17.TabIndex = 31;
			this.mt17.Text = "metroTile4";
			this.mt17.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.mt17.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroToolTip1.SetToolTip(this.mt17, "Left-click to open the Steam Workshop page for this\r\ncustom game. Right-click for" +
        " more options.");
			this.mt17.UseSelectable = true;
			this.mt17.Visible = false;
			this.mt17.Click += new System.EventHandler(this.onTileClick);
			// 
			// ps17
			// 
			this.ps17.Location = new System.Drawing.Point(44, 38);
			this.ps17.Maximum = 100;
			this.ps17.Name = "ps17";
			this.ps17.Size = new System.Drawing.Size(40, 40);
			this.ps17.Style = MetroFramework.MetroColorStyle.Green;
			this.ps17.TabIndex = 38;
			this.metroToolTip1.SetToolTip(this.ps17, "Left-click to open the Steam Workshop page for this\r\ncustom game. Right-click for" +
        " more options.");
			this.ps17.UseSelectable = true;
			this.ps17.Value = 80;
			this.ps17.Visible = false;
			// 
			// mt16
			// 
			this.mt16.ActiveControl = null;
			this.mt16.ContextMenuStrip = this.metroContextMenu1;
			this.mt16.Controls.Add(this.ps16);
			this.mt16.Location = new System.Drawing.Point(16, 420);
			this.mt16.Name = "mt16";
			this.mt16.Size = new System.Drawing.Size(128, 116);
			this.mt16.Style = MetroFramework.MetroColorStyle.Orange;
			this.mt16.TabIndex = 30;
			this.mt16.Text = "metroTile10";
			this.mt16.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.mt16.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroToolTip1.SetToolTip(this.mt16, "Left-click to open the Steam Workshop page for this\r\ncustom game. Right-click for" +
        " more options.");
			this.mt16.UseSelectable = true;
			this.mt16.Visible = false;
			this.mt16.Click += new System.EventHandler(this.onTileClick);
			// 
			// ps16
			// 
			this.ps16.Location = new System.Drawing.Point(44, 38);
			this.ps16.Maximum = 100;
			this.ps16.Name = "ps16";
			this.ps16.Size = new System.Drawing.Size(40, 40);
			this.ps16.Style = MetroFramework.MetroColorStyle.Orange;
			this.ps16.TabIndex = 38;
			this.metroToolTip1.SetToolTip(this.ps16, "Left-click to open the Steam Workshop page for this\r\ncustom game. Right-click for" +
        " more options.");
			this.ps16.UseSelectable = true;
			this.ps16.Value = 80;
			this.ps16.Visible = false;
			// 
			// nextBtn
			// 
			this.nextBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.nextBtn.Highlight = true;
			this.nextBtn.Location = new System.Drawing.Point(544, 544);
			this.nextBtn.Name = "nextBtn";
			this.nextBtn.Size = new System.Drawing.Size(92, 36);
			this.nextBtn.TabIndex = 35;
			this.nextBtn.Text = "Next";
			this.nextBtn.UseSelectable = true;
			this.nextBtn.Visible = false;
			this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
			// 
			// backBtn
			// 
			this.backBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.backBtn.Highlight = true;
			this.backBtn.Location = new System.Drawing.Point(52, 544);
			this.backBtn.Name = "backBtn";
			this.backBtn.Size = new System.Drawing.Size(92, 36);
			this.backBtn.TabIndex = 36;
			this.backBtn.Text = "Back";
			this.backBtn.UseSelectable = true;
			this.backBtn.Visible = false;
			this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
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
			this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroToolTip1.StyleManager = null;
			this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
			// 
			// versionLink
			// 
			this.versionLink.Cursor = System.Windows.Forms.Cursors.Hand;
			this.versionLink.Location = new System.Drawing.Point(544, 28);
			this.versionLink.Name = "versionLink";
			this.versionLink.Size = new System.Drawing.Size(75, 23);
			this.versionLink.TabIndex = 39;
			this.versionLink.Text = "metroLink1";
			this.metroToolTip1.SetToolTip(this.versionLink, "View the changelog!");
			this.versionLink.UseSelectable = true;
			this.versionLink.Click += new System.EventHandler(this.versionLink_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(689, 595);
			this.Controls.Add(this.versionLink);
			this.Controls.Add(this.dummyBtn);
			this.Controls.Add(this.backBtn);
			this.Controls.Add(this.nextBtn);
			this.Controls.Add(this.mt20);
			this.Controls.Add(this.mt19);
			this.Controls.Add(this.mt18);
			this.Controls.Add(this.mt17);
			this.Controls.Add(this.mt16);
			this.Controls.Add(this.mt15);
			this.Controls.Add(this.mt14);
			this.Controls.Add(this.mt13);
			this.Controls.Add(this.mt12);
			this.Controls.Add(this.mt11);
			this.Controls.Add(this.mt10);
			this.Controls.Add(this.mt9);
			this.Controls.Add(this.mt8);
			this.Controls.Add(this.mt7);
			this.Controls.Add(this.mt6);
			this.Controls.Add(this.mt5);
			this.Controls.Add(this.mt4);
			this.Controls.Add(this.mt3);
			this.Controls.Add(this.mt2);
			this.Controls.Add(this.mt1);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Style = MetroFramework.MetroColorStyle.Teal;
			this.Text = "Installed Custom Games";
			this.mt1.ResumeLayout(false);
			this.metroContextMenu1.ResumeLayout(false);
			this.mt2.ResumeLayout(false);
			this.mt3.ResumeLayout(false);
			this.mt4.ResumeLayout(false);
			this.mt5.ResumeLayout(false);
			this.mt10.ResumeLayout(false);
			this.mt9.ResumeLayout(false);
			this.mt8.ResumeLayout(false);
			this.mt7.ResumeLayout(false);
			this.mt6.ResumeLayout(false);
			this.mt15.ResumeLayout(false);
			this.mt14.ResumeLayout(false);
			this.mt13.ResumeLayout(false);
			this.mt12.ResumeLayout(false);
			this.mt11.ResumeLayout(false);
			this.mt20.ResumeLayout(false);
			this.mt19.ResumeLayout(false);
			this.mt18.ResumeLayout(false);
			this.mt17.ResumeLayout(false);
			this.mt16.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public MetroFramework.Controls.MetroTile mt1;
		public MetroFramework.Controls.MetroTile mt2;
		public MetroFramework.Controls.MetroTile mt3;
		public MetroFramework.Controls.MetroTile mt4;
		public MetroFramework.Controls.MetroTile mt5;
		public MetroFramework.Controls.MetroTile mt10;
		public MetroFramework.Controls.MetroTile mt9;
		public MetroFramework.Controls.MetroTile mt8;
		public MetroFramework.Controls.MetroTile mt7;
		public MetroFramework.Controls.MetroTile mt6;
		public MetroFramework.Controls.MetroTile mt15;
		public MetroFramework.Controls.MetroTile mt14;
		public MetroFramework.Controls.MetroTile mt13;
		public MetroFramework.Controls.MetroTile mt12;
		public MetroFramework.Controls.MetroTile mt11;
		public MetroFramework.Controls.MetroTile mt20;
		public MetroFramework.Controls.MetroTile mt19;
		public MetroFramework.Controls.MetroTile mt18;
		public MetroFramework.Controls.MetroTile mt17;
		public MetroFramework.Controls.MetroTile mt16;
		public MetroFramework.Controls.MetroProgressSpinner ps1;
		public MetroFramework.Controls.MetroProgressSpinner ps2;
		public MetroFramework.Controls.MetroProgressSpinner ps3;
		public MetroFramework.Controls.MetroProgressSpinner ps4;
		public MetroFramework.Controls.MetroProgressSpinner ps5;
		public MetroFramework.Controls.MetroProgressSpinner ps10;
		public MetroFramework.Controls.MetroProgressSpinner ps9;
		public MetroFramework.Controls.MetroProgressSpinner ps8;
		public MetroFramework.Controls.MetroProgressSpinner ps7;
		public MetroFramework.Controls.MetroProgressSpinner ps6;
		public MetroFramework.Controls.MetroProgressSpinner ps15;
		public MetroFramework.Controls.MetroProgressSpinner ps14;
		public MetroFramework.Controls.MetroProgressSpinner ps13;
		public MetroFramework.Controls.MetroProgressSpinner ps12;
		public MetroFramework.Controls.MetroProgressSpinner ps11;
		public MetroFramework.Controls.MetroProgressSpinner ps20;
		public MetroFramework.Controls.MetroProgressSpinner ps19;
		public MetroFramework.Controls.MetroProgressSpinner ps18;
		public MetroFramework.Controls.MetroProgressSpinner ps17;
		public MetroFramework.Controls.MetroProgressSpinner ps16;
		public MetroFramework.Controls.MetroButton nextBtn;
		public MetroFramework.Controls.MetroButton backBtn;
		public MetroFramework.Controls.MetroRadioButton dummyBtn;
		private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
		private System.Windows.Forms.ToolStripMenuItem openVPKToolStripMenuItem;
		private MetroFramework.Components.MetroToolTip metroToolTip1;
		private MetroFramework.Controls.MetroLink versionLink;
	}
}

